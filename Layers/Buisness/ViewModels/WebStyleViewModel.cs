using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebStyleViewModel : ViewModelBase<WebStyle>
    {
        public WebStyleViewModel(WebStyle model) : base(model)
        {
            this.WebStyleRules = new  ObservableCollection<WebStyleRuleViewModel>();
            
            this.WebNodeWebStyles = new  ObservableCollection<WebNodeWebStyleViewModel>();
            
        }
        public override void Read()
        {
            this.Id=this.Model.Id;
            this.SchemaName=this.Model.SchemaName;
            this.TableName=this.Model.TableName;
            this.ColumnName=this.Model.ColumnName;
            this.Libelle=this.Model.Libelle;
            this.Defaut=this.Model.Defaut;
        }
        public override void Write()
        {
            this.Model.Id=this.Id;
            this.Model.SchemaName=this.SchemaName;
            this.Model.TableName=this.TableName;
            this.Model.ColumnName=this.ColumnName;
            this.Model.Libelle=this.Libelle;
            this.Model.Defaut=this.Defaut;
        }
        public virtual ObservableCollection<WebStyleRuleViewModel> WebStyleRules { get; set; }
        
        public virtual ObservableCollection<WebNodeWebStyleViewModel> WebNodeWebStyles { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant du style")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                RaisePropertyChange("Id");
            }
        }
        
        private String _schemaName;
        [DisplayName("Nom du schéma (optionel)")]
        public String SchemaName
        {
            get
            {
                return this._schemaName;
            }
            set
            {
                this._schemaName = value;
                RaisePropertyChange("SchemaName");
            }
        }
        private String _tableName;
        [DisplayName("Nom de la table (optionel)")]
        public String TableName
        {
            get
            {
                return this._tableName;
            }
            set
            {
                this._tableName = value;
                RaisePropertyChange("TableName");
            }
        }
        private String _columnName;
        [DisplayName("Nom de la colonne (optionel)")]
        public String ColumnName
        {
            get
            {
                return this._columnName;
            }
            set
            {
                this._columnName = value;
                RaisePropertyChange("ColumnName");
            }
        }
        private String _libelle;
        [DisplayName("Libellé du style")]
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
        private Boolean _defaut;
        [DisplayName("Style par défaut")]
        public Boolean Defaut
        {
            get
            {
                return this._defaut;
            }
            set
            {
                this._defaut = value;
                RaisePropertyChange("Defaut");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("Identifiant du style : "+this["Id"]);
                }
                if (this["SchemaName"] != null)
                {
                    errors.Add("Nom du schéma (optionel) : "+this["SchemaName"]);
                }
                if (this["TableName"] != null)
                {
                    errors.Add("Nom de la table (optionel) : "+this["TableName"]);
                }
                if (this["ColumnName"] != null)
                {
                    errors.Add("Nom de la colonne (optionel) : "+this["ColumnName"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé du style : "+this["Libelle"]);
                }
                if (this["Defaut"] != null)
                {
                    errors.Add("Style par défaut : "+this["Defaut"]);
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
                if (columnName.Equals("Id"))
                {
                }
                if (columnName.Equals("SchemaName"))
                {
                }
                if (columnName.Equals("TableName"))
                {
                }
                if (columnName.Equals("ColumnName"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Defaut"))
                {
                }
                return null;
            }
        }
    }
}
