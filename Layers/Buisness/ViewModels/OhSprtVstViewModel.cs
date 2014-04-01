using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhSprtVstViewModel : ViewModelBase
    {
        public OhSprtVst Model {get; set;}
        public OhSprtVstViewModel(OhSprtVst model)
        {
            this.OhPhotoSprtVsts = new  ObservableCollection<OhPhotoSprtVstViewModel>();
            
            this.OhCdPrecoSprtVsts = new  ObservableCollection<OhCdPrecoSprtVstViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhVst=new OhVstViewModel( this.Model.OhVst);
            this.OhCdLigne=new OhCdLigneViewModel( this.Model.OhCdLigne);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.OhVst=this. OhVst.Model;
            this.Model.OhCdLigne=this. OhCdLigne.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private OhVstViewModel _ohVst;
        [DisplayName("Visite")]
        public virtual OhVstViewModel OhVst
        {
            get
            {
                return this._ohVst;
            }
            set
            {
                this._ohVst = value;
                RaisePropertyChange("OhVst");
            }
        }
        
        private OhCdLigneViewModel _ohCdLigne;
        [DisplayName("Ligne")]
        public virtual OhCdLigneViewModel OhCdLigne
        {
            get
            {
                return this._ohCdLigne;
            }
            set
            {
                this._ohCdLigne = value;
                RaisePropertyChange("OhCdLigne");
            }
        }
        
        public virtual ObservableCollection<OhPhotoSprtVstViewModel> OhPhotoSprtVsts { get; set; }
        
        public virtual ObservableCollection<OhCdPrecoSprtVstViewModel> OhCdPrecoSprtVsts { get; set; }
        
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
    }
}
