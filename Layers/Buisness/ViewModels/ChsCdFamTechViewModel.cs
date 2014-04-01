using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdFamTechViewModel : ViewModelBase<ChsCdFamTech>
    {
        public ChsCdFamTechViewModel(ChsCdFamTech model) : base(model)
        {
            this.ChsCdTechs = new  ObservableCollection<ChsCdTechViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<ChsCdTechViewModel> ChsCdTechs { get; set; }
        
        private String _code;
        [DisplayName("Famille technique")]
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
