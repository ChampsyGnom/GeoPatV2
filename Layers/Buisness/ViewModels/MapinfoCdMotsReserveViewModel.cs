using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoCdMotsReserveViewModel : ViewModelBase
    {
        public MapinfoCdMotsReserve Model {get; set;}
        public MapinfoCdMotsReserveViewModel(MapinfoCdMotsReserve model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Keyword=this.Model.Keyword;
        }
        public override void Write()
        {
            this.Model.Keyword=this.Keyword;
        }
        private String _keyword;
        [DisplayName("Mot clef")]
        public String Keyword
        {
            get
            {
                return this._keyword;
            }
            set
            {
                this._keyword = value;
                RaisePropertyChange("Keyword");
            }
        }
    }
}
