using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Emash.GeoPat.Layers.Engine.AttachedProperties
{
    public class DataGridConfig : FrameworkElement
    {
        public static Boolean GetUseDisplayNameForHeader(DependencyObject obj)
        {
            return (Boolean)obj.GetValue(UseDisplayNameForHeaderProperty);
        }

        public static void SetUseDisplayNameForHeader(DependencyObject obj, Boolean value)
        {
            obj.SetValue(UseDisplayNameForHeaderProperty, value);
        }

        public static readonly DependencyProperty UseDisplayNameForHeaderProperty =
            DependencyProperty.RegisterAttached("UseDisplayNameForHeader",
            typeof(Boolean), typeof(DataGridConfig), new PropertyMetadata
            (false, new PropertyChangedCallback(UseDisplayNameForHeaderChanged)));

        private static void UseDisplayNameForHeaderChanged (DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid)
            {
                (d as DataGrid).AutoGeneratingColumn += DataGridConfig_AutoGeneratingColumn;
            }
     
        }

        static void DataGridConfig_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyDescriptor != null )
            {

                PropertyInfo propDisplayName = e.PropertyDescriptor.GetType().GetProperty("DisplayName");
                PropertyInfo propComponentType = e.PropertyDescriptor.GetType().GetProperty("ComponentType");
                Type componentType = propComponentType.GetValue(e.PropertyDescriptor) as Type;
                PropertyInfo propertyInfo = componentType.GetProperty(e.PropertyName);
                if (propertyInfo.GetGetMethod().IsVirtual)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (propDisplayName != null)
                    {
                        Object objDisplayName = propDisplayName.GetValue(e.PropertyDescriptor);
                        if (objDisplayName != null)
                        { e.Column.Header = objDisplayName.ToString(); }
                    }
                }
                
                
            }
            
        }
    }
}
