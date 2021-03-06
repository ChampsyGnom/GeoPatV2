using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnSprtVstViewModel : ViewModelBase<BsnSprtVst>
    {
        public BsnSprtVstViewModel(BsnSprtVst model) : base(model)
        {
            this.BsnPhotoSprtVsts = new  ObservableCollection<BsnPhotoSprtVstViewModel>();
            
            this.BsnCdPrecoSprtVsts = new  ObservableCollection<BsnCdPrecoSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.BsnVst=new BsnVstViewModel( this.Model.BsnVst);
            this.BsnCdLigne=new BsnCdLigneViewModel( this.Model.BsnCdLigne);
            this.Indice=this.Model.Indice;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.BsnVst=this. BsnVst.Model;
            this.Model.BsnCdLigne=this. BsnCdLigne.Model;
            this.Model.Indice=this.Indice;
            this.Model.Obs=this.Obs;
        }
        private BsnVstViewModel _bsnVst;
        [DisplayName("Visite")]
        public virtual BsnVstViewModel BsnVst
        {
            get
            {
                return this._bsnVst;
            }
            set
            {
                this._bsnVst = value;
                RaisePropertyChange("BsnVst");
            }
        }
        
        private BsnCdLigneViewModel _bsnCdLigne;
        [DisplayName("Ligne")]
        public virtual BsnCdLigneViewModel BsnCdLigne
        {
            get
            {
                return this._bsnCdLigne;
            }
            set
            {
                this._bsnCdLigne = value;
                RaisePropertyChange("BsnCdLigne");
            }
        }
        
        public virtual ObservableCollection<BsnPhotoSprtVstViewModel> BsnPhotoSprtVsts { get; set; }
        
        public virtual ObservableCollection<BsnCdPrecoSprtVstViewModel> BsnCdPrecoSprtVsts { get; set; }
        
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
