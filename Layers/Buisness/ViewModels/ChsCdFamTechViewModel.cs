using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdFamTechViewModel : ViewModelBase
    {
        public ChsCdFamTech Model {get; set;}
        public ChsCdFamTechViewModel(ChsCdFamTech model)
        {
            this.ChsCdTechs = new  ObservableCollection<ChsCdTechViewModel>();
            
            this.Model = model;
            this.Read();
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
