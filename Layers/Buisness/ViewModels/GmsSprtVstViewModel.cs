using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsSprtVstViewModel : ViewModelBase<GmsSprtVst>
    {
        public GmsSprtVstViewModel(GmsSprtVst model) : base(model)
        {
            this.GmsPhotoSprtVsts = new  ObservableCollection<GmsPhotoSprtVstViewModel>();
            
            this.GmsCdPrecoSprtVsts = new  ObservableCollection<GmsCdPrecoSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.GmsVst=new GmsVstViewModel( this.Model.GmsVst);
            this.GmsCdLigne=new GmsCdLigneViewModel( this.Model.GmsCdLigne);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.GmsVst=this. GmsVst.Model;
            this.Model.GmsCdLigne=this. GmsCdLigne.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private GmsVstViewModel _gmsVst;
        [DisplayName("Visite")]
        public virtual GmsVstViewModel GmsVst
        {
            get
            {
                return this._gmsVst;
            }
            set
            {
                this._gmsVst = value;
                RaisePropertyChange("GmsVst");
            }
        }
        
        private GmsCdLigneViewModel _gmsCdLigne;
        [DisplayName("Ligne")]
        public virtual GmsCdLigneViewModel GmsCdLigne
        {
            get
            {
                return this._gmsCdLigne;
            }
            set
            {
                this._gmsCdLigne = value;
                RaisePropertyChange("GmsCdLigne");
            }
        }
        
        public virtual ObservableCollection<GmsPhotoSprtVstViewModel> GmsPhotoSprtVsts { get; set; }
        
        public virtual ObservableCollection<GmsCdPrecoSprtVstViewModel> GmsCdPrecoSprtVsts { get; set; }
        
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
