using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsMatViewModel : ViewModelBase<DsMat>
    {
        public DsMatViewModel(DsMat model) : base(model)
        {
            this.DsMatParams = new  ObservableCollection<DsMatParamViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.AgrX=this.Model.AgrX;
            this.IndicX=this.Model.IndicX;
            this.AgrY=this.Model.AgrY;
            this.IndicY=this.Model.IndicY;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.AgrX=this.AgrX;
            this.Model.IndicX=this.IndicX;
            this.Model.AgrY=this.AgrY;
            this.Model.IndicY=this.IndicY;
        }
        public virtual ObservableCollection<DsMatParamViewModel> DsMatParams { get; set; }
        
        private String _code;
        [DisplayName("MAT_DS__CODE")]
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
        [DisplayName("MAT_DS__LIBELLE")]
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
        private String _agrX;
        [DisplayName("MAT_DS__AGR_X")]
        public String AgrX
        {
            get
            {
                return this._agrX;
            }
            set
            {
                this._agrX = value;
                RaisePropertyChange("AgrX");
            }
        }
        private String _indicX;
        [DisplayName("MAT_DS__INDIC_X")]
        public String IndicX
        {
            get
            {
                return this._indicX;
            }
            set
            {
                this._indicX = value;
                RaisePropertyChange("IndicX");
            }
        }
        private String _agrY;
        [DisplayName("MAT_DS__AGR_Y")]
        public String AgrY
        {
            get
            {
                return this._agrY;
            }
            set
            {
                this._agrY = value;
                RaisePropertyChange("AgrY");
            }
        }
        private String _indicY;
        [DisplayName("MAT_DS__INDIC_Y")]
        public String IndicY
        {
            get
            {
                return this._indicY;
            }
            set
            {
                this._indicY = value;
                RaisePropertyChange("IndicY");
            }
        }
    }
}
