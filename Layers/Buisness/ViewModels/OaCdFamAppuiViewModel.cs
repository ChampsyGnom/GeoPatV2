using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdFamAppuiViewModel : ViewModelBase<OaCdFamAppui>
    {
        public OaCdFamAppuiViewModel(OaCdFamAppui model) : base(model)
        {
            this.OaAppuiss = new  ObservableCollection<OaAppuisViewModel>();
            
        }
        public override void Read()
        {
            this.FamApp=this.Model.FamApp;
        }
        public override void Write()
        {
            this.Model.FamApp=this.FamApp;
        }
        public virtual ObservableCollection<OaAppuisViewModel> OaAppuiss { get; set; }
        
        private String _famApp;
        [DisplayName("Famille d'appuis")]
        public String FamApp
        {
            get
            {
                return this._famApp;
            }
            set
            {
                this._famApp = value;
                RaisePropertyChange("FamApp");
            }
        }
    }
}
