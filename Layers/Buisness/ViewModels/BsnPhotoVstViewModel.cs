using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoVstViewModel : ViewModelBase<BsnPhotoVst>
    {
        public BsnPhotoVstViewModel(BsnPhotoVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnVst=new BsnVstViewModel( this.Model.BsnVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnVst=this. BsnVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnVstViewModel _bsnVst;
        [DisplayName("Visite")]
        public virtual BsnVstViewModel BsnVst
        {
            get
            {
                return this._bsnVst;
            }
            set
            {
                this._bsnVst = value;
                RaisePropertyChange("BsnVst");
            }
        }
        
        private String _id;
        [DisplayName("photo vst BSN id")]
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
        [DisplayName("photo vst BSN commentaire")]
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
                    errors.Add("photo vst BSN id : "+this["Id"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("photo vst BSN commentaire : "+this["Commentaire"]);
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
