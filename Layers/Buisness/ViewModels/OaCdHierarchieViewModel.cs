using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdHierarchieViewModel : ViewModelBase<OaCdHierarchie>
    {
        public OaCdHierarchieViewModel(OaCdHierarchie model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
        }
        public override void Read()
        {
            this.Hierarchie=this.Model.Hierarchie;
        }
        public override void Write()
        {
            this.Model.Hierarchie=this.Hierarchie;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        private String _hierarchie;
        [DisplayName("Caractère stratégique")]
        public String Hierarchie
        {
            get
            {
                return this._hierarchie;
            }
            set
            {
                this._hierarchie = value;
                RaisePropertyChange("Hierarchie");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Hierarchie"] != null)
                {
                    errors.Add("Caractère stratégique : "+this["Hierarchie"]);
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
                if (columnName.Equals("Hierarchie"))
                {
                    if (String.IsNullOrEmpty(this.Hierarchie))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
