using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsBpuColorViewModel : ViewModelBase<DsBpuColor>
    {
        public DsBpuColorViewModel(DsBpuColor model) : base(model)
        {
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Color=this.Model.Color;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Color=this.Color;
        }
        private String _code;
        [DisplayName("BPU_COLOR_DS__CODE")]
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
        private String _color;
        [DisplayName("BPU_COLOR_DS__COLOR")]
        public String Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
                RaisePropertyChange("Color");
            }
        }
    }
}
