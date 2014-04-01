using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotSprtViewModel : ViewModelBase
    {
        public GotSprt Model {get; set;}
        public GotSprtViewModel(GotSprt model)
        {
            this.GotElts = new  ObservableCollection<GotEltViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotPrt=new GotPrtViewModel( this.Model.GotPrt);
            this.IdSprt=this.Model.IdSprt;
            this.Libs=this.Model.Libs;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.GotPrt=this. GotPrt.Model;
            this.Model.IdSprt=this.IdSprt;
            this.Model.Libs=this.Libs;
            this.Model.Ordre=this.Ordre;
        }
        private GotPrtViewModel _gotPrt;
        [DisplayName("Partie")]
        public virtual GotPrtViewModel GotPrt
        {
            get
            {
                return this._gotPrt;
            }
            set
            {
                this._gotPrt = value;
                RaisePropertyChange("GotPrt");
            }
        }
        
        public virtual ObservableCollection<GotEltViewModel> GotElts { get; set; }
        
        private Int64 _idSprt;
        [DisplayName("Identifiant sous partie")]
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
        [DisplayName("N° Ordre")]
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
