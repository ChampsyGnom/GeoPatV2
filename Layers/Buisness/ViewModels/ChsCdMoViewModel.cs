using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdMoViewModel : ViewModelBase<ChsCdMo>
    {
        public ChsCdMoViewModel(ChsCdMo model) : base(model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
        }
        public override void Read()
        {
            this.Mo=this.Model.Mo;
        }
        public override void Write()
        {
            this.Model.Mo=this.Mo;
        }
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
        private String _mo;
        [DisplayName("Maître d'oeuvre")]
        public String Mo
        {
            get
            {
                return this._mo;
            }
            set
            {
                this._mo = value;
                RaisePropertyChange("Mo");
            }
        }
    }
}
