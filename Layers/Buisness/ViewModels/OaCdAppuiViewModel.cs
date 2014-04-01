using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdAppuiViewModel : ViewModelBase<OaCdAppui>
    {
        public OaCdAppuiViewModel(OaCdAppui model) : base(model)
        {
            this.OaAppuiss = new  ObservableCollection<OaAppuisViewModel>();
            
        }
        public override void Read()
        {
            this.App=this.Model.App;
        }
        public override void Write()
        {
            this.Model.App=this.App;
        }
        public virtual ObservableCollection<OaAppuisViewModel> OaAppuiss { get; set; }
        
        private String _app;
        [DisplayName("Type d'appui")]
        public String App
        {
            get
            {
                return this._app;
            }
            set
            {
                this._app = value;
                RaisePropertyChange("App");
            }
        }
    }
}
