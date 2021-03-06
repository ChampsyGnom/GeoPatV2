using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoInspTmpViewModel : ViewModelBase<BsnPhotoInspTmp>
    {
        public BsnPhotoInspTmpViewModel(BsnPhotoInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnInspTmp=new BsnInspTmpViewModel( this.Model.BsnInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnInspTmp=this. BsnInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnInspTmpViewModel _bsnInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual BsnInspTmpViewModel BsnInspTmp
        {
            get
            {
                return this._bsnInspTmp;
            }
            set
            {
                this._bsnInspTmp = value;
                RaisePropertyChange("BsnInspTmp");
            }
        }
        
        private String _id;
        [DisplayName("Identifiant")]
        public String Id
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
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("Identifiant : "+this["Id"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
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
                    if (String.IsNullOrEmpty(this.Id))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
