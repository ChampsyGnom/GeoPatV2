using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdMarquageShViewModel : ViewModelBase<EqpCdMarquageSh>
    {
        public EqpCdMarquageShViewModel(EqpCdMarquageSh model) : base(model)
        {
            this.EqpDscShs = new  ObservableCollection<EqpDscShViewModel>();
            
        }
        public override void Read()
        {
            this.EqpCdModSh=new EqpCdModShViewModel( this.Model.EqpCdModSh);
            this.Marquage=this.Model.Marquage;
            this.Largeur=this.Model.Largeur;
        }
        public override void Write()
        {
            this.Model.EqpCdModSh=this. EqpCdModSh.Model;
            this.Model.Marquage=this.Marquage;
            this.Model.Largeur=this.Largeur;
        }
        private EqpCdModShViewModel _eqpCdModSh;
        [DisplayName("Type de modulation")]
        public virtual EqpCdModShViewModel EqpCdModSh
        {
            get
            {
                return this._eqpCdModSh;
            }
            set
            {
                this._eqpCdModSh = value;
                RaisePropertyChange("EqpCdModSh");
            }
        }
        
        public virtual ObservableCollection<EqpDscShViewModel> EqpDscShs { get; set; }
        
        private String _marquage;
        [DisplayName("Marquage")]
        public String Marquage
        {
            get
            {
                return this._marquage;
            }
            set
            {
                this._marquage = value;
                RaisePropertyChange("Marquage");
            }
        }
        private Nullable<Int64> _largeur;
        [DisplayName("Largeur (xU)")]
        public Nullable<Int64> Largeur
        {
            get
            {
                return this._largeur;
            }
            set
            {
                this._largeur = value;
                RaisePropertyChange("Largeur");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Marquage"] != null)
                {
                    errors.Add("Marquage : "+this["Marquage"]);
                }
                if (this["Largeur"] != null)
                {
                    errors.Add("Largeur (xU) : "+this["Largeur"]);
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
                if (columnName.Equals("Marquage"))
                {
                    if (String.IsNullOrEmpty(this.Marquage))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Largeur"))
                {
                }
                return null;
            }
        }
    }
}
