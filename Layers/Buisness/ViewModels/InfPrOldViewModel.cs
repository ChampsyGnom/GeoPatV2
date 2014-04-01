using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPrOldViewModel : ViewModelBase<InfPrOld>
    {
        public InfPrOldViewModel(InfPrOld model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.Num=this.Model.Num;
            this.Inter=this.Model.Inter;
            this.AbsCum=this.Model.AbsCum;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.Num=this.Num;
            this.Model.Inter=this.Inter;
            this.Model.AbsCum=this.AbsCum;
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
        
        private Int64 _num;
        [DisplayName("Numéro PR")]
        public Int64 Num
        {
            get
            {
                return this._num;
            }
            set
            {
                this._num = value;
                RaisePropertyChange("Num");
            }
        }
        
        private Int64 _inter;
        [DisplayName("Inter PR")]
        public Int64 Inter
        {
            get
            {
                return this._inter;
            }
            set
            {
                this._inter = value;
                RaisePropertyChange("Inter");
            }
        }
        
        private Nullable<Int64> _absCum;
        [DisplayName("Abscisse cumulée")]
        public Nullable<Int64> AbsCum
        {
            get
            {
                return this._absCum;
            }
            set
            {
                this._absCum = value;
                RaisePropertyChange("AbsCum");
            }
        }
        
    }
}
