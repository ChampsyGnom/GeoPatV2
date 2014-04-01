using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnBpuViewModel : ViewModelBase
    {
        public BsnBpu Model {get; set;}
        public BsnBpuViewModel(BsnBpu model)
        {
            this.BsnPrevisions = new  ObservableCollection<BsnPrevisionViewModel>();
            
            this.BsnCdPrecoSprtVsts = new  ObservableCollection<BsnCdPrecoSprtVstViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnCdTravaux=new BsnCdTravauxViewModel( this.Model.BsnCdTravaux);
            this.BsnCdUnite=new BsnCdUniteViewModel( this.Model.BsnCdUnite);
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
            this.Model.BsnCdTravaux=this. BsnCdTravaux.Model;
            this.Model.BsnCdUnite=this. BsnCdUnite.Model;
            this.Model.IdBpu=this.IdBpu;
            this.Model.Techn=this.Techn;
            this.Model.Prix=this.Prix;
            this.Model.DateMaj=this.DateMaj;
            this.Model.Freq=this.Freq;
            this.Model.PrecoVst=this.PrecoVst;
            this.Model.RealisVst=this.RealisVst;
        }
        private BsnCdTravauxViewModel _bsnCdTravaux;
        [DisplayName("Type travaux")]
        public virtual BsnCdTravauxViewModel BsnCdTravaux
        {
            get
            {
                return this._bsnCdTravaux;
            }
            set
            {
                this._bsnCdTravaux = value;
                RaisePropertyChange("BsnCdTravaux");
            }
        }
        
        private BsnCdUniteViewModel _bsnCdUnite;
        [DisplayName("Unité")]
        public virtual BsnCdUniteViewModel BsnCdUnite
        {
            get
            {
                return this._bsnCdUnite;
            }
            set
            {
                this._bsnCdUnite = value;
                RaisePropertyChange("BsnCdUnite");
            }
        }
        
        public virtual ObservableCollection<BsnPrevisionViewModel> BsnPrevisions { get; set; }
        
        public virtual ObservableCollection<BsnCdPrecoSprtVstViewModel> BsnCdPrecoSprtVsts { get; set; }
        
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
        [DisplayName("Prix Unitaire")]
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
        
    }
}
