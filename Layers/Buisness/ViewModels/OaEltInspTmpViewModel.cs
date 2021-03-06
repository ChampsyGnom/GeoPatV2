using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEltInspTmpViewModel : ViewModelBase<OaEltInspTmp>
    {
        public OaEltInspTmpViewModel(OaEltInspTmp model) : base(model)
        {
            this.OaPhotoEltInspTmps = new  ObservableCollection<OaPhotoEltInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OaInspTmp=new OaInspTmpViewModel( this.Model.OaInspTmp);
            this.OaElt=new OaEltViewModel( this.Model.OaElt);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.OaInspTmp=this. OaInspTmp.Model;
            this.Model.OaElt=this. OaElt.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private OaInspTmpViewModel _oaInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual OaInspTmpViewModel OaInspTmp
        {
            get
            {
                return this._oaInspTmp;
            }
            set
            {
                this._oaInspTmp = value;
                RaisePropertyChange("OaInspTmp");
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
        
        public virtual ObservableCollection<OaPhotoEltInspTmpViewModel> OaPhotoEltInspTmps { get; set; }
        
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
