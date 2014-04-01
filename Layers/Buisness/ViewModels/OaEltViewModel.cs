using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEltViewModel : ViewModelBase
    {
        public OaElt Model {get; set;}
        public OaEltViewModel(OaElt model)
        {
            this.OaEltInsps = new  ObservableCollection<OaEltInspViewModel>();
            
            this.OaEltInspTmps = new  ObservableCollection<OaEltInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaSprt=new OaSprtViewModel( this.Model.OaSprt);
            this.IdElem=this.Model.IdElem;
            this.Libe=this.Model.Libe;
            this.Ordre=this.Model.Ordre;
            this.Aide=this.Model.Aide;
            this.Indice1=this.Model.Indice1;
            this.Indice2=this.Model.Indice2;
            this.Indice3=this.Model.Indice3;
        }
        public override void Write()
        {
            this.Model.OaSprt=this. OaSprt.Model;
            this.Model.IdElem=this.IdElem;
            this.Model.Libe=this.Libe;
            this.Model.Ordre=this.Ordre;
            this.Model.Aide=this.Aide;
            this.Model.Indice1=this.Indice1;
            this.Model.Indice2=this.Indice2;
            this.Model.Indice3=this.Indice3;
        }
        private OaSprtViewModel _oaSprt;
        [DisplayName("Sous partie")]
        public virtual OaSprtViewModel OaSprt
        {
            get
            {
                return this._oaSprt;
            }
            set
            {
                this._oaSprt = value;
                RaisePropertyChange("OaSprt");
            }
        }
        
        public virtual ObservableCollection<OaEltInspViewModel> OaEltInsps { get; set; }
        
        public virtual ObservableCollection<OaEltInspTmpViewModel> OaEltInspTmps { get; set; }
        
        private Int64 _idElem;
        [DisplayName("Identifiant élément")]
        public Int64 IdElem
        {
            get
            {
                return this._idElem;
            }
            set
            {
                this._idElem = value;
                RaisePropertyChange("IdElem");
            }
        }
        
        private String _libe;
        [DisplayName("Elément")]
        public String Libe
        {
            get
            {
                return this._libe;
            }
            set
            {
                this._libe = value;
                RaisePropertyChange("Libe");
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
        
        private String _aide;
        [DisplayName("Aide à la saisie")]
        public String Aide
        {
            get
            {
                return this._aide;
            }
            set
            {
                this._aide = value;
                RaisePropertyChange("Aide");
            }
        }
        private String _indice1;
        [DisplayName("Indice1")]
        public String Indice1
        {
            get
            {
                return this._indice1;
            }
            set
            {
                this._indice1 = value;
                RaisePropertyChange("Indice1");
            }
        }
        private String _indice2;
        [DisplayName("Indice2")]
        public String Indice2
        {
            get
            {
                return this._indice2;
            }
            set
            {
                this._indice2 = value;
                RaisePropertyChange("Indice2");
            }
        }
        private String _indice3;
        [DisplayName("Indice3")]
        public String Indice3
        {
            get
            {
                return this._indice3;
            }
            set
            {
                this._indice3 = value;
                RaisePropertyChange("Indice3");
            }
        }
    }
}
