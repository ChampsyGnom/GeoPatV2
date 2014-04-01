using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoSiModelViewModel : ViewModelBase<MapinfoSiModel>
    {
        public MapinfoSiModelViewModel(MapinfoSiModel model) : base(model)
        {
            this.MapinfoSiZones = new  ObservableCollection<MapinfoSiZoneViewModel>();
            
        }
        public override void Read()
        {
            this.NomModel=this.Model.NomModel;
        }
        public override void Write()
        {
            this.Model.NomModel=this.NomModel;
        }
        public virtual ObservableCollection<MapinfoSiZoneViewModel> MapinfoSiZones { get; set; }
        
        private String _nomModel;
        [DisplayName("Si Model  Nom Model")]
        public String NomModel
        {
            get
            {
                return this._nomModel;
            }
            set
            {
                this._nomModel = value;
                RaisePropertyChange("NomModel");
            }
        }
    }
}
