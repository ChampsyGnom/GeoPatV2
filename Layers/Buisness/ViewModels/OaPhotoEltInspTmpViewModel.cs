using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoEltInspTmpViewModel : ViewModelBase<OaPhotoEltInspTmp>
    {
        public OaPhotoEltInspTmpViewModel(OaPhotoEltInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaEltInspTmp=new OaEltInspTmpViewModel( this.Model.OaEltInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaEltInspTmp=this. OaEltInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaEltInspTmpViewModel _oaEltInspTmp;
        [DisplayName("Détail inspection temporaire")]
        public virtual OaEltInspTmpViewModel OaEltInspTmp
        {
            get
            {
                return this._oaEltInspTmp;
            }
            set
            {
                this._oaEltInspTmp = value;
                RaisePropertyChange("OaEltInspTmp");
            }
        }
        
        private String _id;
        [DisplayName("Identifiant de la photo")]
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
                    errors.Add("Identifiant de la photo : "+this["Id"]);
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
