using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdCauseViewModel : ViewModelBase<ChsCdCause>
    {
        public ChsCdCauseViewModel(ChsCdCause model) : base(model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
        }
        public override void Read()
        {
            this.Cause=this.Model.Cause;
        }
        public override void Write()
        {
            this.Model.Cause=this.Cause;
        }
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
        private String _cause;
        [DisplayName("Cause")]
        public String Cause
        {
            get
            {
                return this._cause;
            }
            set
            {
                this._cause = value;
                RaisePropertyChange("Cause");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Cause"] != null)
                {
                    errors.Add("Cause : "+this["Cause"]);
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
                if (columnName.Equals("Cause"))
                {
                    if (String.IsNullOrEmpty(this.Cause))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
