using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmSchemaViewModel : ViewModelBase<PrfBmSchema>
    {
        public PrfBmSchemaViewModel(PrfBmSchema model) : base(model)
        {
            this.PrfBmTables = new  ObservableCollection<PrfBmTableViewModel>();
            
            this.PrfBmProfils = new  ObservableCollection<PrfBmProfilViewModel>();
            
        }
        public override void Read()
        {
            this.Schema=this.Model.Schema;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Schema=this.Schema;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<PrfBmTableViewModel> PrfBmTables { get; set; }
        
        public virtual ObservableCollection<PrfBmProfilViewModel> PrfBmProfils { get; set; }
        
        private String _schema;
        [DisplayName("Code schéma")]
        public String Schema
        {
            get
            {
                return this._schema;
            }
            set
            {
                this._schema = value;
                RaisePropertyChange("Schema");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Schema"] != null)
                {
                    errors.Add("Code schéma : "+this["Schema"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Schema"))
                {
                    if (String.IsNullOrEmpty(this.Schema))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
