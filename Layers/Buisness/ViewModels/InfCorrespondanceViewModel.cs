using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCorrespondanceViewModel : ViewModelBase<InfCorrespondance>
    {
        public InfCorrespondanceViewModel(InfCorrespondance model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AxeSae=this.Model.AxeSae;
            this.EmplaceSae=this.Model.EmplaceSae;
            this.SensSae=this.Model.SensSae;
            this.AbsFin=this.Model.AbsFin;
            this.AbsDeb=this.Model.AbsDeb;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AxeSae=this.AxeSae;
            this.Model.EmplaceSae=this.EmplaceSae;
            this.Model.SensSae=this.SensSae;
            this.Model.AbsFin=this.AbsFin;
            this.Model.AbsDeb=this.AbsDeb;
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
        
        private String _axeSae;
        [DisplayName("Axe SAE")]
        public String AxeSae
        {
            get
            {
                return this._axeSae;
            }
            set
            {
                this._axeSae = value;
                RaisePropertyChange("AxeSae");
            }
        }
        private String _emplaceSae;
        [DisplayName("Emplacement SAE")]
        public String EmplaceSae
        {
            get
            {
                return this._emplaceSae;
            }
            set
            {
                this._emplaceSae = value;
                RaisePropertyChange("EmplaceSae");
            }
        }
        private String _sensSae;
        [DisplayName("Sens SAE")]
        public String SensSae
        {
            get
            {
                return this._sensSae;
            }
            set
            {
                this._sensSae = value;
                RaisePropertyChange("SensSae");
            }
        }
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
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
