using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfClimViewModel : ViewModelBase
    {
        public InfClim Model {get; set;}
        public InfClimViewModel(InfClim model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdClim=new InfCdClimViewModel( this.Model.InfCdClim);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.InfCdClim=this. InfCdClim.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Libelle=this.Libelle;
        }
        private InfCdClimViewModel _infCdClim;
        [DisplayName("Type Zone Climatique")]
        public virtual InfCdClimViewModel InfCdClim
        {
            get
            {
                return this._infCdClim;
            }
            set
            {
                this._infCdClim = value;
                RaisePropertyChange("InfCdClim");
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
    }
}
