using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotSprtVstViewModel : ViewModelBase
    {
        public GotSprtVst Model {get; set;}
        public GotSprtVstViewModel(GotSprtVst model)
        {
            this.GotPhotoSprtVsts = new  ObservableCollection<GotPhotoSprtVstViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotCdLigne=new GotCdLigneViewModel( this.Model.GotCdLigne);
            this.GotVst=new GotVstViewModel( this.Model.GotVst);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.GotCdLigne=this. GotCdLigne.Model;
            this.Model.GotVst=this. GotVst.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private GotCdLigneViewModel _gotCdLigne;
        [DisplayName("Ligne")]
        public virtual GotCdLigneViewModel GotCdLigne
        {
            get
            {
                return this._gotCdLigne;
            }
            set
            {
                this._gotCdLigne = value;
                RaisePropertyChange("GotCdLigne");
            }
        }
        
        private GotVstViewModel _gotVst;
        [DisplayName("Visite")]
        public virtual GotVstViewModel GotVst
        {
            get
            {
                return this._gotVst;
            }
            set
            {
                this._gotVst = value;
                RaisePropertyChange("GotVst");
            }
        }
        
        public virtual ObservableCollection<GotPhotoSprtVstViewModel> GotPhotoSprtVsts { get; set; }
        
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
