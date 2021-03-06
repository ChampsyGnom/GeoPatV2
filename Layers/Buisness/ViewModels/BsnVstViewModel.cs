using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnVstViewModel : ViewModelBase<BsnVst>
    {
        public BsnVstViewModel(BsnVst model) : base(model)
        {
            this.BsnSprtVsts = new  ObservableCollection<BsnSprtVstViewModel>();
            
            this.BsnPhotoVsts = new  ObservableCollection<BsnPhotoVstViewModel>();
            
            this.BsnEntetes = new  ObservableCollection<BsnEnteteViewModel>();
            
        }
        public override void Read()
        {
            this.BsnCamp=new BsnCampViewModel( this.Model.BsnCamp);
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.BsnInspecteur=new BsnInspecteurViewModel( this.Model.BsnInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Prioritaire=this.Model.Prioritaire;
            this.Observ=this.Model.Observ;
            this.NoteVst=this.Model.NoteVst;
        }
        public override void Write()
        {
            this.Model.BsnCamp=this. BsnCamp.Model;
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.BsnInspecteur=this. BsnInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Observ=this.Observ;
            this.Model.NoteVst=this.NoteVst;
        }
        private BsnCampViewModel _bsnCamp;
        [DisplayName("Campagne")]
        public virtual BsnCampViewModel BsnCamp
        {
            get
            {
                return this._bsnCamp;
            }
            set
            {
                this._bsnCamp = value;
                RaisePropertyChange("BsnCamp");
            }
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
        
        private BsnInspecteurViewModel _bsnInspecteur;
        [DisplayName("Inspecteur")]
        public virtual BsnInspecteurViewModel BsnInspecteur
        {
            get
            {
                return this._bsnInspecteur;
            }
            set
            {
                this._bsnInspecteur = value;
                RaisePropertyChange("BsnInspecteur");
            }
        }
        
        public virtual ObservableCollection<BsnSprtVstViewModel> BsnSprtVsts { get; set; }
        
        public virtual ObservableCollection<BsnPhotoVstViewModel> BsnPhotoVsts { get; set; }
        
        public virtual ObservableCollection<BsnEnteteViewModel> BsnEntetes { get; set; }
        
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
