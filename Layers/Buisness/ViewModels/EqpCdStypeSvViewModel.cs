using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdStypeSvViewModel : ViewModelBase<EqpCdStypeSv>
    {
        public EqpCdStypeSvViewModel(EqpCdStypeSv model) : base(model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
        }
        public override void Read()
        {
            this.EqpCdTypeSv=new EqpCdTypeSvViewModel( this.Model.EqpCdTypeSv);
            this.SType=this.Model.SType;
            this.Libelle=this.Model.Libelle;
            this.NOrdre=this.Model.NOrdre;
        }
        public override void Write()
        {
            this.Model.EqpCdTypeSv=this. EqpCdTypeSv.Model;
            this.Model.SType=this.SType;
            this.Model.Libelle=this.Libelle;
            this.Model.NOrdre=this.NOrdre;
        }
        private EqpCdTypeSvViewModel _eqpCdTypeSv;
        [DisplayName("Type Ouvrage")]
        public virtual EqpCdTypeSvViewModel EqpCdTypeSv
        {
            get
            {
                return this._eqpCdTypeSv;
            }
            set
            {
                this._eqpCdTypeSv = value;
                RaisePropertyChange("EqpCdTypeSv");
            }
        }
        
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        private String _sType;
        [DisplayName("Sous type")]
        public String SType
        {
            get
            {
                return this._sType;
            }
            set
            {
                this._sType = value;
                RaisePropertyChange("SType");
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
        private Int64 _nOrdre;
        [DisplayName("Num Ordre")]
        public Int64 NOrdre
        {
            get
            {
                return this._nOrdre;
            }
            set
            {
                this._nOrdre = value;
                RaisePropertyChange("NOrdre");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["SType"] != null)
                {
                    errors.Add("Sous type : "+this["SType"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["NOrdre"] != null)
                {
                    errors.Add("Num Ordre : "+this["NOrdre"]);
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
                if (columnName.Equals("SType"))
                {
                    if (String.IsNullOrEmpty(this.SType))
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
                if (columnName.Equals("NOrdre"))
                {
                }
                return null;
            }
        }
    }
}
