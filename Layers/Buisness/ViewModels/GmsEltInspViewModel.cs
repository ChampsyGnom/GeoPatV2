using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsEltInspViewModel : ViewModelBase<GmsEltInsp>
    {
        public GmsEltInspViewModel(GmsEltInsp model) : base(model)
        {
            this.GmsPhotoEltInsps = new  ObservableCollection<GmsPhotoEltInspViewModel>();
            
        }
        public override void Read()
        {
            this.GmsElt=new GmsEltViewModel( this.Model.GmsElt);
            this.GmsInsp=new GmsInspViewModel( this.Model.GmsInsp);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.GmsElt=this. GmsElt.Model;
            this.Model.GmsInsp=this. GmsInsp.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private GmsEltViewModel _gmsElt;
        [DisplayName("Elément")]
        public virtual GmsEltViewModel GmsElt
        {
            get
            {
                return this._gmsElt;
            }
            set
            {
                this._gmsElt = value;
                RaisePropertyChange("GmsElt");
            }
        }
        
        private GmsInspViewModel _gmsInsp;
        [DisplayName("Inspection")]
        public virtual GmsInspViewModel GmsInsp
        {
            get
            {
                return this._gmsInsp;
            }
            set
            {
                this._gmsInsp = value;
                RaisePropertyChange("GmsInsp");
            }
        }
        
        public virtual ObservableCollection<GmsPhotoEltInspViewModel> GmsPhotoEltInsps { get; set; }
        
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
        [DisplayName("Observation")]
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
                    errors.Add("Observation : "+this["Obs"]);
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
