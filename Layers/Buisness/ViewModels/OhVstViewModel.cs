using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhVstViewModel : ViewModelBase<OhVst>
    {
        public OhVstViewModel(OhVst model) : base(model)
        {
            this.OhSprtVsts = new  ObservableCollection<OhSprtVstViewModel>();
            
            this.OhPhotoVsts = new  ObservableCollection<OhPhotoVstViewModel>();
            
            this.OhEntetes = new  ObservableCollection<OhEnteteViewModel>();
            
        }
        public override void Read()
        {
            this.OhCamp=new OhCampViewModel( this.Model.OhCamp);
            this.OhDsc=new OhDscViewModel( this.Model.OhDsc);
            this.OhInspecteur=new OhInspecteurViewModel( this.Model.OhInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Prioritaire=this.Model.Prioritaire;
            this.Observ=this.Model.Observ;
            this.NoteVst=this.Model.NoteVst;
        }
        public override void Write()
        {
            this.Model.OhCamp=this. OhCamp.Model;
            this.Model.OhDsc=this. OhDsc.Model;
            this.Model.OhInspecteur=this. OhInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Observ=this.Observ;
            this.Model.NoteVst=this.NoteVst;
        }
        private OhCampViewModel _ohCamp;
        [DisplayName("Campagne")]
        public virtual OhCampViewModel OhCamp
        {
            get
            {
                return this._ohCamp;
            }
            set
            {
                this._ohCamp = value;
                RaisePropertyChange("OhCamp");
            }
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
        
        private OhInspecteurViewModel _ohInspecteur;
        [DisplayName("Inspecteur")]
        public virtual OhInspecteurViewModel OhInspecteur
        {
            get
            {
                return this._ohInspecteur;
            }
            set
            {
                this._ohInspecteur = value;
                RaisePropertyChange("OhInspecteur");
            }
        }
        
        public virtual ObservableCollection<OhSprtVstViewModel> OhSprtVsts { get; set; }
        
        public virtual ObservableCollection<OhPhotoVstViewModel> OhPhotoVsts { get; set; }
        
        public virtual ObservableCollection<OhEnteteViewModel> OhEntetes { get; set; }
        
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Etat"] != null)
                {
                    errors.Add("Statut visite : "+this["Etat"]);
                }
                if (this["Datev"] != null)
                {
                    errors.Add("Date de visite : "+this["Datev"]);
                }
                if (this["Prioritaire"] != null)
                {
                    errors.Add("Urgence traitement : "+this["Prioritaire"]);
                }
                if (this["Observ"] != null)
                {
                    errors.Add("Observation : "+this["Observ"]);
                }
                if (this["NoteVst"] != null)
                {
                    errors.Add("Note Visite : "+this["NoteVst"]);
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
                if (columnName.Equals("Etat"))
                {
                    if (String.IsNullOrEmpty(this.Etat))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Datev"))
                {
                }
                if (columnName.Equals("Prioritaire"))
                {
                }
                if (columnName.Equals("Observ"))
                {
                }
                if (columnName.Equals("NoteVst"))
                {
                }
                return null;
            }
        }
    }
}
