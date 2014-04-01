using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfTalusViewModel : ViewModelBase
    {
        public InfTalus Model {get; set;}
        public InfTalusViewModel(InfTalus model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdTalus=new InfCdTalusViewModel( this.Model.InfCdTalus);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Haut=this.Model.Haut;
        }
        public override void Write()
        {
            this.Model.InfCdTalus=this. InfCdTalus.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Haut=this.Haut;
        }
        private InfCdTalusViewModel _infCdTalus;
        [DisplayName("Type Talus")]
        public virtual InfCdTalusViewModel InfCdTalus
        {
            get
            {
                return this._infCdTalus;
            }
            set
            {
                this._infCdTalus = value;
                RaisePropertyChange("InfCdTalus");
            }
        }
        
        private InfChausseeViewModel _infChaussee;
        [DisplayName("Chaussée")]
        public virtual InfChausseeViewModel InfChaussee
        {
            get
            {
                return this._infChaussee;
            }
            set
            {
                this._infChaussee = value;
                RaisePropertyChange("InfChaussee");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private Nullable<Int64> _absFin;
        [DisplayName("Fin")]
        public Nullable<Int64> AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
        private Nullable<Double> _haut;
        [DisplayName("hauteur (m)")]
        public Nullable<Double> Haut
        {
            get
            {
                return this._haut;
            }
            set
            {
                this._haut = value;
                RaisePropertyChange("Haut");
            }
        }
        
    }
}
