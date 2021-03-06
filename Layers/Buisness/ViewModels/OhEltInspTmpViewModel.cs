using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhEltInspTmpViewModel : ViewModelBase<OhEltInspTmp>
    {
        public OhEltInspTmpViewModel(OhEltInspTmp model) : base(model)
        {
            this.OhPhotoEltInspTmps = new  ObservableCollection<OhPhotoEltInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OhInspTmp=new OhInspTmpViewModel( this.Model.OhInspTmp);
            this.OhElt=new OhEltViewModel( this.Model.OhElt);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.OhInspTmp=this. OhInspTmp.Model;
            this.Model.OhElt=this. OhElt.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private OhInspTmpViewModel _ohInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual OhInspTmpViewModel OhInspTmp
        {
            get
            {
                return this._ohInspTmp;
            }
            set
            {
                this._ohInspTmp = value;
                RaisePropertyChange("OhInspTmp");
            }
        }
        
        private OhEltViewModel _ohElt;
        [DisplayName("Elément")]
        public virtual OhEltViewModel OhElt
        {
            get
            {
                return this._ohElt;
            }
            set
            {
                this._ohElt = value;
                RaisePropertyChange("OhElt");
            }
        }
        
        public virtual ObservableCollection<OhPhotoEltInspTmpViewModel> OhPhotoEltInspTmps { get; set; }
        
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
