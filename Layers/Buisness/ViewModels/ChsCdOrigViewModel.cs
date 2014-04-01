using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdOrigViewModel : ViewModelBase<ChsCdOrig>
    {
        public ChsCdOrigViewModel(ChsCdOrig model) : base(model)
        {
            this.ChsFabCars = new  ObservableCollection<ChsFabCarViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdMat=new ChsCdMatViewModel( this.Model.ChsCdMat);
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.ChsCdMat=this. ChsCdMat.Model;
            this.Model.Code=this.Code;
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
        
        public virtual ObservableCollection<ChsFabCarViewModel> ChsFabCars { get; set; }
        
        private String _code;
        [DisplayName("Type fabricant/carrière")]
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
    }
}
