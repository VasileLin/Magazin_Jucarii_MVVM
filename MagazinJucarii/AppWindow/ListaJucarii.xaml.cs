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

namespace MagazinJucarii.AppWindow
{
    /// <summary>
    /// Interaction logic for ListaJucarii.xaml
    /// </summary>
    public partial class ListaJucarii : Window
    {
        AppViewModel appViewModel = new AppViewModel();
        public ListaJucarii()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            DataContext = null;
            DataContext = appViewModel;
        }

        private void Editare_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AppViewModel;
            if (viewModel != null && viewModel.EditJucariiCommand != null && viewModel.EditJucariiCommand.CanExecute(dgJucarii.SelectedItem))
            {
                viewModel.EditJucariiCommand.Execute(dgJucarii.SelectedItem);
                RefreshDataGrid();
            }
        }

        private void Sterge_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AppViewModel;
            if (viewModel != null && viewModel.DeleteJucarieCommand != null && viewModel.EditJucariiCommand.CanExecute(dgJucarii.SelectedItem))
            {
                viewModel.DeleteJucarieCommand.Execute(dgJucarii.SelectedItem);
                RefreshDataGrid();
            }
        }
    }
}
