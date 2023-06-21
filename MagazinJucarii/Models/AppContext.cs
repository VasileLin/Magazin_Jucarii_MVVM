using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinJucarii.Models
{
    public class AppContext:DbContext
    {
        public DbSet<Jucarie> Jucarii { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = jucarii.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jucarie>().HasKey(c=>c.CodJucarie);
            modelBuilder.Entity<Comanda>().HasKey(d=>d.CodComanda);
            modelBuilder.Entity<Comanda>().HasOne(c => c.Jucarie).WithMany().HasForeignKey(c=>c.CodJucarie);
        }

        public ObservableCollection<Jucarie> GetJucarii()
        {
            var jucarii = Jucarii.ToList();
            var jucariiObservable = new ObservableCollection<Jucarie>(jucarii);
            return jucariiObservable;
        }

        public void AdaugaJucarie(Jucarie jucarie)
        {
            Jucarii.Add(jucarie);
            SaveChanges();
        }

        public void ActualizeazaJucarie(Jucarie jucarie)
        {
            Jucarii.Entry(jucarie).State = EntityState.Modified;
            SaveChanges();
        }

        public void StergeJucarie(Jucarie jucarie)
        {
            Jucarii.Remove(jucarie);
            SaveChanges();
        }

        public void StergeComanda(Comanda comanda)
        {
            Comenzi.Remove(comanda);
            SaveChanges();
        }


        public void AdaugaComanda(Comanda comanda)
        {
            Comenzi.Add(comanda);
            SaveChanges();
        }

        public void ActualizeazaComanda(Comanda comanda)
        {
            Comenzi.Entry(comanda).State = EntityState.Modified;
            SaveChanges();
        }

        public List<Comanda> GetComenziPret()
        {
            var query = from o in Comenzi
                        where o.Jucarie != null && o.Jucarie.Pret >= 30 && o.Jucarie.Pret <= 50
                        select o;

            var comenziWithJucarie = query.ToList();

            // Încarcă obiectele Jucarie asociate
            foreach (var comanda in comenziWithJucarie)
            {
                Entry(comanda).Reference(c => c.Jucarie).Load();
            }

            return comenziWithJucarie;
        }

        public List<Jucarie> GetJucariiVarsta()
        {
            var query = from o in Jucarii where o.VarstaRecomandata >=7 && o.VarstaRecomandata<=10 select o;
            return query.ToList();
        }

        public List<Comanda> GetComenziData()
        {
            var queryData = from o in Comenzi
                        where o.DataProcurarii.Year>2019 && o.DataProcurarii.Year<2022
                        select o;

            var comenziData = queryData.ToList();

            // Încarcă obiectele Jucarie asociate
            foreach (var comanda in comenziData)
            {
                Entry(comanda).Reference(c => c.Jucarie).Load();
            }

            return comenziData;
        }

        public List<SumaJucarii> GetSumaTotalaPerJucarie()
        {

            var sumaTotalaPerJucarie = Comenzi
                .GroupBy(c => c.Jucarie.Denumire)
                .Select(g => new SumaJucarii
                {
                    Denumire = g.Key,
                    Suma = g.Sum(c => c.Jucarie.Pret)
                });

            List<SumaJucarii> result = sumaTotalaPerJucarie.ToList();
            return result;
        }

    }
}
