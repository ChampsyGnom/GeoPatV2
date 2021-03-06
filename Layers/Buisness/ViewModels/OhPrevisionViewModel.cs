using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPrevisionViewModel : ViewModelBase<OhPrevision>
    {
        public OhPrevisionViewModel(OhPrevision model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhDsc=new OhDscViewModel( this.Model.OhDsc);
            this.OhBpu=new OhBpuViewModel( this.Model.OhBpu);
            this.OhCdContrainte=new OhCdContrainteViewModel( this.Model.OhCdContrainte);
            this.DateDebut=this.Model.DateDebut;
            this.DateFin=this.Model.DateFin;
            this.Montant=this.Model.Montant;
            this.DateDemPub=this.Model.DateDemPub;
            this.Commentaire=this.Model.Commentaire;
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.OhDsc=this. OhDsc.Model;
            this.Model.OhBpu=this. OhBpu.Model;
            this.Model.OhCdContrainte=this. OhCdContrainte.Model;
            this.Model.DateDebut=this.DateDebut;
            this.Model.DateFin=this.DateFin;
            this.Model.Montant=this.Montant;
            this.Model.DateDemPub=this.DateDemPub;
            this.Model.Commentaire=this.Commentaire;
            this.Model.Realise=this.Realise;
        }
        private OhDscViewModel _ohDsc;
        [DisplayName("Ouvrage Hydraulique")]
        public virtual OhDscViewModel OhDsc
        {
            get
            {
                return this._ohDsc;
            }
            set
            {
                this._ohDsc = value;
                RaisePropertyChange("OhDsc");
            }
        }
        
        private OhBpuViewModel _ohBpu;
        [DisplayName("Bordereau Prix")]
        public virtual OhBpuViewModel OhBpu
        {
            get
            {
                return this._ohBpu;
            }
            set
            {
                this._ohBpu = value;
                RaisePropertyChange("OhBpu");
            }
        }
        
        private OhCdContrainteViewModel _ohCdContrainte;
        [DisplayName("Contrainte exploitation")]
        public virtual OhCdContrainteViewModel OhCdContrainte
        {
            get
            {
                return this._ohCdContrainte;
            }
            set
            {
                this._ohCdContrainte = value;
                RaisePropertyChange("OhCdContrainte");
            }
        }
        
        private DateTime _dateDebut;
        [DisplayName("Date début")]
        public DateTime DateDebut
        {
            get
            {
                return this._dateDebut;
            }
            set
            {
                this._dateDebut = value;
                RaisePropertyChange("DateDebut");
            }
        }
        
        private Nullable<DateTime> _dateFin;
        [DisplayName("Date fin")]
        public Nullable<DateTime> DateFin
        {
            get
            {
                return this._dateFin;
            }
            set
            {
                this._dateFin = value;
                RaisePropertyChange("DateFin");
            }
        }
        
        private Nullable<Int64> _montant;
        [DisplayName("Coûts (€)")]
        public Nullable<Int64> Montant
        {
            get
            {
                return this._montant;
            }
            set
            {
                this._montant = value;
                RaisePropertyChange("Montant");
            }
        }
        
        private Nullable<DateTime> _dateDemPub;
        [DisplayName("Date demande publication")]
        public Nullable<DateTime> DateDemPub
        {
            get
            {
                return this._dateDemPub;
            }
            set
            {
                this._dateDemPub = value;
                RaisePropertyChange("DateDemPub");
            }
        }
        
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
        private Nullable<Boolean> _realise;
        [DisplayName("Réalisé")]
        public Nullable<Boolean> Realise
        {
            get
            {
                return this._realise;
            }
            set
            {
                this._realise = value;
                RaisePropertyChange("Realise");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateDebut"] != null)
                {
                    errors.Add("Date début : "+this["DateDebut"]);
                }
                if (this["DateFin"] != null)
                {
                    errors.Add("Date fin : "+this["DateFin"]);
                }
                if (this["Montant"] != null)
                {
                    errors.Add("Coûts (€) : "+this["Montant"]);
                }
                if (this["DateDemPub"] != null)
                {
                    errors.Add("Date demande publication : "+this["DateDemPub"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
                }
                if (this["Realise"] != null)
                {
                    errors.Add("Réalisé : "+this["Realise"]);
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
                if (columnName.Equals("DateDebut"))
                {
                }
                if (columnName.Equals("DateFin"))
                {
                }
                if (columnName.Equals("Montant"))
                {
                }
                if (columnName.Equals("DateDemPub"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                if (columnName.Equals("Realise"))
                {
                }
                return null;
            }
        }
    }
}
