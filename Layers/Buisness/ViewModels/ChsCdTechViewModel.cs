using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdTechViewModel : ViewModelBase<ChsCdTech>
    {
        public ChsCdTechViewModel(ChsCdTech model) : base(model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
            this.ChsSousCouches = new  ObservableCollection<ChsSousCoucheViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdFamTech=new ChsCdFamTechViewModel( this.Model.ChsCdFamTech);
            this.Technique=this.Model.Technique;
            this.Libelle=this.Model.Libelle;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.ChsCdFamTech=this. ChsCdFamTech.Model;
            this.Model.Technique=this.Technique;
            this.Model.Libelle=this.Libelle;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        private ChsCdFamTechViewModel _chsCdFamTech;
        [DisplayName("Famille de technique")]
        public virtual ChsCdFamTechViewModel ChsCdFamTech
        {
            get
            {
                return this._chsCdFamTech;
            }
            set
            {
                this._chsCdFamTech = value;
                RaisePropertyChange("ChsCdFamTech");
            }
        }
        
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
        public virtual ObservableCollection<ChsSousCoucheViewModel> ChsSousCouches { get; set; }
        
        private String _technique;
        [DisplayName("Technique")]
        public String Technique
        {
            get
            {
                return this._technique;
            }
            set
            {
                this._technique = value;
                RaisePropertyChange("Technique");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
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
                if (this["Technique"] != null)
                {
                    errors.Add("Technique : "+this["Technique"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Technique"))
                {
                    if (String.IsNullOrEmpty(this.Technique))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
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
