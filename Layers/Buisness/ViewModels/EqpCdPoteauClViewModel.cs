using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdPoteauClViewModel : ViewModelBase<EqpCdPoteauCl>
    {
        public EqpCdPoteauClViewModel(EqpCdPoteauCl model) : base(model)
        {
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
        }
        public override void Read()
        {
            this.Poteaux=this.Model.Poteaux;
        }
        public override void Write()
        {
            this.Model.Poteaux=this.Poteaux;
        }
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _poteaux;
        [DisplayName("Poteaux")]
        public String Poteaux
        {
            get
            {
                return this._poteaux;
            }
            set
            {
                this._poteaux = value;
                RaisePropertyChange("Poteaux");
            }
        }
    }
}
