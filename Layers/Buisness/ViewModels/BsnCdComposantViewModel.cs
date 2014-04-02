using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdComposantViewModel : ViewModelBase<BsnCdComposant>
    {
        public BsnCdComposantViewModel(BsnCdComposant model) : base(model)
        {
            this.BsnCdEntetes = new  ObservableCollection<BsnCdEnteteViewModel>();
            
        }
        public override void Read()
        {
            this.TypeComp=this.Model.TypeComp;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.TypeComp=this.TypeComp;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<BsnCdEnteteViewModel> BsnCdEntetes { get; set; }
        
        private String _typeComp;
        [DisplayName("Type Composant")]
        public String TypeComp
        {
            get
            {
                return this._typeComp;
            }
            set
            {
                this._typeComp = value;
                RaisePropertyChange("TypeComp");
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
                if (this["TypeComp"] != null)
                {
                    errors.Add("Type Composant : "+this["TypeComp"]);
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
                if (columnName.Equals("TypeComp"))
                {
                    if (String.IsNullOrEmpty(this.TypeComp))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                }
                return null;
            }
        }
    }
}
