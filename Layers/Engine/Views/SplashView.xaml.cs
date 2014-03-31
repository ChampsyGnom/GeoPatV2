using Emash.GeoPat.Layers.Engine.Services;
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

namespace Emash.GeoPat.Layers.Engine.Views
{
    /// <summary>
    /// Logique d'interaction pour SplashView.xaml
    /// </summary>
    public partial class SplashView : Window
    {
        public SplashView(SplashService splashService)
        {
            this.DataContext = splashService;
            InitializeComponent();
        }
    }
}
