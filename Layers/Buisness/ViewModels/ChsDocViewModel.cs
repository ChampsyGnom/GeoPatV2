using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsDocViewModel : ViewModelBase<ChsDoc>
    {
        public ChsDocViewModel(ChsDoc model) : base(model)
        {
            this.ChsContacts = new  ObservableCollection<ChsContactViewModel>();
            
            this.ChsClsDocs = new  ObservableCollection<ChsClsDocViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdDoc=new ChsCdDocViewModel( this.Model.ChsCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.ChsCdDoc=this. ChsCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private ChsCdDocViewModel _chsCdDoc;
        [DisplayName("Types de document")]
        public virtual ChsCdDocViewModel ChsCdDoc
        {
            get
            {
                return this._chsCdDoc;
            }
            set
            {
                this._chsCdDoc = value;
                RaisePropertyChange("ChsCdDoc");
            }
        }
        
        public virtual ObservableCollection<ChsContactViewModel> ChsContacts { get; set; }
        
        public virtual ObservableCollection<ChsClsDocViewModel> ChsClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant document(cpt)")]
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
        private String _ref;
        [DisplayName("Référence (fichier)")]
        public String Ref
        {
            get
            {
                return this._ref;
            }
            set
            {
                this._ref = value;
                RaisePropertyChange("Ref");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("Identifiant document(cpt) : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Ref"] != null)
                {
                    errors.Add("Référence (fichier) : "+this["Ref"]);
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
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Ref"))
                {
                }
                return null;
            }
        }
    }
}
