using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdAppuiViewModel : ViewModelBase<OaCdAppui>
    {
        public OaCdAppuiViewModel(OaCdAppui model) : base(model)
        {
            this.OaAppuiss = new  ObservableCollection<OaAppuisViewModel>();
            
        }
        public override void Read()
        {
            this.App=this.Model.App;
        }
        public override void Write()
        {
            this.Model.App=this.App;
        }
        public virtual ObservableCollection<OaAppuisViewModel> OaAppuiss { get; set; }
        
        private String _app;
        [DisplayName("Type d'appui")]
        public String App
        {
            get
            {
                return this._app;
            }
            set
            {
                this._app = value;
                RaisePropertyChange("App");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["App"] != null)
                {
                    errors.Add("Type d'appui : "+this["App"]);
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
                if (columnName.Equals("App"))
                {
                    if (String.IsNullOrEmpty(this.App))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
