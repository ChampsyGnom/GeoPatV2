using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhNatureTravViewModel : ViewModelBase<OhNatureTrav>
    {
        public OhNatureTravViewModel(OhNatureTrav model) : base(model)
        {
            this.OhTravauxs = new  ObservableCollection<OhTravauxViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdTravaux=new OhCdTravauxViewModel( this.Model.OhCdTravaux);
            this.Nature=this.Model.Nature;
        }
        public override void Write()
        {
            this.Model.OhCdTravaux=this. OhCdTravaux.Model;
            this.Model.Nature=this.Nature;
        }
        private OhCdTravauxViewModel _ohCdTravaux;
        [DisplayName("Type travaux")]
        public virtual OhCdTravauxViewModel OhCdTravaux
        {
            get
            {
                return this._ohCdTravaux;
            }
            set
            {
                this._ohCdTravaux = value;
                RaisePropertyChange("OhCdTravaux");
            }
        }
        
        public virtual ObservableCollection<OhTravauxViewModel> OhTravauxs { get; set; }
        
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
