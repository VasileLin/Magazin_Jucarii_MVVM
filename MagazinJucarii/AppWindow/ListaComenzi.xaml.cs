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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        AppViewModel viewModel = new AppViewModel();

        public Window1()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            DataContext = null;
            DataContext = viewModel;
        }

        private void Editare_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AppViewModel;
            if (viewModel != null && viewModel.EditComandaCommand != null && viewModel.EditComandaCommand.CanExecute(dgComenzi.SelectedItem))
            {
                viewModel.EditComandaCommand.Execute(dgComenzi.SelectedItem);
                RefreshDataGrid();
            }
        }

        private void Sterge_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as AppViewModel;
            if (viewModel != null && viewModel.DeleteComandaCommand != null && viewModel.DeleteComandaCommand.CanExecute(dgComenzi.SelectedItem))
            {
                viewModel.DeleteComandaCommand.Execute(dgComenzi.SelectedItem);
                RefreshDataGrid();
            }
        }
    }
}
