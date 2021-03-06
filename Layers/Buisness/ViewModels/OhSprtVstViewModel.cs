using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhSprtVstViewModel : ViewModelBase<OhSprtVst>
    {
        public OhSprtVstViewModel(OhSprtVst model) : base(model)
        {
            this.OhPhotoSprtVsts = new  ObservableCollection<OhPhotoSprtVstViewModel>();
            
            this.OhCdPrecoSprtVsts = new  ObservableCollection<OhCdPrecoSprtVstViewModel>();
            
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
