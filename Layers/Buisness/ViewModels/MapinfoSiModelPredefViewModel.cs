using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoSiModelPredefViewModel : ViewModelBase
    {
        public MapinfoSiModelPredef Model {get; set;}
        public MapinfoSiModelPredefViewModel(MapinfoSiModelPredef model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Nomtable=this.Model.Nomtable;
            this.Nomschema=this.Model.Nomschema;
            this.NomModel=this.Model.NomModel;
        }
        public override void Write()
        {
            this.Model.Nomtable=this.Nomtable;
            this.Model.Nomschema=this.Nomschema;
            this.Model.NomModel=this.NomModel;
        }
        private String _nomtable;
        [DisplayName("Si Model Predef  NomTable")]
        public String Nomtable
        {
            get
            {
                return this._nomtable;
            }
            set
            {
                this._nomtable = value;
                RaisePropertyChange("Nomtable");
            }
        }
        private String _nomschema;
        [DisplayName("Si Model Predef  NomSchema")]
        public String Nomschema
        {
            get
            {
                return this._nomschema;
            }
            set
            {
                this._nomschema = value;
                RaisePropertyChange("Nomschema");
            }
        }
        private String _nomModel;
        [DisplayName("Si Model Predef  NomModel")]
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
