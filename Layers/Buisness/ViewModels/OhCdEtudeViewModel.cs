using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEtudeViewModel : ViewModelBase<OhCdEtude>
    {
        public OhCdEtudeViewModel(OhCdEtude model) : base(model)
        {
            this.OhInsps = new  ObservableCollection<OhInspViewModel>();
            
            this.OhInspTmps = new  ObservableCollection<OhInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Etude=this.Model.Etude;
        }
        public override void Write()
        {
            this.Model.Etude=this.Etude;
        }
        public virtual ObservableCollection<OhInspViewModel> OhInsps { get; set; }
        
        public virtual ObservableCollection<OhInspTmpViewModel> OhInspTmps { get; set; }
        
        private String _etude;
        [DisplayName("Etude-Expertise")]
        public String Etude
        {
            get
            {
                return this._etude;
            }
            set
            {
                this._etude = value;
                RaisePropertyChange("Etude");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Etude"] != null)
                {
                    errors.Add("Etude-Expertise : "+this["Etude"]);
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
                if (columnName.Equals("Etude"))
                {
                    if (String.IsNullOrEmpty(this.Etude))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
