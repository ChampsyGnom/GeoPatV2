using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEltInspViewModel : ViewModelBase<OaEltInsp>
    {
        public OaEltInspViewModel(OaEltInsp model) : base(model)
        {
            this.OaPhotoEltInsps = new  ObservableCollection<OaPhotoEltInspViewModel>();
            
        }
        public override void Read()
        {
            this.OaInsp=new OaInspViewModel( this.Model.OaInsp);
            this.OaElt=new OaEltViewModel( this.Model.OaElt);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.OaInsp=this. OaInsp.Model;
            this.Model.OaElt=this. OaElt.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private OaInspViewModel _oaInsp;
        [DisplayName("Inspection")]
        public virtual OaInspViewModel OaInsp
        {
            get
            {
                return this._oaInsp;
            }
            set
            {
                this._oaInsp = value;
                RaisePropertyChange("OaInsp");
            }
        }
        
        private OaEltViewModel _oaElt;
        [DisplayName("Elément")]
        public virtual OaEltViewModel OaElt
        {
            get
            {
                return this._oaElt;
            }
            set
            {
                this._oaElt = value;
                RaisePropertyChange("OaElt");
            }
        }
        
        public virtual ObservableCollection<OaPhotoEltInspViewModel> OaPhotoEltInsps { get; set; }
        
        private Int64 _indice;
        [DisplayName("Indice")]
        public Int64 Indice
        {
            get
            {
                return this._indice;
            }
            set
            {
                this._indice = value;
                RaisePropertyChange("Indice");
            }
        }
        
        private String _obs;
        [DisplayName("Observations")]
        public String Obs
        {
            get
            {
                return this._obs;
            }
            set
            {
                this._obs = value;
                RaisePropertyChange("Obs");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Indice"] != null)
                {
                    errors.Add("Indice : "+this["Indice"]);
                }
                if (this["Obs"] != null)
                {
                    errors.Add("Observations : "+this["Obs"]);
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
                if (columnName.Equals("Indice"))
                {
                }
                if (columnName.Equals("Obs"))
                {
                }
                return null;
            }
        }
    }
}
