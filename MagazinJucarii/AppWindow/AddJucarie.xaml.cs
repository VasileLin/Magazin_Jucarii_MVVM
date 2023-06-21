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

namespace MagazinJucarii.AppWindow
{
    /// <summary>
    /// Interaction logic for AddJucarie.xaml
    /// </summary>
    public partial class AddJucarie : Window
    {
        public Jucarie Jucarie { get; set; }
        public AddJucarie(Jucarie jucarie)
        {
            InitializeComponent();
            Jucarie = jucarie;
            DataContext = jucarie;
        }

        private void btnAddJucarie_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
