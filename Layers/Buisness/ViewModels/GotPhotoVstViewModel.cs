using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoVstViewModel : ViewModelBase<GotPhotoVst>
    {
        public GotPhotoVstViewModel(GotPhotoVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotVst=new GotVstViewModel( this.Model.GotVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotVst=this. GotVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotVstViewModel _gotVst;
        [DisplayName("Visite")]
        public virtual GotVstViewModel GotVst
        {
            get
            {
                return this._gotVst;
            }
            set
            {
                this._gotVst = value;
                RaisePropertyChange("GotVst");
            }
        }
        
        private String _id;
        [DisplayName("Id photo vst")]
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
        [DisplayName("photo vst commentaire")]
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
                    errors.Add("Id photo vst : "+this["Id"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("photo vst commentaire : "+this["Commentaire"]);
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
