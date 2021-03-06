using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaSprtVstViewModel : ViewModelBase<OaSprtVst>
    {
        public OaSprtVstViewModel(OaSprtVst model) : base(model)
        {
            this.OaPhotoSprtVsts = new  ObservableCollection<OaPhotoSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.OaVst=new OaVstViewModel( this.Model.OaVst);
            this.OaCdLigne=new OaCdLigneViewModel( this.Model.OaCdLigne);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.OaVst=this. OaVst.Model;
            this.Model.OaCdLigne=this. OaCdLigne.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private OaVstViewModel _oaVst;
        [DisplayName("Visite")]
        public virtual OaVstViewModel OaVst
        {
            get
            {
                return this._oaVst;
            }
            set
            {
                this._oaVst = value;
                RaisePropertyChange("OaVst");
            }
        }
        
        private OaCdLigneViewModel _oaCdLigne;
        [DisplayName("Ligne")]
        public virtual OaCdLigneViewModel OaCdLigne
        {
            get
            {
                return this._oaCdLigne;
            }
            set
            {
                this._oaCdLigne = value;
                RaisePropertyChange("OaCdLigne");
            }
        }
        
        public virtual ObservableCollection<OaPhotoSprtVstViewModel> OaPhotoSprtVsts { get; set; }
        
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
