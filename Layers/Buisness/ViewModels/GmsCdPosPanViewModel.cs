using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdPosPanViewModel : ViewModelBase
    {
        public GmsCdPosPan Model {get; set;}
        public GmsCdPosPanViewModel(GmsCdPosPan model)
        {
            this.GmsPanneaus = new  ObservableCollection<GmsPanneauViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Posit=this.Model.Posit;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Posit=this.Posit;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<GmsPanneauViewModel> GmsPanneaus { get; set; }
        
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
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
    }
}
