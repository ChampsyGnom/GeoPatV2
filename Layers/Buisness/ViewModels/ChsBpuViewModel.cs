using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsBpuViewModel : ViewModelBase
    {
        public ChsBpu Model {get; set;}
        public ChsBpuViewModel(ChsBpu model)
        {
            this.ChsPrevisions = new  ObservableCollection<ChsPrevisionViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsCdTravaux=new ChsCdTravauxViewModel( this.Model.ChsCdTravaux);
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.Prix=this.Model.Prix;
            this.DateMaj=this.Model.DateMaj;
        }
        public override void Write()
        {
            this.Model.ChsCdTravaux=this. ChsCdTravaux.Model;
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.Prix=this.Prix;
            this.Model.DateMaj=this.DateMaj;
        }
        private ChsCdTravauxViewModel _chsCdTravaux;
        [DisplayName("Type travaux")]
        public virtual ChsCdTravauxViewModel ChsCdTravaux
        {
            get
            {
                return this._chsCdTravaux;
            }
            set
            {
                this._chsCdTravaux = value;
                RaisePropertyChange("ChsCdTravaux");
            }
        }
        
        public virtual ObservableCollection<ChsPrevisionViewModel> ChsPrevisions { get; set; }
        
        private String _code;
        [DisplayName("Technique")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
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
        
    }
}
