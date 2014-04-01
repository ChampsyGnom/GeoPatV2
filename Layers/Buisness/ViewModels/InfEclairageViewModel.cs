using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfEclairageViewModel : ViewModelBase
    {
        public InfEclairage Model {get; set;}
        public InfEclairageViewModel(InfEclairage model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdEclair=new InfCdEclairViewModel( this.Model.InfCdEclair);
            this.InfCdPosit=new InfCdPositViewModel( this.Model.InfCdPosit);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
        }
        public override void Write()
        {
            this.Model.InfCdEclair=this. InfCdEclair.Model;
            this.Model.InfCdPosit=this. InfCdPosit.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
        }
        private InfCdEclairViewModel _infCdEclair;
        [DisplayName("Type Eclairage")]
        public virtual InfCdEclairViewModel InfCdEclair
        {
            get
            {
                return this._infCdEclair;
            }
            set
            {
                this._infCdEclair = value;
                RaisePropertyChange("InfCdEclair");
            }
        }
        
        private InfCdPositViewModel _infCdPosit;
        [DisplayName("Code Position")]
        public virtual InfCdPositViewModel InfCdPosit
        {
            get
            {
                return this._infCdPosit;
            }
            set
            {
                this._infCdPosit = value;
                RaisePropertyChange("InfCdPosit");
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
        
    }
}
