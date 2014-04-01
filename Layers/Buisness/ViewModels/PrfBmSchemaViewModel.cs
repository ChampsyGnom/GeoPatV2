using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmSchemaViewModel : ViewModelBase
    {
        public PrfBmSchema Model {get; set;}
        public PrfBmSchemaViewModel(PrfBmSchema model)
        {
            this.PrfBmTables = new  ObservableCollection<PrfBmTableViewModel>();
            
            this.PrfBmProfils = new  ObservableCollection<PrfBmProfilViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
