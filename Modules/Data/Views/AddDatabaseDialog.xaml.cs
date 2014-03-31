using Emash.GeoPat.Modules.Data.ViewModels;
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

namespace Emash.GeoPat.Modules.Data.Views
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class AddDatabaseDialog : Window
    {
        public ConfigurationDatabaseViewModel ViewModel { get; private set; }
        public AddDatabaseDialog(ConfigurationDatabaseViewModel viewModel)
        {
            this.DataContext = viewModel;
            this.ViewModel = viewModel;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
