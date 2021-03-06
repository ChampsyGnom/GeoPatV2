using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnEltInspViewModel : ViewModelBase<BsnEltInsp>
    {
        public BsnEltInspViewModel(BsnEltInsp model) : base(model)
        {
            this.BsnPhotoEltInsps = new  ObservableCollection<BsnPhotoEltInspViewModel>();
            
        }
        public override void Read()
        {
            this.BsnElt=new BsnEltViewModel( this.Model.BsnElt);
            this.BsnInsp=new BsnInspViewModel( this.Model.BsnInsp);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.BsnElt=this. BsnElt.Model;
            this.Model.BsnInsp=this. BsnInsp.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private BsnEltViewModel _bsnElt;
        [DisplayName("Elément")]
        public virtual BsnEltViewModel BsnElt
        {
            get
            {
                return this._bsnElt;
            }
            set
            {
                this._bsnElt = value;
                RaisePropertyChange("BsnElt");
            }
        }
        
        private BsnInspViewModel _bsnInsp;
        [DisplayName("Inspection")]
        public virtual BsnInspViewModel BsnInsp
        {
            get
            {
                return this._bsnInsp;
            }
            set
            {
                this._bsnInsp = value;
                RaisePropertyChange("BsnInsp");
            }
        }
        
        public virtual ObservableCollection<BsnPhotoEltInspViewModel> BsnPhotoEltInsps { get; set; }
        
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
