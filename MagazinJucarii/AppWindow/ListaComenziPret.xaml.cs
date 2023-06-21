using MagazinJucarii.ViewModel;
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
using AppContext = MagazinJucarii.Models.AppContext;

namespace MagazinJucarii.AppWindow
{
    /// <summary>
    /// Interaction logic for ListaComenziPret.xaml
    /// </summary>
    public partial class ListaComenziPret : Window
    {
        AppContext db = new AppContext();
        AppViewModel viewModel = new AppViewModel();
        public ListaComenziPret()
        {
            InitializeComponent();
            dgComenzi.ItemsSource = db.GetComenziPret();
            dgComenzi.Items.Refresh();       
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            DataContext = null;
            DataContext = viewModel;
        }
    }
}
