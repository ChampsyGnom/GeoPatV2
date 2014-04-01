using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdMatViewModel : ViewModelBase<ChsCdMat>
    {
        public ChsCdMatViewModel(ChsCdMat model) : base(model)
        {
            this.ChsMats = new  ObservableCollection<ChsMatViewModel>();
            
            this.ChsCdOrigs = new  ObservableCollection<ChsCdOrigViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<ChsMatViewModel> ChsMats { get; set; }
        
        public virtual ObservableCollection<ChsCdOrigViewModel> ChsCdOrigs { get; set; }
        
        private String _code;
        [DisplayName("Nature de matériaux")]
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
