using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCampViewModel : ViewModelBase<GmsCamp>
    {
        public GmsCampViewModel(GmsCamp model) : base(model)
        {
            this.GmsInsps = new  ObservableCollection<GmsInspViewModel>();
            
            this.GmsVsts = new  ObservableCollection<GmsVstViewModel>();
            
            this.GmsDscTemps = new  ObservableCollection<GmsDscTempViewModel>();
            
            this.GmsDscCamps = new  ObservableCollection<GmsDscCampViewModel>();
            
        }
        public override void Read()
        {
            this.GmsCdPresta=new GmsCdPrestaViewModel( this.Model.GmsCdPresta);
            this.GmsCdTypePv=new GmsCdTypePvViewModel( this.Model.GmsCdTypePv);
            this.IdCamp=this.Model.IdCamp;
            this.Annee=this.Model.Annee;
            this.Dater=this.Model.Dater;
            this.Dateg=this.Model.Dateg;
            this.Userg=this.Model.Userg;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.GmsCdPresta=this. GmsCdPresta.Model;
            this.Model.GmsCdTypePv=this. GmsCdTypePv.Model;
            this.Model.IdCamp=this.IdCamp;
            this.Model.Annee=this.Annee;
            this.Model.Dater=this.Dater;
            this.Model.Dateg=this.Dateg;
            this.Model.Userg=this.Userg;
            this.Model.Observ=this.Observ;
        }
        private GmsCdPrestaViewModel _gmsCdPresta;
        [DisplayName("Prestataire")]
        public virtual GmsCdPrestaViewModel GmsCdPresta
        {
            get
            {
                return this._gmsCdPresta;
            }
            set
            {
                this._gmsCdPresta = value;
                RaisePropertyChange("GmsCdPresta");
            }
        }
        
        private GmsCdTypePvViewModel _gmsCdTypePv;
        [DisplayName("Type de PV")]
        public virtual GmsCdTypePvViewModel GmsCdTypePv
        {
            get
            {
                return this._gmsCdTypePv;
            }
            set
            {
                this._gmsCdTypePv = value;
                RaisePropertyChange("GmsCdTypePv");
            }
        }
        
        public virtual ObservableCollection<GmsInspViewModel> GmsInsps { get; set; }
        
        public virtual ObservableCollection<GmsVstViewModel> GmsVsts { get; set; }
        
        public virtual ObservableCollection<GmsDscTempViewModel> GmsDscTemps { get; set; }
        
        public virtual ObservableCollection<GmsDscCampViewModel> GmsDscCamps { get; set; }
        
        private String _idCamp;
        [DisplayName("Identifiant")]
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdCamp"] != null)
                {
                    errors.Add("Identifiant : "+this["IdCamp"]);
                }
                if (this["Annee"] != null)
                {
                    errors.Add("Année : "+this["Annee"]);
                }
                if (this["Dater"] != null)
                {
                    errors.Add("Date maxi retour : "+this["Dater"]);
                }
                if (this["Dateg"] != null)
                {
                    errors.Add("Date génération : "+this["Dateg"]);
                }
                if (this["Userg"] != null)
                {
                    errors.Add("Nom créateur : "+this["Userg"]);
                }
                if (this["Observ"] != null)
                {
                    errors.Add("Commentaire : "+this["Observ"]);
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
                if (columnName.Equals("IdCamp"))
                {
                    if (String.IsNullOrEmpty(this.IdCamp))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Annee"))
                {
                }
                if (columnName.Equals("Dater"))
                {
                }
                if (columnName.Equals("Dateg"))
                {
                }
                if (columnName.Equals("Userg"))
                {
                }
                if (columnName.Equals("Observ"))
                {
                }
                return null;
            }
        }
    }
}
