using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnNatureTravViewModel : ViewModelBase<BsnNatureTrav>
    {
        public BsnNatureTravViewModel(BsnNatureTrav model) : base(model)
        {
            this.BsnTravauxs = new  ObservableCollection<BsnTravauxViewModel>();
            
        }
        public override void Read()
        {
            this.BsnCdTravaux=new BsnCdTravauxViewModel( this.Model.BsnCdTravaux);
            this.Nature=this.Model.Nature;
        }
        public override void Write()
        {
            this.Model.BsnCdTravaux=this. BsnCdTravaux.Model;
            this.Model.Nature=this.Nature;
        }
        private BsnCdTravauxViewModel _bsnCdTravaux;
        [DisplayName("Type travaux")]
        public virtual BsnCdTravauxViewModel BsnCdTravaux
        {
            get
            {
                return this._bsnCdTravaux;
            }
            set
            {
                this._bsnCdTravaux = value;
                RaisePropertyChange("BsnCdTravaux");
            }
        }
        
        public virtual ObservableCollection<BsnTravauxViewModel> BsnTravauxs { get; set; }
        
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nature"] != null)
                {
                    errors.Add("Nature travaux : "+this["Nature"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Nature"))
                {
                    if (String.IsNullOrEmpty(this.Nature))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
