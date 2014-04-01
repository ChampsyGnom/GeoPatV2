using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEquipementViewModel : ViewModelBase
    {
        public OaEquipement Model {get; set;}
        public OaEquipementViewModel(OaEquipement model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaCdDpr=new OaCdDprViewModel( this.Model.OaCdDpr);
            this.OaTablier=new OaTablierViewModel( this.Model.OaTablier);
            this.OaCdGc=new OaCdGcViewModel( this.Model.OaCdGc);
            this.Cote=this.Model.Cote;
            this.DateDpr=this.Model.DateDpr;
            this.DateGc=this.Model.DateGc;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaCdDpr=this. OaCdDpr.Model;
            this.Model.OaTablier=this. OaTablier.Model;
            this.Model.OaCdGc=this. OaCdGc.Model;
            this.Model.Cote=this.Cote;
            this.Model.DateDpr=this.DateDpr;
            this.Model.DateGc=this.DateGc;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaCdDprViewModel _oaCdDpr;
        [DisplayName("Types de dispositif de retenue")]
        public virtual OaCdDprViewModel OaCdDpr
        {
            get
            {
                return this._oaCdDpr;
            }
            set
            {
                this._oaCdDpr = value;
                RaisePropertyChange("OaCdDpr");
            }
        }
        
        private OaTablierViewModel _oaTablier;
        [DisplayName("Tabliers")]
        public virtual OaTablierViewModel OaTablier
        {
            get
            {
                return this._oaTablier;
            }
            set
            {
                this._oaTablier = value;
                RaisePropertyChange("OaTablier");
            }
        }
        
        private OaCdGcViewModel _oaCdGc;
        [DisplayName("Types de garde-corps")]
        public virtual OaCdGcViewModel OaCdGc
        {
            get
            {
                return this._oaCdGc;
            }
            set
            {
                this._oaCdGc = value;
                RaisePropertyChange("OaCdGc");
            }
        }
        
        private String _cote;
        [DisplayName("Coté")]
        public String Cote
        {
            get
            {
                return this._cote;
            }
            set
            {
                this._cote = value;
                RaisePropertyChange("Cote");
            }
        }
        private Nullable<DateTime> _dateDpr;
        [DisplayName("Date MS DPR")]
        public Nullable<DateTime> DateDpr
        {
            get
            {
                return this._dateDpr;
            }
            set
            {
                this._dateDpr = value;
                RaisePropertyChange("DateDpr");
            }
        }
        
        private Nullable<DateTime> _dateGc;
        [DisplayName("Date MS GC")]
        public Nullable<DateTime> DateGc
        {
            get
            {
                return this._dateGc;
            }
            set
            {
                this._dateGc = value;
                RaisePropertyChange("DateGc");
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
    }
}
