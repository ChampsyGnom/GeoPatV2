using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaSprtViewModel : ViewModelBase
    {
        public OaSprt Model {get; set;}
        public OaSprtViewModel(OaSprt model)
        {
            this.OaElts = new  ObservableCollection<OaEltViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaPrt=new OaPrtViewModel( this.Model.OaPrt);
            this.IdSprt=this.Model.IdSprt;
            this.Libs=this.Model.Libs;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.OaPrt=this. OaPrt.Model;
            this.Model.IdSprt=this.IdSprt;
            this.Model.Libs=this.Libs;
            this.Model.Ordre=this.Ordre;
        }
        private OaPrtViewModel _oaPrt;
        [DisplayName("Partie")]
        public virtual OaPrtViewModel OaPrt
        {
            get
            {
                return this._oaPrt;
            }
            set
            {
                this._oaPrt = value;
                RaisePropertyChange("OaPrt");
            }
        }
        
        public virtual ObservableCollection<OaEltViewModel> OaElts { get; set; }
        
        private Int64 _idSprt;
        [DisplayName("Identifiant Sous Partie")]
        public Int64 IdSprt
        {
            get
            {
                return this._idSprt;
            }
            set
            {
                this._idSprt = value;
                RaisePropertyChange("IdSprt");
            }
        }
        
        private String _libs;
        [DisplayName("Sous Partie")]
        public String Libs
        {
            get
            {
                return this._libs;
            }
            set
            {
                this._libs = value;
                RaisePropertyChange("Libs");
            }
        }
        private Int64 _ordre;
        [DisplayName("No Ordre")]
        public Int64 Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
    }
}
