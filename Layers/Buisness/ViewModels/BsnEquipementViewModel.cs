using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnEquipementViewModel : ViewModelBase<BsnEquipement>
    {
        public BsnEquipementViewModel(BsnEquipement model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnCdTypeqp=new BsnCdTypeqpViewModel( this.Model.BsnCdTypeqp);
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.Position=this.Model.Position;
            this.DateMs=this.Model.DateMs;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnCdTypeqp=this. BsnCdTypeqp.Model;
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.Position=this.Position;
            this.Model.DateMs=this.DateMs;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnCdTypeqpViewModel _bsnCdTypeqp;
        [DisplayName("Type Equipement")]
        public virtual BsnCdTypeqpViewModel BsnCdTypeqp
        {
            get
            {
                return this._bsnCdTypeqp;
            }
            set
            {
                this._bsnCdTypeqp = value;
                RaisePropertyChange("BsnCdTypeqp");
            }
        }
        
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
            }
        }
        
        private String _position;
        [DisplayName("Identification")]
        public String Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
                RaisePropertyChange("Position");
            }
        }
        private Nullable<DateTime> _dateMs;
        [DisplayName("Date MS")]
        public Nullable<DateTime> DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Position"] != null)
                {
                    errors.Add("Identification : "+this["Position"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
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
                if (columnName.Equals("Position"))
                {
                    if (String.IsNullOrEmpty(this.Position))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
