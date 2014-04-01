using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCampViewModel : ViewModelBase
    {
        public OaCamp Model {get; set;}
        public OaCampViewModel(OaCamp model)
        {
            this.OaVsts = new  ObservableCollection<OaVstViewModel>();
            
            this.OaInsps = new  ObservableCollection<OaInspViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
            this.OaDscCamps = new  ObservableCollection<OaDscCampViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaCdPresta=new OaCdPrestaViewModel( this.Model.OaCdPresta);
            this.OaCdTypePv=new OaCdTypePvViewModel( this.Model.OaCdTypePv);
            this.IdCamp=this.Model.IdCamp;
            this.Annee=this.Model.Annee;
            this.Dater=this.Model.Dater;
            this.Dateg=this.Model.Dateg;
            this.Userg=this.Model.Userg;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.OaCdPresta=this. OaCdPresta.Model;
            this.Model.OaCdTypePv=this. OaCdTypePv.Model;
            this.Model.IdCamp=this.IdCamp;
            this.Model.Annee=this.Annee;
            this.Model.Dater=this.Dater;
            this.Model.Dateg=this.Dateg;
            this.Model.Userg=this.Userg;
            this.Model.Observ=this.Observ;
        }
        private OaCdPrestaViewModel _oaCdPresta;
        [DisplayName("Prestataire")]
        public virtual OaCdPrestaViewModel OaCdPresta
        {
            get
            {
                return this._oaCdPresta;
            }
            set
            {
                this._oaCdPresta = value;
                RaisePropertyChange("OaCdPresta");
            }
        }
        
        private OaCdTypePvViewModel _oaCdTypePv;
        [DisplayName("Type PV")]
        public virtual OaCdTypePvViewModel OaCdTypePv
        {
            get
            {
                return this._oaCdTypePv;
            }
            set
            {
                this._oaCdTypePv = value;
                RaisePropertyChange("OaCdTypePv");
            }
        }
        
        public virtual ObservableCollection<OaVstViewModel> OaVsts { get; set; }
        
        public virtual ObservableCollection<OaInspViewModel> OaInsps { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        public virtual ObservableCollection<OaDscCampViewModel> OaDscCamps { get; set; }
        
        private String _idCamp;
        [DisplayName("Identifiant campagne")]
        public String IdCamp
        {
            get
            {
                return this._idCamp;
            }
            set
            {
                this._idCamp = value;
                RaisePropertyChange("IdCamp");
            }
        }
        private Int64 _annee;
        [DisplayName("Année")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
            }
        }
        
        private DateTime _dater;
        [DisplayName("Date maxi retour")]
        public DateTime Dater
        {
            get
            {
                return this._dater;
            }
            set
            {
                this._dater = value;
                RaisePropertyChange("Dater");
            }
        }
        
        private Nullable<DateTime> _dateg;
        [DisplayName("Date génération")]
        public Nullable<DateTime> Dateg
        {
            get
            {
                return this._dateg;
            }
            set
            {
                this._dateg = value;
                RaisePropertyChange("Dateg");
            }
        }
        
        private String _userg;
        [DisplayName("Nom créateur")]
        public String Userg
        {
            get
            {
                return this._userg;
            }
            set
            {
                this._userg = value;
                RaisePropertyChange("Userg");
            }
        }
        private String _observ;
        [DisplayName("Commentaire")]
        public String Observ
        {
            get
            {
                return this._observ;
            }
            set
            {
                this._observ = value;
                RaisePropertyChange("Observ");
            }
        }
    }
}
