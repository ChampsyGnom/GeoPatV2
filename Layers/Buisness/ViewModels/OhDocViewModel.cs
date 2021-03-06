using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhDocViewModel : ViewModelBase<OhDoc>
    {
        public OhDocViewModel(OhDoc model) : base(model)
        {
            this.OhContacts = new  ObservableCollection<OhContactViewModel>();
            
            this.OhClsDocs = new  ObservableCollection<OhClsDocViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdDoc=new OhCdDocViewModel( this.Model.OhCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.OhCdDoc=this. OhCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private OhCdDocViewModel _ohCdDoc;
        [DisplayName("Type de document")]
        public virtual OhCdDocViewModel OhCdDoc
        {
            get
            {
                return this._ohCdDoc;
            }
            set
            {
                this._ohCdDoc = value;
                RaisePropertyChange("OhCdDoc");
            }
        }
        
        public virtual ObservableCollection<OhContactViewModel> OhContacts { get; set; }
        
        public virtual ObservableCollection<OhClsDocViewModel> OhClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Id document")]
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
        [DisplayName("Réference (fichier)")]
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
                    errors.Add("Id document : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Ref"] != null)
                {
                    errors.Add("Réference (fichier) : "+this["Ref"]);
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
                    if (String.IsNullOrEmpty(this.Ref))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
