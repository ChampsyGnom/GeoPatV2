using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhBpuViewModel : ViewModelBase<OhBpu>
    {
        public OhBpuViewModel(OhBpu model) : base(model)
        {
            this.OhPrevisions = new  ObservableCollection<OhPrevisionViewModel>();
            
            this.OhCdPrecoSprtVsts = new  ObservableCollection<OhCdPrecoSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdTravaux=new OhCdTravauxViewModel( this.Model.OhCdTravaux);
            this.OhCdUnite=new OhCdUniteViewModel( this.Model.OhCdUnite);
            this.IdBpu=this.Model.IdBpu;
            this.Techn=this.Model.Techn;
            this.Prix=this.Model.Prix;
            this.DateMaj=this.Model.DateMaj;
            this.Freq=this.Model.Freq;
            this.PrecoVst=this.Model.PrecoVst;
            this.RealisVst=this.Model.RealisVst;
        }
        public override void Write()
        {
            this.Model.OhCdTravaux=this. OhCdTravaux.Model;
            this.Model.OhCdUnite=this. OhCdUnite.Model;
            this.Model.IdBpu=this.IdBpu;
            this.Model.Techn=this.Techn;
            this.Model.Prix=this.Prix;
            this.Model.DateMaj=this.DateMaj;
            this.Model.Freq=this.Freq;
            this.Model.PrecoVst=this.PrecoVst;
            this.Model.RealisVst=this.RealisVst;
        }
        private OhCdTravauxViewModel _ohCdTravaux;
        [DisplayName("Type travaux")]
        public virtual OhCdTravauxViewModel OhCdTravaux
        {
            get
            {
                return this._ohCdTravaux;
            }
            set
            {
                this._ohCdTravaux = value;
                RaisePropertyChange("OhCdTravaux");
            }
        }
        
        private OhCdUniteViewModel _ohCdUnite;
        [DisplayName("unité")]
        public virtual OhCdUniteViewModel OhCdUnite
        {
            get
            {
                return this._ohCdUnite;
            }
            set
            {
                this._ohCdUnite = value;
                RaisePropertyChange("OhCdUnite");
            }
        }
        
        public virtual ObservableCollection<OhPrevisionViewModel> OhPrevisions { get; set; }
        
        public virtual ObservableCollection<OhCdPrecoSprtVstViewModel> OhCdPrecoSprtVsts { get; set; }
        
        private Int64 _idBpu;
        [DisplayName("Identifiant Bordereau")]
        public Int64 IdBpu
        {
            get
            {
                return this._idBpu;
            }
            set
            {
                this._idBpu = value;
                RaisePropertyChange("IdBpu");
            }
        }
        
        private String _techn;
        [DisplayName("Technique")]
        public String Techn
        {
            get
            {
                return this._techn;
            }
            set
            {
                this._techn = value;
                RaisePropertyChange("Techn");
            }
        }
        private Nullable<Int64> _prix;
        [DisplayName("Prix Unitaire (€)")]
        public Nullable<Int64> Prix
        {
            get
            {
                return this._prix;
            }
            set
            {
                this._prix = value;
                RaisePropertyChange("Prix");
            }
        }
        
        private Nullable<DateTime> _dateMaj;
        [DisplayName("Date MAJ")]
        public Nullable<DateTime> DateMaj
        {
            get
            {
                return this._dateMaj;
            }
            set
            {
                this._dateMaj = value;
                RaisePropertyChange("DateMaj");
            }
        }
        
        private Nullable<Int64> _freq;
        [DisplayName("Fréquence (mois)")]
        public Nullable<Int64> Freq
        {
            get
            {
                return this._freq;
            }
            set
            {
                this._freq = value;
                RaisePropertyChange("Freq");
            }
        }
        
        private Nullable<Boolean> _precoVst;
        [DisplayName("Préconisation Visite")]
        public Nullable<Boolean> PrecoVst
        {
            get
            {
                return this._precoVst;
            }
            set
            {
                this._precoVst = value;
                RaisePropertyChange("PrecoVst");
            }
        }
        
        private Nullable<Boolean> _realisVst;
        [DisplayName("Entretien réalisable")]
        public Nullable<Boolean> RealisVst
        {
            get
            {
                return this._realisVst;
            }
            set
            {
                this._realisVst = value;
                RaisePropertyChange("RealisVst");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdBpu"] != null)
                {
                    errors.Add("Identifiant Bordereau : "+this["IdBpu"]);
                }
                if (this["Techn"] != null)
                {
                    errors.Add("Technique : "+this["Techn"]);
                }
                if (this["Prix"] != null)
                {
                    errors.Add("Prix Unitaire (€) : "+this["Prix"]);
                }
                if (this["DateMaj"] != null)
                {
                    errors.Add("Date MAJ : "+this["DateMaj"]);
                }
                if (this["Freq"] != null)
                {
                    errors.Add("Fréquence (mois) : "+this["Freq"]);
                }
                if (this["PrecoVst"] != null)
                {
                    errors.Add("Préconisation Visite : "+this["PrecoVst"]);
                }
                if (this["RealisVst"] != null)
                {
                    errors.Add("Entretien réalisable : "+this["RealisVst"]);
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
                if (columnName.Equals("IdBpu"))
                {
                }
                if (columnName.Equals("Techn"))
                {
                    if (String.IsNullOrEmpty(this.Techn))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Prix"))
                {
                }
                if (columnName.Equals("DateMaj"))
                {
                }
                if (columnName.Equals("Freq"))
                {
                }
                if (columnName.Equals("PrecoVst"))
                {
                }
                if (columnName.Equals("RealisVst"))
                {
                }
                return null;
            }
        }
    }
}
