using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdComposantViewModel : ViewModelBase
    {
        public GmsCdComposant Model {get; set;}
        public GmsCdComposantViewModel(GmsCdComposant model)
        {
            this.GmsCdEntetes = new  ObservableCollection<GmsCdEnteteViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.TypeComp=this.Model.TypeComp;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.TypeComp=this.TypeComp;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<GmsCdEnteteViewModel> GmsCdEntetes { get; set; }
        
        private String _typeComp;
        [DisplayName("Type")]
        public String TypeComp
        {
            get
            {
                return this._typeComp;
            }
            set
            {
                this._typeComp = value;
                RaisePropertyChange("TypeComp");
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
