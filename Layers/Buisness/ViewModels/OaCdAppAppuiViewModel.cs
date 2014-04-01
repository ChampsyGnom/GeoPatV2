using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdAppAppuiViewModel : ViewModelBase
    {
        public OaCdAppAppui Model {get; set;}
        public OaCdAppAppuiViewModel(OaCdAppAppui model)
        {
            this.OaAppuiss = new  ObservableCollection<OaAppuisViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Appui=this.Model.Appui;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Appui=this.Appui;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<OaAppuisViewModel> OaAppuiss { get; set; }
        
        private String _appui;
        [DisplayName("Type app appui")]
        public String Appui
        {
            get
            {
                return this._appui;
            }
            set
            {
                this._appui = value;
                RaisePropertyChange("Appui");
            }
        }
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie (mois)")]
        public Nullable<Int64> Garantie
        {
            get
            {
                return this._garantie;
            }
            set
            {
                this._garantie = value;
                RaisePropertyChange("Garantie");
            }
        }
        
        private Nullable<Int64> _dvt;
        [DisplayName("Durée de vie (mois)")]
        public Nullable<Int64> Dvt
        {
            get
            {
                return this._dvt;
            }
            set
            {
                this._dvt = value;
                RaisePropertyChange("Dvt");
            }
        }
        
    }
}
