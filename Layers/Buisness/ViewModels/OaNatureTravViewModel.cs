using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaNatureTravViewModel : ViewModelBase<OaNatureTrav>
    {
        public OaNatureTravViewModel(OaNatureTrav model) : base(model)
        {
            this.OaTravauxs = new  ObservableCollection<OaTravauxViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdTravaux=new OaCdTravauxViewModel( this.Model.OaCdTravaux);
            this.Nature=this.Model.Nature;
        }
        public override void Write()
        {
            this.Model.OaCdTravaux=this. OaCdTravaux.Model;
            this.Model.Nature=this.Nature;
        }
        private OaCdTravauxViewModel _oaCdTravaux;
        [DisplayName("Type travaux")]
        public virtual OaCdTravauxViewModel OaCdTravaux
        {
            get
            {
                return this._oaCdTravaux;
            }
            set
            {
                this._oaCdTravaux = value;
                RaisePropertyChange("OaCdTravaux");
            }
        }
        
        public virtual ObservableCollection<OaTravauxViewModel> OaTravauxs { get; set; }
        
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
