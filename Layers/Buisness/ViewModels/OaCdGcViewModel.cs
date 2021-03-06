using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdGcViewModel : ViewModelBase<OaCdGc>
    {
        public OaCdGcViewModel(OaCdGc model) : base(model)
        {
            this.OaEquipements = new  ObservableCollection<OaEquipementViewModel>();
            
        }
        public override void Read()
        {
            this.GardeCorps=this.Model.GardeCorps;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.GardeCorps=this.GardeCorps;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<OaEquipementViewModel> OaEquipements { get; set; }
        
        private String _gardeCorps;
        [DisplayName("Garde-corps")]
        public String GardeCorps
        {
            get
            {
                return this._gardeCorps;
            }
            set
            {
                this._gardeCorps = value;
                RaisePropertyChange("GardeCorps");
            }
        }
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie (mois)")]
        public Nullable<Int64> Garantie
        {
            get
            {
                return this._garantie;
            }
            set
            {
                this._garantie = value;
                RaisePropertyChange("Garantie");
            }
        }
        
        private Nullable<Int64> _dvt;
        [DisplayName("Durée de vie (mois)")]
        public Nullable<Int64> Dvt
        {
            get
            {
                return this._dvt;
            }
            set
            {
                this._dvt = value;
                RaisePropertyChange("Dvt");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["GardeCorps"] != null)
                {
                    errors.Add("Garde-corps : "+this["GardeCorps"]);
                }
                if (this["Garantie"] != null)
                {
                    errors.Add("Garantie (mois) : "+this["Garantie"]);
                }
                if (this["Dvt"] != null)
                {
                    errors.Add("Durée de vie (mois) : "+this["Dvt"]);
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
                if (columnName.Equals("GardeCorps"))
                {
                    if (String.IsNullOrEmpty(this.GardeCorps))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Garantie"))
                {
                }
                if (columnName.Equals("Dvt"))
                {
                }
                return null;
            }
        }
    }
}
