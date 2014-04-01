using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsMatParamViewModel : ViewModelBase<DsMatParam>
    {
        public DsMatParamViewModel(DsMatParam model) : base(model)
        {
        }
        public override void Read()
        {
            this.DsMat=new DsMatViewModel( this.Model.DsMat);
            this.X=this.Model.X;
            this.Y=this.Model.Y;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.DsMat=this. DsMat.Model;
            this.Model.X=this.X;
            this.Model.Y=this.Y;
            this.Model.Valeur=this.Valeur;
        }
        private DsMatViewModel _dsMat;
        [DisplayName("MAT_DS")]
        public virtual DsMatViewModel DsMat
        {
            get
            {
                return this._dsMat;
            }
            set
            {
                this._dsMat = value;
                RaisePropertyChange("DsMat");
            }
        }
        
        private Int64 _x;
        [DisplayName("MAT_PARAM_DS__X")]
        public Int64 X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
                RaisePropertyChange("X");
            }
        }
        
        private Int64 _y;
        [DisplayName("MAT_PARAM_DS__Y")]
        public Int64 Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
                RaisePropertyChange("Y");
            }
        }
        
        private Int64 _valeur;
        [DisplayName("MAT_PARAM_DS__VALEUR")]
        public Int64 Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        
    }
}
