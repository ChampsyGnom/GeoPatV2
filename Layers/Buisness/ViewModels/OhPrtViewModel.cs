using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPrtViewModel : ViewModelBase<OhPrt>
    {
        public OhPrtViewModel(OhPrt model) : base(model)
        {
            this.OhSprts = new  ObservableCollection<OhSprtViewModel>();
            
        }
        public override void Read()
        {
            this.OhGrp=new OhGrpViewModel( this.Model.OhGrp);
            this.IdPrt=this.Model.IdPrt;
            this.Libp=this.Model.Libp;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.OhGrp=this. OhGrp.Model;
            this.Model.IdPrt=this.IdPrt;
            this.Model.Libp=this.Libp;
            this.Model.Ordre=this.Ordre;
        }
        private OhGrpViewModel _ohGrp;
        [DisplayName("Groupe")]
        public virtual OhGrpViewModel OhGrp
        {
            get
            {
                return this._ohGrp;
            }
            set
            {
                this._ohGrp = value;
                RaisePropertyChange("OhGrp");
            }
        }
        
        public virtual ObservableCollection<OhSprtViewModel> OhSprts { get; set; }
        
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
