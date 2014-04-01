using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPrevisionViewModel : ViewModelBase
    {
        public BsnPrevision Model {get; set;}
        public BsnPrevisionViewModel(BsnPrevision model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.BsnBpu=new BsnBpuViewModel( this.Model.BsnBpu);
            this.BsnCdContrainte=new BsnCdContrainteViewModel( this.Model.BsnCdContrainte);
            this.DateDebut=this.Model.DateDebut;
            this.DateFin=this.Model.DateFin;
            this.Montant=this.Model.Montant;
            this.DateDemPub=this.Model.DateDemPub;
            this.Commentaire=this.Model.Commentaire;
            this.Realise=this.Model.Realise;
        }
        public override void Write()
        {
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.BsnBpu=this. BsnBpu.Model;
            this.Model.BsnCdContrainte=this. BsnCdContrainte.Model;
            this.Model.DateDebut=this.DateDebut;
            this.Model.DateFin=this.DateFin;
            this.Model.Montant=this.Montant;
            this.Model.DateDemPub=this.DateDemPub;
            this.Model.Commentaire=this.Commentaire;
            this.Model.Realise=this.Realise;
        }
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
            }
        }
        
        private BsnBpuViewModel _bsnBpu;
        [DisplayName("Bordereau Prix")]
        public virtual BsnBpuViewModel BsnBpu
        {
            get
            {
                return this._bsnBpu;
            }
            set
            {
                this._bsnBpu = value;
                RaisePropertyChange("BsnBpu");
            }
        }
        
        private BsnCdContrainteViewModel _bsnCdContrainte;
        [DisplayName("Contrainte exploitation")]
        public virtual BsnCdContrainteViewModel BsnCdContrainte
        {
            get
            {
                return this._bsnCdContrainte;
            }
            set
            {
                this._bsnCdContrainte = value;
                RaisePropertyChange("BsnCdContrainte");
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
        [DisplayName("Coûts")]
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
        
    }
}
