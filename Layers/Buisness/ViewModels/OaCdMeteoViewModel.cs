using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdMeteoViewModel : ViewModelBase<OaCdMeteo>
    {
        public OaCdMeteoViewModel(OaCdMeteo model) : base(model)
        {
            this.OaInsps = new  ObservableCollection<OaInspViewModel>();
            
            this.OaInspTmps = new  ObservableCollection<OaInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Meteo=this.Model.Meteo;
        }
        public override void Write()
        {
            this.Model.Meteo=this.Meteo;
        }
        public virtual ObservableCollection<OaInspViewModel> OaInsps { get; set; }
        
        public virtual ObservableCollection<OaInspTmpViewModel> OaInspTmps { get; set; }
        
        private String _meteo;
        [DisplayName("Condition météo")]
        public String Meteo
        {
            get
            {
                return this._meteo;
            }
            set
            {
                this._meteo = value;
                RaisePropertyChange("Meteo");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Meteo"] != null)
                {
                    errors.Add("Condition météo : "+this["Meteo"]);
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
                if (columnName.Equals("Meteo"))
                {
                    if (String.IsNullOrEmpty(this.Meteo))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
