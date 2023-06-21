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
    /// Interaction logic for ListaJucariiVarsta.xaml
    /// </summary>
    public partial class ListaJucariiVarsta : Window
    {
        AppViewModel appView = new AppViewModel();
        AppContext appContext = new AppContext();
        public ListaJucariiVarsta()
        {
            InitializeComponent();
            dgJucarii.ItemsSource = appContext.GetJucariiVarsta();
            dgJucarii.Items.Refresh();
            DataContext = appView;
            
        }
    }
}
