using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdGestViewModel : ViewModelBase<OaCdGest>
    {
        public OaCdGestViewModel(OaCdGest model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Gestionnaire=this.Model.Gestionnaire;
        }
        public override void Write()
        {
            this.Model.Gestionnaire=this.Gestionnaire;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _gestionnaire;
        [DisplayName("Gestionnaire")]
        public String Gestionnaire
        {
            get
            {
                return this._gestionnaire;
            }
            set
            {
                this._gestionnaire = value;
                RaisePropertyChange("Gestionnaire");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Gestionnaire"] != null)
                {
                    errors.Add("Gestionnaire : "+this["Gestionnaire"]);
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
                if (columnName.Equals("Gestionnaire"))
                {
                    if (String.IsNullOrEmpty(this.Gestionnaire))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
