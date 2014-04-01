using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsNatureTravViewModel : ViewModelBase
    {
        public GmsNatureTrav Model {get; set;}
        public GmsNatureTravViewModel(GmsNatureTrav model)
        {
            this.GmsTravauxs = new  ObservableCollection<GmsTravauxViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCdTravaux=new GmsCdTravauxViewModel( this.Model.GmsCdTravaux);
            this.Nature=this.Model.Nature;
        }
        public override void Write()
        {
            this.Model.GmsCdTravaux=this. GmsCdTravaux.Model;
            this.Model.Nature=this.Nature;
        }
        private GmsCdTravauxViewModel _gmsCdTravaux;
        [DisplayName("Type travaux")]
        public virtual GmsCdTravauxViewModel GmsCdTravaux
        {
            get
            {
                return this._gmsCdTravaux;
            }
            set
            {
                this._gmsCdTravaux = value;
                RaisePropertyChange("GmsCdTravaux");
            }
        }
        
        public virtual ObservableCollection<GmsTravauxViewModel> GmsTravauxs { get; set; }
        
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
