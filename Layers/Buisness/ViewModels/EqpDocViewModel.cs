using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDocViewModel : ViewModelBase<EqpDoc>
    {
        public EqpDocViewModel(EqpDoc model) : base(model)
        {
            this.EqpContacts = new  ObservableCollection<EqpContactViewModel>();
            
            this.EqpClsDocs = new  ObservableCollection<EqpClsDocViewModel>();
            
        }
        public override void Read()
        {
            this.EqpCdDoc=new EqpCdDocViewModel( this.Model.EqpCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.EqpCdDoc=this. EqpCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private EqpCdDocViewModel _eqpCdDoc;
        [DisplayName("Type de document")]
        public virtual EqpCdDocViewModel EqpCdDoc
        {
            get
            {
                return this._eqpCdDoc;
            }
            set
            {
                this._eqpCdDoc = value;
                RaisePropertyChange("EqpCdDoc");
            }
        }
        
        public virtual ObservableCollection<EqpContactViewModel> EqpContacts { get; set; }
        
        public virtual ObservableCollection<EqpClsDocViewModel> EqpClsDocs { get; set; }
        
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
