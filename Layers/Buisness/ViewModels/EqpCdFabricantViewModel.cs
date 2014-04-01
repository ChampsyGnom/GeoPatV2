using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdFabricantViewModel : ViewModelBase
    {
        public EqpCdFabricant Model {get; set;}
        public EqpCdFabricantViewModel(EqpCdFabricant model)
        {
            this.EqpDscShs = new  ObservableCollection<EqpDscShViewModel>();
            
            this.EqpDscPos = new  ObservableCollection<EqpDscPoViewModel>();
            
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
            this.EqpDscDvs = new  ObservableCollection<EqpDscDvViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Nom=this.Model.Nom;
        }
        public override void Write()
        {
            this.Model.Nom=this.Nom;
        }
        public virtual ObservableCollection<EqpDscShViewModel> EqpDscShs { get; set; }
        
        public virtual ObservableCollection<EqpDscPoViewModel> EqpDscPos { get; set; }
        
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        public virtual ObservableCollection<EqpDscDvViewModel> EqpDscDvs { get; set; }
        
        private String _nom;
        [DisplayName("Nom Fabricant")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
            }
        }
    }
}
