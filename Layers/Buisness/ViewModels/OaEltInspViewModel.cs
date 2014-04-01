using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEltInspViewModel : ViewModelBase
    {
        public OaEltInsp Model {get; set;}
        public OaEltInspViewModel(OaEltInsp model)
        {
            this.OaPhotoEltInsps = new  ObservableCollection<OaPhotoEltInspViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
