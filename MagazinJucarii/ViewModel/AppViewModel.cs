using MagazinJucarii.AppWindow;
using MagazinJucarii.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using AppContext = MagazinJucarii.Models.AppContext;

namespace MagazinJucarii.ViewModel
{
    public class AppViewModel
    {
        AppContext db = new AppContext();
        RelayCommand? addJucarieCommand;
        RelayCommand? editJucarieCommand;
        RelayCommand? deletejucarieCommand;
        RelayCommand? showJucariiCommand;
        RelayCommand? addComandaCommand;
        RelayCommand? deleteComandaCommand;
        RelayCommand? editComandaCommand;
        RelayCommand? showComenziCommand;
        RelayCommand? showComenziPretCommand;
        RelayCommand? showJucariiSumaCommand;
        RelayCommand? showComenziData;
        RelayCommand? showJucariiVarstaData;

        public ObservableCollection<Jucarie>? Jucarii { get; set; }
        public ObservableCollection<Comanda>? Comenzi { get; set; }

        public AppViewModel()
        {
            db.Database.EnsureCreated();
            db.Jucarii.Load();
            db.Comenzi.Load();
            Jucarii = db.Jucarii.Local.ToObservableCollection();
            Comenzi = db.Comenzi.Local.ToObservableCollection();
        }

        public RelayCommand AddJucarieCommand
        {
            get
            {
                return addJucarieCommand ?? (addJucarieCommand = new RelayCommand((o) =>
                {
                    AddJucarie jucatieWindow = new AddJucarie(new Jucarie());
                    if (jucatieWindow.ShowDialog() == true)
                    {
                        Jucarie jucarie = jucatieWindow.Jucarie;
                        db.AdaugaJucarie(jucarie);
                        MessageBox.Show("Jucaria a fost adaugata!");
                    }
                }));
            }
        }

        public RelayCommand AddComandaCommand
        {
            get
            {
                return addComandaCommand ?? (addComandaCommand = new RelayCommand((o) =>
                {
                    AddComanda comandaWindow = new AddComanda(new Comanda());
                    if (comandaWindow.ShowDialog() == true)
                    {
                        Comanda comanda = comandaWindow.Comanda;
                        comanda.DataProcurarii = DateOnly.Parse(comandaWindow.dpDataProcurarii.SelectedDate.Value.Date.ToShortDateString());
                        if (comandaWindow.cbxJucarii.SelectedItem != null)
                        {
                            comanda.CodJucarie = ((Jucarie)comandaWindow.cbxJucarii.SelectedItem).CodJucarie;
                        }
                        db.AdaugaComanda(comanda);
                        MessageBox.Show("Comanda a fost inregistrata!");
                    }
                }));
            }
        }


        public RelayCommand EditJucariiCommand
        {
            get
            {
                return editJucarieCommand ??
                    (editJucarieCommand = new RelayCommand((selectedItem) =>
                    {
                        //obtinem obiectul selectat

                        Jucarie? jucarie = selectedItem as Jucarie;
                        if (jucarie == null)
                        {
                            return;
                        } 
                        Jucarie vm = new Jucarie
                        {
                            CodJucarie = jucarie.CodJucarie,
                            Denumire = jucarie.Denumire,
                            VarstaRecomandata = jucarie.VarstaRecomandata,
                            Serie = jucarie.Serie,
                            Pret = jucarie.Pret

                        };
                        AddJucarie jucarieWindow = new AddJucarie(vm);
                        Button editButton = jucarieWindow.btnAddJucarie;
                        editButton.Content = "Modifica Agentul";

                        if (jucarieWindow.ShowDialog() == true)
                        {
                            jucarie.CodJucarie = jucarieWindow.Jucarie.CodJucarie;
                            jucarie.Denumire = jucarieWindow.Jucarie.Denumire;
                            jucarie.VarstaRecomandata = jucarieWindow.Jucarie.VarstaRecomandata;
                            jucarie.Serie = jucarieWindow.Jucarie.Serie;
                            jucarie.Pret = jucarieWindow.Jucarie.Pret;
                            db.ActualizeazaJucarie(jucarie);
                        }
                    }));
            }
        }



        public RelayCommand EditComandaCommand
        {
            get
            {
                return editComandaCommand ??
                    (editComandaCommand = new RelayCommand((selectedItem) =>
                    {
                        //obtinem obiectul selectat

                        Comanda? comanda = selectedItem as Comanda;
                        if (comanda == null)
                        {
                            return;
                        }
                        Comanda vm = new Comanda
                        {
                            NumeClient = comanda.NumeClient,
                            DataProcurarii = comanda.DataProcurarii,
                            Jucarie = comanda.Jucarie,

                        };
                        AddComanda comandaWindow = new AddComanda(vm);
                        Button editButton = comandaWindow.btnAddComanda;
                        editButton.Content = "Modifica Comanda";


                        //Valoarea obiectuli selectat se afiseaza in combobox
                        Jucarie? selectedJucarie = null;
                        foreach (Jucarie jucarie in comandaWindow.cbxJucarii.Items)
                        {
                            if (jucarie.CodJucarie == comanda.Jucarie.CodJucarie)
                            {
                                selectedJucarie = jucarie;
                                break;
                            }
                        }
                        comandaWindow.cbxJucarii.SelectedItem = selectedJucarie;

                        if (comandaWindow.ShowDialog() == true)
                        {
                            comanda.NumeClient = comandaWindow.Comanda.NumeClient;
                            comanda.DataProcurarii = DateOnly.Parse(comandaWindow.dpDataProcurarii.SelectedDate.Value.Date.ToShortDateString());
                            comanda.CodJucarie = ((Jucarie)comandaWindow.cbxJucarii.SelectedItem).CodJucarie;
                            db.ActualizeazaComanda(comanda);
                        }
                    }));
            }
        }




        public RelayCommand DeleteJucarieCommand
        {
            get
            {
                return deletejucarieCommand ??
                    (deletejucarieCommand = new RelayCommand((selectedItem) =>
                    {
                        Jucarie? jucarie = selectedItem as Jucarie;
                        if (jucarie== null) { return; }
                        db.StergeJucarie(jucarie);
                    }));
            }
        }

        public RelayCommand DeleteComandaCommand
        {
            get
            {
                return deleteComandaCommand ??
                    (deleteComandaCommand = new RelayCommand((selectedItem) =>
                    {
                        Comanda? comanda = selectedItem as Comanda;
                        if (comanda == null) { return; }
                        db.StergeComanda(comanda);
                    }));
            }
        }

        public RelayCommand ShowJucarii
        {

            get
            {
                return showJucariiCommand ?? (showJucariiCommand = new RelayCommand((obj) =>
                {
                    ListaJucarii listaJucarii = new ListaJucarii();
                    listaJucarii.ShowDialog();
                }));
            }

        }


        public RelayCommand ShowComenzi
        {

            get
            {
                return showComenziCommand ?? (showComenziCommand = new RelayCommand((obj) =>
                {
                    Window1 listaComezi = new Window1();
                    listaComezi.ShowDialog();
                }));
            }

        }

        public RelayCommand ShowComenziPret
        {

            get
            {
                return showComenziPretCommand ?? (showComenziPretCommand = new RelayCommand((obj) => {
                    ListaComenziPret listaComenziPret = new ListaComenziPret();
                    listaComenziPret.ShowDialog();
                }));
            }

        }

        public RelayCommand ShowJucariiSumaCommand
        {

            get
            {
                return showJucariiSumaCommand ?? (showJucariiSumaCommand = new RelayCommand((obj) => {
                    ShowSumaJucarii listaComenziPret = new ShowSumaJucarii();
                    listaComenziPret.ShowDialog();
                }));
            }

        }

        public RelayCommand ShowComenziDataCommand
        {
            get
            {
                return showComenziData ?? (showComenziData = new RelayCommand((obj) => {
                    ListaComenziData listaComenziData = new ListaComenziData();
                    listaComenziData.ShowDialog();
                }));
            }

        }

        public RelayCommand ShowJucariiVarstaCommand
        {
            get
            {
                return showJucariiVarstaData ?? (showJucariiVarstaData = new RelayCommand((obj) => {
                    ListaJucariiVarsta listaJucariivarstaData = new ListaJucariiVarsta();
                    listaJucariivarstaData.ShowDialog();
                }));
            }

        }
    }
}
