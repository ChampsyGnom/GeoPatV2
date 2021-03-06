using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsNatureTravViewModel : ViewModelBase<GmsNatureTrav>
    {
        public GmsNatureTravViewModel(GmsNatureTrav model) : base(model)
        {
            this.GmsTravauxs = new  ObservableCollection<GmsTravauxViewModel>();
            
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
