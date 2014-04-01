using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPrtViewModel : ViewModelBase<GmsPrt>
    {
        public GmsPrtViewModel(GmsPrt model) : base(model)
        {
            this.GmsSprts = new  ObservableCollection<GmsSprtViewModel>();
            
        }
        public override void Read()
        {
            this.GmsGrp=new GmsGrpViewModel( this.Model.GmsGrp);
            this.IdPrt=this.Model.IdPrt;
            this.Libp=this.Model.Libp;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.GmsGrp=this. GmsGrp.Model;
            this.Model.IdPrt=this.IdPrt;
            this.Model.Libp=this.Libp;
            this.Model.Ordre=this.Ordre;
        }
        private GmsGrpViewModel _gmsGrp;
        [DisplayName("Groupe")]
        public virtual GmsGrpViewModel GmsGrp
        {
            get
            {
                return this._gmsGrp;
            }
            set
            {
                this._gmsGrp = value;
                RaisePropertyChange("GmsGrp");
            }
        }
        
        public virtual ObservableCollection<GmsSprtViewModel> GmsSprts { get; set; }
        
        private Int64 _idPrt;
        [DisplayName("Identifiant Partie")]
        public Int64 IdPrt
        {
            get
            {
                return this._idPrt;
            }
            set
            {
                this._idPrt = value;
                RaisePropertyChange("IdPrt");
            }
        }
        
        private String _libp;
        [DisplayName("Partie")]
        public String Libp
        {
            get
            {
                return this._libp;
            }
            set
            {
                this._libp = value;
                RaisePropertyChange("Libp");
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
