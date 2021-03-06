using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoSiModelPredefViewModel : ViewModelBase<MapinfoSiModelPredef>
    {
        public MapinfoSiModelPredefViewModel(MapinfoSiModelPredef model) : base(model)
        {
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nomtable"] != null)
                {
                    errors.Add("Si Model Predef  NomTable : "+this["Nomtable"]);
                }
                if (this["Nomschema"] != null)
                {
                    errors.Add("Si Model Predef  NomSchema : "+this["Nomschema"]);
                }
                if (this["NomModel"] != null)
                {
                    errors.Add("Si Model Predef  NomModel : "+this["NomModel"]);
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
                if (columnName.Equals("Nomtable"))
                {
                    if (String.IsNullOrEmpty(this.Nomtable))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Nomschema"))
                {
                    if (String.IsNullOrEmpty(this.Nomschema))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("NomModel"))
                {
                    if (String.IsNullOrEmpty(this.NomModel))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
