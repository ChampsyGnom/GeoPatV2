using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotVstViewModel : ViewModelBase
    {
        public GotVst Model {get; set;}
        public GotVstViewModel(GotVst model)
        {
            this.GotPhotoVsts = new  ObservableCollection<GotPhotoVstViewModel>();
            
            this.GotSprtVsts = new  ObservableCollection<GotSprtVstViewModel>();
            
            this.GotEntetes = new  ObservableCollection<GotEnteteViewModel>();
            
            this.GotCdPrecoSprtVsts = new  ObservableCollection<GotCdPrecoSprtVstViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotDsc=new GotDscViewModel( this.Model.GotDsc);
            this.GotCamp=new GotCampViewModel( this.Model.GotCamp);
            this.GotInspecteur=new GotInspecteurViewModel( this.Model.GotInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Prioritaire=this.Model.Prioritaire;
            this.Observ=this.Model.Observ;
            this.NoteVst=this.Model.NoteVst;
        }
        public override void Write()
        {
            this.Model.GotDsc=this. GotDsc.Model;
            this.Model.GotCamp=this. GotCamp.Model;
            this.Model.GotInspecteur=this. GotInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Observ=this.Observ;
            this.Model.NoteVst=this.NoteVst;
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
        
        private GotCampViewModel _gotCamp;
        [DisplayName("Campagne")]
        public virtual GotCampViewModel GotCamp
        {
            get
            {
                return this._gotCamp;
            }
            set
            {
                this._gotCamp = value;
                RaisePropertyChange("GotCamp");
            }
        }
        
        private GotInspecteurViewModel _gotInspecteur;
        [DisplayName("Inspecteur")]
        public virtual GotInspecteurViewModel GotInspecteur
        {
            get
            {
                return this._gotInspecteur;
            }
            set
            {
                this._gotInspecteur = value;
                RaisePropertyChange("GotInspecteur");
            }
        }
        
        public virtual ObservableCollection<GotPhotoVstViewModel> GotPhotoVsts { get; set; }
        
        public virtual ObservableCollection<GotSprtVstViewModel> GotSprtVsts { get; set; }
        
        public virtual ObservableCollection<GotEnteteViewModel> GotEntetes { get; set; }
        
        public virtual ObservableCollection<GotCdPrecoSprtVstViewModel> GotCdPrecoSprtVsts { get; set; }
        
        private String _etat;
        [DisplayName("Statut visite")]
        public String Etat
        {
            get
            {
                return this._etat;
            }
            set
            {
                this._etat = value;
                RaisePropertyChange("Etat");
            }
        }
        private Nullable<DateTime> _datev;
        [DisplayName("Date de visite")]
        public Nullable<DateTime> Datev
        {
            get
            {
                return this._datev;
            }
            set
            {
                this._datev = value;
                RaisePropertyChange("Datev");
            }
        }
        
        private Nullable<Boolean> _prioritaire;
        [DisplayName("Urgence traitement")]
        public Nullable<Boolean> Prioritaire
        {
            get
            {
                return this._prioritaire;
            }
            set
            {
                this._prioritaire = value;
                RaisePropertyChange("Prioritaire");
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
        private String _noteVst;
        [DisplayName("Note Visite")]
        public String NoteVst
        {
            get
            {
                return this._noteVst;
            }
            set
            {
                this._noteVst = value;
                RaisePropertyChange("NoteVst");
            }
        }
    }
}
