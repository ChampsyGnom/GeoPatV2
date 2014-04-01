using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Layers.Buisness
{
    public abstract class ViewModelBase<M> : INotifyPropertyChanged
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

        [Browsable(false)]
        public M Model { get; set; }
        public ViewModelBase(M model)
        {           
            this.Model = model;
            this.Read();
        }

    }
}
