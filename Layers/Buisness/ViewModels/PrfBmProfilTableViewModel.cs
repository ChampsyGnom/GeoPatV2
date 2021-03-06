using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmProfilTableViewModel : ViewModelBase<PrfBmProfilTable>
    {
        public PrfBmProfilTableViewModel(PrfBmProfilTable model) : base(model)
        {
        }
        public override void Read()
        {
            this.PrfBmProfil=new PrfBmProfilViewModel( this.Model.PrfBmProfil);
            this.PrfBmTable=new PrfBmTableViewModel( this.Model.PrfBmTable);
            this.Ecrire=this.Model.Ecrire;
            this.Importer=this.Model.Importer;
            this.Afficher=this.Model.Afficher;
        }
        public override void Write()
        {
            this.Model.PrfBmProfil=this. PrfBmProfil.Model;
            this.Model.PrfBmTable=this. PrfBmTable.Model;
            this.Model.Ecrire=this.Ecrire;
            this.Model.Importer=this.Importer;
            this.Model.Afficher=this.Afficher;
        }
        private PrfBmProfilViewModel _prfBmProfil;
        [DisplayName("Profil BM")]
        public virtual PrfBmProfilViewModel PrfBmProfil
        {
            get
            {
                return this._prfBmProfil;
            }
            set
            {
                this._prfBmProfil = value;
                RaisePropertyChange("PrfBmProfil");
            }
        }
        
        private PrfBmTableViewModel _prfBmTable;
        [DisplayName("Table BM")]
        public virtual PrfBmTableViewModel PrfBmTable
        {
            get
            {
                return this._prfBmTable;
            }
            set
            {
                this._prfBmTable = value;
                RaisePropertyChange("PrfBmTable");
            }
        }
        
        private Boolean _ecrire;
        [DisplayName("Ecrire")]
        public Boolean Ecrire
        {
            get
            {
                return this._ecrire;
            }
            set
            {
                this._ecrire = value;
                RaisePropertyChange("Ecrire");
            }
        }
        
        private Boolean _importer;
        [DisplayName("Importer")]
        public Boolean Importer
        {
            get
            {
                return this._importer;
            }
            set
            {
                this._importer = value;
                RaisePropertyChange("Importer");
            }
        }
        
        private Nullable<Boolean> _afficher;
        [DisplayName("Afficher")]
        public Nullable<Boolean> Afficher
        {
            get
            {
                return this._afficher;
            }
            set
            {
                this._afficher = value;
                RaisePropertyChange("Afficher");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Ecrire"] != null)
                {
                    errors.Add("Ecrire : "+this["Ecrire"]);
                }
                if (this["Importer"] != null)
                {
                    errors.Add("Importer : "+this["Importer"]);
                }
                if (this["Afficher"] != null)
                {
                    errors.Add("Afficher : "+this["Afficher"]);
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
                if (columnName.Equals("Ecrire"))
                {
                }
                if (columnName.Equals("Importer"))
                {
                }
                if (columnName.Equals("Afficher"))
                {
                }
                return null;
            }
        }
    }
}
