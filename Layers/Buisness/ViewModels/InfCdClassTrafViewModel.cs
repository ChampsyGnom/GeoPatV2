using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdClassTrafViewModel : ViewModelBase
    {
        public InfCdClassTraf Model {get; set;}
        public InfCdClassTrafViewModel(InfCdClassTraf model)
        {
            this.InfSectionTrafics = new  ObservableCollection<InfSectionTraficViewModel>();
            
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
        public virtual ObservableCollection<InfSectionTraficViewModel> InfSectionTrafics { get; set; }
        
        private String _code;
        [DisplayName("Classe de trafic")]
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
