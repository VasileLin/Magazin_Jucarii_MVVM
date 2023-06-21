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
    /// Interaction logic for ShowSumaJucarii.xaml
    /// </summary>
    public partial class ShowSumaJucarii : Window
    {
        AppContext appContext = new AppContext();
        AppViewModel viewModel = new AppViewModel();
        public ShowSumaJucarii()
        {
            InitializeComponent();   
            dgJucarii.ItemsSource = appContext.GetSumaTotalaPerJucarie();
            dgJucarii.Items.Refresh();
        }

        public void RefreshGrid()
        {
            DataContext = null;
            DataContext = viewModel;
        }
    }
}
