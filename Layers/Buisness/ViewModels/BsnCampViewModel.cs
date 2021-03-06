using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCampViewModel : ViewModelBase<BsnCamp>
    {
        public BsnCampViewModel(BsnCamp model) : base(model)
        {
            this.BsnInsps = new  ObservableCollection<BsnInspViewModel>();
            
            this.BsnVsts = new  ObservableCollection<BsnVstViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
            this.BsnDscCamps = new  ObservableCollection<BsnDscCampViewModel>();
            
        }
        public override void Read()
        {
            this.BsnCdPresta=new BsnCdPrestaViewModel( this.Model.BsnCdPresta);
            this.BsnCdTypePv=new BsnCdTypePvViewModel( this.Model.BsnCdTypePv);
            this.IdCamp=this.Model.IdCamp;
            this.Annee=this.Model.Annee;
            this.Dater=this.Model.Dater;
            this.Dateg=this.Model.Dateg;
            this.Userg=this.Model.Userg;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.BsnCdPresta=this. BsnCdPresta.Model;
            this.Model.BsnCdTypePv=this. BsnCdTypePv.Model;
            this.Model.IdCamp=this.IdCamp;
            this.Model.Annee=this.Annee;
            this.Model.Dater=this.Dater;
            this.Model.Dateg=this.Dateg;
            this.Model.Userg=this.Userg;
            this.Model.Observ=this.Observ;
        }
        private BsnCdPrestaViewModel _bsnCdPresta;
        [DisplayName("Prestataire")]
        public virtual BsnCdPrestaViewModel BsnCdPresta
        {
            get
            {
                return this._bsnCdPresta;
            }
            set
            {
                this._bsnCdPresta = value;
                RaisePropertyChange("BsnCdPresta");
            }
        }
        
        private BsnCdTypePvViewModel _bsnCdTypePv;
        [DisplayName("Type PV")]
        public virtual BsnCdTypePvViewModel BsnCdTypePv
        {
            get
            {
                return this._bsnCdTypePv;
            }
            set
            {
                this._bsnCdTypePv = value;
                RaisePropertyChange("BsnCdTypePv");
            }
        }
        
        public virtual ObservableCollection<BsnInspViewModel> BsnInsps { get; set; }
        
        public virtual ObservableCollection<BsnVstViewModel> BsnVsts { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        public virtual ObservableCollection<BsnDscCampViewModel> BsnDscCamps { get; set; }
        
        private String _idCamp;
        [DisplayName("Identifiant Campagne")]
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
                    errors.Add("Identifiant Campagne : "+this["IdCamp"]);
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
