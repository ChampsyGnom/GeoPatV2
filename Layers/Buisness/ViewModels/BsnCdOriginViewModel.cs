using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdOriginViewModel : ViewModelBase<BsnCdOrigin>
    {
        public BsnCdOriginViewModel(BsnCdOrigin model) : base(model)
        {
            this.BsnHistoNotes = new  ObservableCollection<BsnHistoNoteViewModel>();
            
        }
        public override void Read()
        {
            this.Origine=this.Model.Origine;
        }
        public override void Write()
        {
            this.Model.Origine=this.Origine;
        }
        public virtual ObservableCollection<BsnHistoNoteViewModel> BsnHistoNotes { get; set; }
        
        private String _origine;
        [DisplayName("Origine Note")]
        public String Origine
        {
            get
            {
                return this._origine;
            }
            set
            {
                this._origine = value;
                RaisePropertyChange("Origine");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Origine"] != null)
                {
                    errors.Add("Origine Note : "+this["Origine"]);
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
                if (columnName.Equals("Origine"))
                {
                    if (String.IsNullOrEmpty(this.Origine))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
