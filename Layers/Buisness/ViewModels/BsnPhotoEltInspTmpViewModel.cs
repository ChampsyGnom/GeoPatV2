using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoEltInspTmpViewModel : ViewModelBase<BsnPhotoEltInspTmp>
    {
        public BsnPhotoEltInspTmpViewModel(BsnPhotoEltInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnEltInspTmp=new BsnEltInspTmpViewModel( this.Model.BsnEltInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnEltInspTmp=this. BsnEltInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnEltInspTmpViewModel _bsnEltInspTmp;
        [DisplayName("Détail Inspection temporaire")]
        public virtual BsnEltInspTmpViewModel BsnEltInspTmp
        {
            get
            {
                return this._bsnEltInspTmp;
            }
            set
            {
                this._bsnEltInspTmp = value;
                RaisePropertyChange("BsnEltInspTmp");
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
