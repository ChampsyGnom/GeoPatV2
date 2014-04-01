using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsMatViewModel : ViewModelBase<ChsMat>
    {
        public ChsMatViewModel(ChsMat model) : base(model)
        {
            this.ChsMatPaves = new  ObservableCollection<ChsMatPaveViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdMat=new ChsCdMatViewModel( this.Model.ChsCdMat);
            this.Mat=this.Model.Mat;
        }
        public override void Write()
        {
            this.Model.ChsCdMat=this. ChsCdMat.Model;
            this.Model.Mat=this.Mat;
        }
        private ChsCdMatViewModel _chsCdMat;
        [DisplayName("Nature de matériaux")]
        public virtual ChsCdMatViewModel ChsCdMat
        {
            get
            {
                return this._chsCdMat;
            }
            set
            {
                this._chsCdMat = value;
                RaisePropertyChange("ChsCdMat");
            }
        }
        
        public virtual ObservableCollection<ChsMatPaveViewModel> ChsMatPaves { get; set; }
        
        private String _mat;
        [DisplayName("Matériaux")]
        public String Mat
        {
            get
            {
                return this._mat;
            }
            set
            {
                this._mat = value;
                RaisePropertyChange("Mat");
            }
        }
    }
}
