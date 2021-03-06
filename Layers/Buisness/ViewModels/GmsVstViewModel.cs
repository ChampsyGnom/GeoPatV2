using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsVstViewModel : ViewModelBase<GmsVst>
    {
        public GmsVstViewModel(GmsVst model) : base(model)
        {
            this.GmsSprtVsts = new  ObservableCollection<GmsSprtVstViewModel>();
            
            this.GmsPhotoVsts = new  ObservableCollection<GmsPhotoVstViewModel>();
            
            this.GmsEntetes = new  ObservableCollection<GmsEnteteViewModel>();
            
        }
        public override void Read()
        {
            this.GmsCamp=new GmsCampViewModel( this.Model.GmsCamp);
            this.GmsDsc=new GmsDscViewModel( this.Model.GmsDsc);
            this.GmsInspecteur=new GmsInspecteurViewModel( this.Model.GmsInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Prioritaire=this.Model.Prioritaire;
            this.Observ=this.Model.Observ;
            this.NoteVst=this.Model.NoteVst;
        }
        public override void Write()
        {
            this.Model.GmsCamp=this. GmsCamp.Model;
            this.Model.GmsDsc=this. GmsDsc.Model;
            this.Model.GmsInspecteur=this. GmsInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Observ=this.Observ;
            this.Model.NoteVst=this.NoteVst;
        }
        private GmsCampViewModel _gmsCamp;
        [DisplayName("Campagne")]
        public virtual GmsCampViewModel GmsCamp
        {
            get
            {
                return this._gmsCamp;
            }
            set
            {
                this._gmsCamp = value;
                RaisePropertyChange("GmsCamp");
            }
        }
        
        private GmsDscViewModel _gmsDsc;
        [DisplayName("Grand Matériel de Signalisation")]
        public virtual GmsDscViewModel GmsDsc
        {
            get
            {
                return this._gmsDsc;
            }
            set
            {
                this._gmsDsc = value;
                RaisePropertyChange("GmsDsc");
            }
        }
        
        private GmsInspecteurViewModel _gmsInspecteur;
        [DisplayName("Inspecteur")]
        public virtual GmsInspecteurViewModel GmsInspecteur
        {
            get
            {
                return this._gmsInspecteur;
            }
            set
            {
                this._gmsInspecteur = value;
                RaisePropertyChange("GmsInspecteur");
            }
        }
        
        public virtual ObservableCollection<GmsSprtVstViewModel> GmsSprtVsts { get; set; }
        
        public virtual ObservableCollection<GmsPhotoVstViewModel> GmsPhotoVsts { get; set; }
        
        public virtual ObservableCollection<GmsEnteteViewModel> GmsEntetes { get; set; }
        
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
