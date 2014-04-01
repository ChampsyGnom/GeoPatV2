using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCampViewModel : ViewModelBase
    {
        public GotCamp Model {get; set;}
        public GotCampViewModel(GotCamp model)
        {
            this.GotInsps = new  ObservableCollection<GotInspViewModel>();
            
            this.GotVsts = new  ObservableCollection<GotVstViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
            this.GotDscCamps = new  ObservableCollection<GotDscCampViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotCdPresta=new GotCdPrestaViewModel( this.Model.GotCdPresta);
            this.GotCdTypePv=new GotCdTypePvViewModel( this.Model.GotCdTypePv);
            this.IdCamp=this.Model.IdCamp;
            this.Annee=this.Model.Annee;
            this.Dater=this.Model.Dater;
            this.Dateg=this.Model.Dateg;
            this.Userg=this.Model.Userg;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.GotCdPresta=this. GotCdPresta.Model;
            this.Model.GotCdTypePv=this. GotCdTypePv.Model;
            this.Model.IdCamp=this.IdCamp;
            this.Model.Annee=this.Annee;
            this.Model.Dater=this.Dater;
            this.Model.Dateg=this.Dateg;
            this.Model.Userg=this.Userg;
            this.Model.Observ=this.Observ;
        }
        private GotCdPrestaViewModel _gotCdPresta;
        [DisplayName("Prestataire")]
        public virtual GotCdPrestaViewModel GotCdPresta
        {
            get
            {
                return this._gotCdPresta;
            }
            set
            {
                this._gotCdPresta = value;
                RaisePropertyChange("GotCdPresta");
            }
        }
        
        private GotCdTypePvViewModel _gotCdTypePv;
        [DisplayName("Type de PV")]
        public virtual GotCdTypePvViewModel GotCdTypePv
        {
            get
            {
                return this._gotCdTypePv;
            }
            set
            {
                this._gotCdTypePv = value;
                RaisePropertyChange("GotCdTypePv");
            }
        }
        
        public virtual ObservableCollection<GotInspViewModel> GotInsps { get; set; }
        
        public virtual ObservableCollection<GotVstViewModel> GotVsts { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        public virtual ObservableCollection<GotDscCampViewModel> GotDscCamps { get; set; }
        
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
        [DisplayName("Date Génération")]
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
        [DisplayName("Observation")]
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
