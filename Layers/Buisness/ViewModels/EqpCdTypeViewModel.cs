using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdTypeViewModel : ViewModelBase<EqpCdType>
    {
        public EqpCdTypeViewModel(EqpCdType model) : base(model)
        {
            this.EqpTravauxs = new  ObservableCollection<EqpTravauxViewModel>();
            
            this.EqpPrevisions = new  ObservableCollection<EqpPrevisionViewModel>();
            
            this.EqpEvts = new  ObservableCollection<EqpEvtViewModel>();
            
        }
        public override void Read()
        {
            this.TypeEquip=this.Model.TypeEquip;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.TypeEquip=this.TypeEquip;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<EqpTravauxViewModel> EqpTravauxs { get; set; }
        
        public virtual ObservableCollection<EqpPrevisionViewModel> EqpPrevisions { get; set; }
        
        public virtual ObservableCollection<EqpEvtViewModel> EqpEvts { get; set; }
        
        private String _typeEquip;
        [DisplayName("Type d'équipement")]
        public String TypeEquip
        {
            get
            {
                return this._typeEquip;
            }
            set
            {
                this._typeEquip = value;
                RaisePropertyChange("TypeEquip");
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
                if (this["TypeEquip"] != null)
                {
                    errors.Add("Type d'équipement : "+this["TypeEquip"]);
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
                if (columnName.Equals("TypeEquip"))
                {
                    if (String.IsNullOrEmpty(this.TypeEquip))
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
