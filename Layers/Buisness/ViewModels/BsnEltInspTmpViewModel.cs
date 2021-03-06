using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnEltInspTmpViewModel : ViewModelBase<BsnEltInspTmp>
    {
        public BsnEltInspTmpViewModel(BsnEltInspTmp model) : base(model)
        {
            this.BsnPhotoEltInspTmps = new  ObservableCollection<BsnPhotoEltInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.BsnInspTmp=new BsnInspTmpViewModel( this.Model.BsnInspTmp);
            this.BsnElt=new BsnEltViewModel( this.Model.BsnElt);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.BsnInspTmp=this. BsnInspTmp.Model;
            this.Model.BsnElt=this. BsnElt.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
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
        
        public virtual ObservableCollection<BsnPhotoEltInspTmpViewModel> BsnPhotoEltInspTmps { get; set; }
        
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
