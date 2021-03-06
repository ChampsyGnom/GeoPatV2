using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotSprtVstViewModel : ViewModelBase<GotSprtVst>
    {
        public GotSprtVstViewModel(GotSprtVst model) : base(model)
        {
            this.GotPhotoSprtVsts = new  ObservableCollection<GotPhotoSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.GotCdLigne=new GotCdLigneViewModel( this.Model.GotCdLigne);
            this.GotVst=new GotVstViewModel( this.Model.GotVst);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.GotCdLigne=this. GotCdLigne.Model;
            this.Model.GotVst=this. GotVst.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private GotCdLigneViewModel _gotCdLigne;
        [DisplayName("Ligne")]
        public virtual GotCdLigneViewModel GotCdLigne
        {
            get
            {
                return this._gotCdLigne;
            }
            set
            {
                this._gotCdLigne = value;
                RaisePropertyChange("GotCdLigne");
            }
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
        
        public virtual ObservableCollection<GotPhotoSprtVstViewModel> GotPhotoSprtVsts { get; set; }
        
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
