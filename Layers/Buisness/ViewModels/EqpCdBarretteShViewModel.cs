using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdBarretteShViewModel : ViewModelBase
    {
        public EqpCdBarretteSh Model {get; set;}
        public EqpCdBarretteShViewModel(EqpCdBarretteSh model)
        {
            this.EqpDscShs = new  ObservableCollection<EqpDscShViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Barette=this.Model.Barette;
        }
        public override void Write()
        {
            this.Model.Barette=this.Barette;
        }
        public virtual ObservableCollection<EqpDscShViewModel> EqpDscShs { get; set; }
        
        private String _barette;
        [DisplayName("Barette")]
        public String Barette
        {
            get
            {
                return this._barette;
            }
            set
            {
                this._barette = value;
                RaisePropertyChange("Barette");
            }
        }
    }
}
