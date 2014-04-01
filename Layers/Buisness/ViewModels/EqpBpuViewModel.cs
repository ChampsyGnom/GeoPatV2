using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpBpuViewModel : ViewModelBase<EqpBpu>
    {
        public EqpBpuViewModel(EqpBpu model) : base(model)
        {
            this.EqpPrevisions = new  ObservableCollection<EqpPrevisionViewModel>();
            
        }
        public override void Read()
        {
            this.EqpCdTravaux=new EqpCdTravauxViewModel( this.Model.EqpCdTravaux);
            this.Techn=this.Model.Techn;
            this.Prix=this.Model.Prix;
            this.DateMaj=this.Model.DateMaj;
            this.Freq=this.Model.Freq;
        }
        public override void Write()
        {
            this.Model.EqpCdTravaux=this. EqpCdTravaux.Model;
            this.Model.Techn=this.Techn;
            this.Model.Prix=this.Prix;
            this.Model.DateMaj=this.DateMaj;
            this.Model.Freq=this.Freq;
        }
        private EqpCdTravauxViewModel _eqpCdTravaux;
        [DisplayName("Code travaux")]
        public virtual EqpCdTravauxViewModel EqpCdTravaux
        {
            get
            {
                return this._eqpCdTravaux;
            }
            set
            {
                this._eqpCdTravaux = value;
                RaisePropertyChange("EqpCdTravaux");
            }
        }
        
        public virtual ObservableCollection<EqpPrevisionViewModel> EqpPrevisions { get; set; }
        
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
        [DisplayName("Fréquence (Mois)")]
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
        
    }
}
