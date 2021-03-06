using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotEltInspTmpViewModel : ViewModelBase<GotEltInspTmp>
    {
        public GotEltInspTmpViewModel(GotEltInspTmp model) : base(model)
        {
            this.GotPhotoEltInspTmps = new  ObservableCollection<GotPhotoEltInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.GotInspTmp=new GotInspTmpViewModel( this.Model.GotInspTmp);
            this.GotElt=new GotEltViewModel( this.Model.GotElt);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.GotInspTmp=this. GotInspTmp.Model;
            this.Model.GotElt=this. GotElt.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private GotInspTmpViewModel _gotInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual GotInspTmpViewModel GotInspTmp
        {
            get
            {
                return this._gotInspTmp;
            }
            set
            {
                this._gotInspTmp = value;
                RaisePropertyChange("GotInspTmp");
            }
        }
        
        private GotEltViewModel _gotElt;
        [DisplayName("Elément")]
        public virtual GotEltViewModel GotElt
        {
            get
            {
                return this._gotElt;
            }
            set
            {
                this._gotElt = value;
                RaisePropertyChange("GotElt");
            }
        }
        
        public virtual ObservableCollection<GotPhotoEltInspTmpViewModel> GotPhotoEltInspTmps { get; set; }
        
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
