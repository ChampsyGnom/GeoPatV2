using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdMesureViewModel : ViewModelBase<ChsCdMesure>
    {
        public ChsCdMesureViewModel(ChsCdMesure model) : base(model)
        {
            this.ChsCdIndics = new  ObservableCollection<ChsCdIndicViewModel>();
            
            this.ChsCamps = new  ObservableCollection<ChsCampViewModel>();
            
        }
        public override void Read()
        {
            this.Agr=this.Model.Agr;
            this.Libelle=this.Model.Libelle;
            this.Cycle=this.Model.Cycle;
            this.Prix=this.Model.Prix;
        }
        public override void Write()
        {
            this.Model.Agr=this.Agr;
            this.Model.Libelle=this.Libelle;
            this.Model.Cycle=this.Cycle;
            this.Model.Prix=this.Prix;
        }
        public virtual ObservableCollection<ChsCdIndicViewModel> ChsCdIndics { get; set; }
        
        public virtual ObservableCollection<ChsCampViewModel> ChsCamps { get; set; }
        
        private String _agr;
        [DisplayName("Code Agr")]
        public String Agr
        {
            get
            {
                return this._agr;
            }
            set
            {
                this._agr = value;
                RaisePropertyChange("Agr");
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
        private Int64 _cycle;
        [DisplayName("Cycle de surveillance")]
        public Int64 Cycle
        {
            get
            {
                return this._cycle;
            }
            set
            {
                this._cycle = value;
                RaisePropertyChange("Cycle");
            }
        }
        
        private Nullable<Int64> _prix;
        [DisplayName("Prix Unitaire (km)")]
        public Nullable<Int64> Prix
        {
            get
            {
                return this._prix;
            }
            set
            {
                this._prix = value;
                RaisePropertyChange("Prix");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Agr"] != null)
                {
                    errors.Add("Code Agr : "+this["Agr"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Cycle"] != null)
                {
                    errors.Add("Cycle de surveillance : "+this["Cycle"]);
                }
                if (this["Prix"] != null)
                {
                    errors.Add("Prix Unitaire (km) : "+this["Prix"]);
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
                if (columnName.Equals("Agr"))
                {
                    if (String.IsNullOrEmpty(this.Agr))
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
                if (columnName.Equals("Cycle"))
                {
                }
                if (columnName.Equals("Prix"))
                {
                }
                return null;
            }
        }
    }
}
