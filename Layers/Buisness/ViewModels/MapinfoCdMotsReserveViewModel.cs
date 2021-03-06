using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoCdMotsReserveViewModel : ViewModelBase<MapinfoCdMotsReserve>
    {
        public MapinfoCdMotsReserveViewModel(MapinfoCdMotsReserve model) : base(model)
        {
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Keyword"] != null)
                {
                    errors.Add("Mot clef : "+this["Keyword"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Keyword"))
                {
                    if (String.IsNullOrEmpty(this.Keyword))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
