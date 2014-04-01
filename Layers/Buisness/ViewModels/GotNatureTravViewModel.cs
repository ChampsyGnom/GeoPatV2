using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotNatureTravViewModel : ViewModelBase<GotNatureTrav>
    {
        public GotNatureTravViewModel(GotNatureTrav model) : base(model)
        {
            this.GotTravauxs = new  ObservableCollection<GotTravauxViewModel>();
            
        }
        public override void Read()
        {
            this.GotCdTravaux=new GotCdTravauxViewModel( this.Model.GotCdTravaux);
            this.Nature=this.Model.Nature;
        }
        public override void Write()
        {
            this.Model.GotCdTravaux=this. GotCdTravaux.Model;
            this.Model.Nature=this.Nature;
        }
        private GotCdTravauxViewModel _gotCdTravaux;
        [DisplayName("Type travaux")]
        public virtual GotCdTravauxViewModel GotCdTravaux
        {
            get
            {
                return this._gotCdTravaux;
            }
            set
            {
                this._gotCdTravaux = value;
                RaisePropertyChange("GotCdTravaux");
            }
        }
        
        public virtual ObservableCollection<GotTravauxViewModel> GotTravauxs { get; set; }
        
        private String _nature;
        [DisplayName("Nature travaux")]
        public String Nature
        {
            get
            {
                return this._nature;
            }
            set
            {
                this._nature = value;
                RaisePropertyChange("Nature");
            }
        }
    }
}
