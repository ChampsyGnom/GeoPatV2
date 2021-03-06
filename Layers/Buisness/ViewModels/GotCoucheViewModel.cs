using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCoucheViewModel : ViewModelBase<GotCouche>
    {
        public GotCoucheViewModel(GotCouche model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotCdCouche=new GotCdCoucheViewModel( this.Model.GotCdCouche);
            this.GotDsc=new GotDscViewModel( this.Model.GotDsc);
            this.GotCdTraitement=new GotCdTraitementViewModel( this.Model.GotCdTraitement);
            this.GotCdHydrique=new GotCdHydriqueViewModel( this.Model.GotCdHydrique);
            this.GotCdMateriau=new GotCdMateriauViewModel( this.Model.GotCdMateriau);
            this.GotCdCompactage=new GotCdCompactageViewModel( this.Model.GotCdCompactage);
            this.Epai=this.Model.Epai;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.GotCdCouche=this. GotCdCouche.Model;
            this.Model.GotDsc=this. GotDsc.Model;
            this.Model.GotCdTraitement=this. GotCdTraitement.Model;
            this.Model.GotCdHydrique=this. GotCdHydrique.Model;
            this.Model.GotCdMateriau=this. GotCdMateriau.Model;
            this.Model.GotCdCompactage=this. GotCdCompactage.Model;
            this.Model.Epai=this.Epai;
            this.Model.Obs=this.Obs;
        }
        private GotCdCoucheViewModel _gotCdCouche;
        [DisplayName("Code Couche")]
        public virtual GotCdCoucheViewModel GotCdCouche
        {
            get
            {
                return this._gotCdCouche;
            }
            set
            {
                this._gotCdCouche = value;
                RaisePropertyChange("GotCdCouche");
            }
        }
        
        private GotDscViewModel _gotDsc;
        [DisplayName("Terrassement")]
        public virtual GotDscViewModel GotDsc
        {
            get
            {
                return this._gotDsc;
            }
            set
            {
                this._gotDsc = value;
                RaisePropertyChange("GotDsc");
            }
        }
        
        private GotCdTraitementViewModel _gotCdTraitement;
        [DisplayName("Traitement")]
        public virtual GotCdTraitementViewModel GotCdTraitement
        {
            get
            {
                return this._gotCdTraitement;
            }
            set
            {
                this._gotCdTraitement = value;
                RaisePropertyChange("GotCdTraitement");
            }
        }
        
        private GotCdHydriqueViewModel _gotCdHydrique;
        [DisplayName("Hydrique")]
        public virtual GotCdHydriqueViewModel GotCdHydrique
        {
            get
            {
                return this._gotCdHydrique;
            }
            set
            {
                this._gotCdHydrique = value;
                RaisePropertyChange("GotCdHydrique");
            }
        }
        
        private GotCdMateriauViewModel _gotCdMateriau;
        [DisplayName("Matériaux")]
        public virtual GotCdMateriauViewModel GotCdMateriau
        {
            get
            {
                return this._gotCdMateriau;
            }
            set
            {
                this._gotCdMateriau = value;
                RaisePropertyChange("GotCdMateriau");
            }
        }
        
        private GotCdCompactageViewModel _gotCdCompactage;
        [DisplayName("Compactage")]
        public virtual GotCdCompactageViewModel GotCdCompactage
        {
            get
            {
                return this._gotCdCompactage;
            }
            set
            {
                this._gotCdCompactage = value;
                RaisePropertyChange("GotCdCompactage");
            }
        }
        
        private Nullable<Double> _epai;
        [DisplayName("Epaisseur (m)")]
        public Nullable<Double> Epai
        {
            get
            {
                return this._epai;
            }
            set
            {
                this._epai = value;
                RaisePropertyChange("Epai");
            }
        }
        
        private String _obs;
        [DisplayName("Observation")]
        public String Obs
        {
            get
            {
                return this._obs;
            }
            set
            {
                this._obs = value;
                RaisePropertyChange("Obs");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Epai"] != null)
                {
                    errors.Add("Epaisseur (m) : "+this["Epai"]);
                }
                if (this["Obs"] != null)
                {
                    errors.Add("Observation : "+this["Obs"]);
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
                if (columnName.Equals("Epai"))
                {
                }
                if (columnName.Equals("Obs"))
                {
                }
                return null;
            }
        }
    }
}
