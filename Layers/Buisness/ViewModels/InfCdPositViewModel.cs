using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdPositViewModel : ViewModelBase
    {
        public InfCdPosit Model {get; set;}
        public InfCdPositViewModel(InfCdPosit model)
        {
            this.InfSecurites = new  ObservableCollection<InfSecuriteViewModel>();
            
            this.InfEclairages = new  ObservableCollection<InfEclairageViewModel>();
            
            this.InfEvts = new  ObservableCollection<InfEvtViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Posit=this.Model.Posit;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.Posit=this.Posit;
            this.Model.Ordre=this.Ordre;
        }
        public virtual ObservableCollection<InfSecuriteViewModel> InfSecurites { get; set; }
        
        public virtual ObservableCollection<InfEclairageViewModel> InfEclairages { get; set; }
        
        public virtual ObservableCollection<InfEvtViewModel> InfEvts { get; set; }
        
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
        private Nullable<Int64> _ordre;
        [DisplayName("N° Ordre")]
        public Nullable<Int64> Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
    }
}
