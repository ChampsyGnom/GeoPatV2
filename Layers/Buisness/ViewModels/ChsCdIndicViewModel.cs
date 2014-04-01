using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdIndicViewModel : ViewModelBase<ChsCdIndic>
    {
        public ChsCdIndicViewModel(ChsCdIndic model) : base(model)
        {
            this.ChsCdSeuils = new  ObservableCollection<ChsCdSeuilViewModel>();
            
            this.ChsDetailCamps = new  ObservableCollection<ChsDetailCampViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdMesure=new ChsCdMesureViewModel( this.Model.ChsCdMesure);
            this.Indic=this.Model.Indic;
            this.Libelle=this.Model.Libelle;
            this.Unite=this.Model.Unite;
            this.Vmin=this.Model.Vmin;
            this.Vmax=this.Model.Vmax;
            this.Invalide=this.Model.Invalide;
            this.Formats=this.Model.Formats;
        }
        public override void Write()
        {
            this.Model.ChsCdMesure=this. ChsCdMesure.Model;
            this.Model.Indic=this.Indic;
            this.Model.Libelle=this.Libelle;
            this.Model.Unite=this.Unite;
            this.Model.Vmin=this.Vmin;
            this.Model.Vmax=this.Vmax;
            this.Model.Invalide=this.Invalide;
            this.Model.Formats=this.Formats;
        }
        private ChsCdMesureViewModel _chsCdMesure;
        [DisplayName("Appareils de mesure")]
        public virtual ChsCdMesureViewModel ChsCdMesure
        {
            get
            {
                return this._chsCdMesure;
            }
            set
            {
                this._chsCdMesure = value;
                RaisePropertyChange("ChsCdMesure");
            }
        }
        
        public virtual ObservableCollection<ChsCdSeuilViewModel> ChsCdSeuils { get; set; }
        
        public virtual ObservableCollection<ChsDetailCampViewModel> ChsDetailCamps { get; set; }
        
        private String _indic;
        [DisplayName("Indicateur")]
        public String Indic
        {
            get
            {
                return this._indic;
            }
            set
            {
                this._indic = value;
                RaisePropertyChange("Indic");
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
        private String _unite;
        [DisplayName("Unité")]
        public String Unite
        {
            get
            {
                return this._unite;
            }
            set
            {
                this._unite = value;
                RaisePropertyChange("Unite");
            }
        }
        private Nullable<Int64> _vmin;
        [DisplayName("Min")]
        public Nullable<Int64> Vmin
        {
            get
            {
                return this._vmin;
            }
            set
            {
                this._vmin = value;
                RaisePropertyChange("Vmin");
            }
        }
        
        private Nullable<Int64> _vmax;
        [DisplayName("Max")]
        public Nullable<Int64> Vmax
        {
            get
            {
                return this._vmax;
            }
            set
            {
                this._vmax = value;
                RaisePropertyChange("Vmax");
            }
        }
        
        private Nullable<Int64> _invalide;
        [DisplayName("Invalide")]
        public Nullable<Int64> Invalide
        {
            get
            {
                return this._invalide;
            }
            set
            {
                this._invalide = value;
                RaisePropertyChange("Invalide");
            }
        }
        
        private String _formats;
        [DisplayName("Format Ind")]
        public String Formats
        {
            get
            {
                return this._formats;
            }
            set
            {
                this._formats = value;
                RaisePropertyChange("Formats");
            }
        }
    }
}
