using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdFamAppuiViewModel : ViewModelBase<OaCdFamAppui>
    {
        public OaCdFamAppuiViewModel(OaCdFamAppui model) : base(model)
        {
            this.OaAppuiss = new  ObservableCollection<OaAppuisViewModel>();
            
        }
        public override void Read()
        {
            this.FamApp=this.Model.FamApp;
        }
        public override void Write()
        {
            this.Model.FamApp=this.FamApp;
        }
        public virtual ObservableCollection<OaAppuisViewModel> OaAppuiss { get; set; }
        
        private String _famApp;
        [DisplayName("Famille d'appuis")]
        public String FamApp
        {
            get
            {
                return this._famApp;
            }
            set
            {
                this._famApp = value;
                RaisePropertyChange("FamApp");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["FamApp"] != null)
                {
                    errors.Add("Famille d'appuis : "+this["FamApp"]);
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
                if (columnName.Equals("FamApp"))
                {
                    if (String.IsNullOrEmpty(this.FamApp))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
