using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotBpuViewModel : ViewModelBase<GotBpu>
    {
        public GotBpuViewModel(GotBpu model) : base(model)
        {
            this.GotPrevisions = new  ObservableCollection<GotPrevisionViewModel>();
            
            this.GotCdPrecoSprtVsts = new  ObservableCollection<GotCdPrecoSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.GotCdTravaux=new GotCdTravauxViewModel( this.Model.GotCdTravaux);
            this.GotCdUnite=new GotCdUniteViewModel( this.Model.GotCdUnite);
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
            this.Model.GotCdTravaux=this. GotCdTravaux.Model;
            this.Model.GotCdUnite=this. GotCdUnite.Model;
            this.Model.IdBpu=this.IdBpu;
            this.Model.Techn=this.Techn;
            this.Model.Prix=this.Prix;
            this.Model.DateMaj=this.DateMaj;
            this.Model.Freq=this.Freq;
            this.Model.PrecoVst=this.PrecoVst;
            this.Model.RealisVst=this.RealisVst;
        }
        private GotCdTravauxViewModel _gotCdTravaux;
        [DisplayName("Type travaux")]
        public virtual GotCdTravauxViewModel GotCdTravaux
        {
            get
            {
                return this._gotCdTravaux;
            }
            set
            {
                this._gotCdTravaux = value;
                RaisePropertyChange("GotCdTravaux");
            }
        }
        
        private GotCdUniteViewModel _gotCdUnite;
        [DisplayName("unité")]
        public virtual GotCdUniteViewModel GotCdUnite
        {
            get
            {
                return this._gotCdUnite;
            }
            set
            {
                this._gotCdUnite = value;
                RaisePropertyChange("GotCdUnite");
            }
        }
        
        public virtual ObservableCollection<GotPrevisionViewModel> GotPrevisions { get; set; }
        
        public virtual ObservableCollection<GotCdPrecoSprtVstViewModel> GotCdPrecoSprtVsts { get; set; }
        
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
        private Int64 _prix;
        [DisplayName("Prix Unitaire (€)")]
        public Int64 Prix
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
