using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoInspTmpViewModel : ViewModelBase<GotPhotoInspTmp>
    {
        public GotPhotoInspTmpViewModel(GotPhotoInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotInspTmp=new GotInspTmpViewModel( this.Model.GotInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotInspTmp=this. GotInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotInspTmpViewModel _gotInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual GotInspTmpViewModel GotInspTmp
        {
            get
            {
                return this._gotInspTmp;
            }
            set
            {
                this._gotInspTmp = value;
                RaisePropertyChange("GotInspTmp");
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
