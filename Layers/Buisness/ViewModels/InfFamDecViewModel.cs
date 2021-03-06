using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfFamDecViewModel : ViewModelBase<InfFamDec>
    {
        public InfFamDecViewModel(InfFamDec model) : base(model)
        {
            this.InfCdDecs = new  ObservableCollection<InfCdDecViewModel>();
            
        }
        public override void Read()
        {
            this.FamDec=this.Model.FamDec;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.FamDec=this.FamDec;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<InfCdDecViewModel> InfCdDecs { get; set; }
        
        private String _famDec;
        [DisplayName("Code famille")]
        public String FamDec
        {
            get
            {
                return this._famDec;
            }
            set
            {
                this._famDec = value;
                RaisePropertyChange("FamDec");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["FamDec"] != null)
                {
                    errors.Add("Code famille : "+this["FamDec"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("FamDec"))
                {
                    if (String.IsNullOrEmpty(this.FamDec))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
