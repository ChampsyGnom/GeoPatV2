using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdPositViewModel : ViewModelBase
    {
        public ChsCdPosit Model {get; set;}
        public ChsCdPositViewModel(ChsCdPosit model)
        {
            this.ChsEvts = new  ObservableCollection<ChsEvtViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Posit=this.Model.Posit;
        }
        public override void Write()
        {
            this.Model.Posit=this.Posit;
        }
        public virtual ObservableCollection<ChsEvtViewModel> ChsEvts { get; set; }
        
        private String _posit;
        [DisplayName("Position")]
        public String Posit
        {
            get
            {
                return this._posit;
            }
            set
            {
                this._posit = value;
                RaisePropertyChange("Posit");
            }
        }
    }
}
