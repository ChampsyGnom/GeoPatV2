using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsEltViewModel : ViewModelBase
    {
        public GmsElt Model {get; set;}
        public GmsEltViewModel(GmsElt model)
        {
            this.GmsEltInsps = new  ObservableCollection<GmsEltInspViewModel>();
            
            this.GmsEltInspTmps = new  ObservableCollection<GmsEltInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsSprt=new GmsSprtViewModel( this.Model.GmsSprt);
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
            this.Model.GmsSprt=this. GmsSprt.Model;
            this.Model.IdElem=this.IdElem;
            this.Model.Libe=this.Libe;
            this.Model.Ordre=this.Ordre;
            this.Model.Aide=this.Aide;
            this.Model.Indice1=this.Indice1;
            this.Model.Indice2=this.Indice2;
            this.Model.Indice3=this.Indice3;
        }
        private GmsSprtViewModel _gmsSprt;
        [DisplayName("Sous partie")]
        public virtual GmsSprtViewModel GmsSprt
        {
            get
            {
                return this._gmsSprt;
            }
            set
            {
                this._gmsSprt = value;
                RaisePropertyChange("GmsSprt");
            }
        }
        
        public virtual ObservableCollection<GmsEltInspViewModel> GmsEltInsps { get; set; }
        
        public virtual ObservableCollection<GmsEltInspTmpViewModel> GmsEltInspTmps { get; set; }
        
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
