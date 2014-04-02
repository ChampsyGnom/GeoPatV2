using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Emash.GeoPat.Layers.Shared.Behaviors
{
    public class DataGridDoubleClickBehavior : Behavior<DataGrid>
    {
        public static readonly DependencyProperty CommandProperty =
     DependencyProperty.Register("Command", typeof(DelegateCommand),
     typeof(DataGridDoubleClickBehavior), new FrameworkPropertyMetadata(null));

        // .NET Property wrapper
        public DelegateCommand Command
        {
            get { return (DelegateCommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.MouseDoubleClick += AssociatedObject_MouseDoubleClick;
        }

        protected override void OnDetaching()
        {
            this.AssociatedObject.MouseDoubleClick -= AssociatedObject_MouseDoubleClick;
            base.OnDetaching();
        }

        void AssociatedObject_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.Command != null && this.Command.CanExecute())
            { this.Command.Execute(); }
           
               
        }
    }
}
