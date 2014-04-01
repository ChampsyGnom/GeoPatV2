using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaVstViewModel : ViewModelBase
    {
        public OaVst Model {get; set;}
        public OaVstViewModel(OaVst model)
        {
            this.OaPhotoVsts = new  ObservableCollection<OaPhotoVstViewModel>();
            
            this.OaSprtVsts = new  ObservableCollection<OaSprtVstViewModel>();
            
            this.OaEntetes = new  ObservableCollection<OaEnteteViewModel>();
            
            this.OaCdPrecoSprtVsts = new  ObservableCollection<OaCdPrecoSprtVstViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaCamp=new OaCampViewModel( this.Model.OaCamp);
            this.OaInspecteur=new OaInspecteurViewModel( this.Model.OaInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Prioritaire=this.Model.Prioritaire;
            this.Observ=this.Model.Observ;
            this.NoteVst=this.Model.NoteVst;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaCamp=this. OaCamp.Model;
            this.Model.OaInspecteur=this. OaInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Observ=this.Observ;
            this.Model.NoteVst=this.NoteVst;
        }
        private OaDscViewModel _oaDsc;
        [DisplayName("Ouvrages d'Art")]
        public virtual OaDscViewModel OaDsc
        {
            get
            {
                return this._oaDsc;
            }
            set
            {
                this._oaDsc = value;
                RaisePropertyChange("OaDsc");
            }
        }
        
        private OaCampViewModel _oaCamp;
        [DisplayName("Campagne")]
        public virtual OaCampViewModel OaCamp
        {
            get
            {
                return this._oaCamp;
            }
            set
            {
                this._oaCamp = value;
                RaisePropertyChange("OaCamp");
            }
        }
        
        private OaInspecteurViewModel _oaInspecteur;
        [DisplayName("Inspecteur")]
        public virtual OaInspecteurViewModel OaInspecteur
        {
            get
            {
                return this._oaInspecteur;
            }
            set
            {
                this._oaInspecteur = value;
                RaisePropertyChange("OaInspecteur");
            }
        }
        
        public virtual ObservableCollection<OaPhotoVstViewModel> OaPhotoVsts { get; set; }
        
        public virtual ObservableCollection<OaSprtVstViewModel> OaSprtVsts { get; set; }
        
        public virtual ObservableCollection<OaEnteteViewModel> OaEntetes { get; set; }
        
        public virtual ObservableCollection<OaCdPrecoSprtVstViewModel> OaCdPrecoSprtVsts { get; set; }
        
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
