using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdFondationViewModel : ViewModelBase
    {
        public EqpCdFondation Model {get; set;}
        public EqpCdFondationViewModel(EqpCdFondation model)
        {
            this.EqpDscSvs = new  ObservableCollection<EqpDscSvViewModel>();
            
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Fondation=this.Model.Fondation;
        }
        public override void Write()
        {
            this.Model.Fondation=this.Fondation;
        }
        public virtual ObservableCollection<EqpDscSvViewModel> EqpDscSvs { get; set; }
        
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _fondation;
        [DisplayName("Type fondation")]
        public String Fondation
        {
            get
            {
                return this._fondation;
            }
            set
            {
                this._fondation = value;
                RaisePropertyChange("Fondation");
            }
        }
    }
}
