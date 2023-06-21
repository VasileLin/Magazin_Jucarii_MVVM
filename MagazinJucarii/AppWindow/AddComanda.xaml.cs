using MagazinJucarii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using AppContext = MagazinJucarii.Models.AppContext;

namespace MagazinJucarii.AppWindow
{
    /// <summary>
    /// Interaction logic for AddComanda.xaml
    /// </summary>
    public partial class AddComanda : Window
    {
        AppContext appContext = new AppContext();
        public Comanda Comanda { get; set; }
        public AddComanda(Comanda comanda)
        {
            InitializeComponent();
            cbxJucarii.ItemsSource = appContext.GetJucarii().ToList();
            Comanda = comanda;
            DataContext = comanda;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (btnAddComanda.Content == "Modifica Comanda")
            {
                dpDataProcurarii.SelectedDate = DateTime.Parse(Comanda.DataProcurarii.ToString());
            }
            else
            {
                dpDataProcurarii.SelectedDate = DateTime.Now.Date;
            }
         
        }
    }
}
