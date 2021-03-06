using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdTypeSvViewModel : ViewModelBase<EqpCdTypeSv>
    {
        public EqpCdTypeSvViewModel(EqpCdTypeSv model) : base(model)
        {
            this.EqpCdStypeSvs = new  ObservableCollection<EqpCdStypeSvViewModel>();
            
        }
        public override void Read()
        {
            this.EqpCdFamSv=new EqpCdFamSvViewModel( this.Model.EqpCdFamSv);
            this.Type=this.Model.Type;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.EqpCdFamSv=this. EqpCdFamSv.Model;
            this.Model.Type=this.Type;
            this.Model.Libelle=this.Libelle;
        }
        private EqpCdFamSvViewModel _eqpCdFamSv;
        [DisplayName("Famille Equipement")]
        public virtual EqpCdFamSvViewModel EqpCdFamSv
        {
            get
            {
                return this._eqpCdFamSv;
            }
            set
            {
                this._eqpCdFamSv = value;
                RaisePropertyChange("EqpCdFamSv");
            }
        }
        
        public virtual ObservableCollection<EqpCdStypeSvViewModel> EqpCdStypeSvs { get; set; }
        
        private String _type;
        [DisplayName("Type")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Type : "+this["Type"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Type"))
                {
                    if (String.IsNullOrEmpty(this.Type))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                }
                return null;
            }
        }
    }
}
