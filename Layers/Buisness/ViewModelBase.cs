using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Layers.Buisness
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public abstract void Read();
        public abstract void Write();
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChange(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            { handler(this, new PropertyChangedEventArgs(name)); }

        }
    }
}
