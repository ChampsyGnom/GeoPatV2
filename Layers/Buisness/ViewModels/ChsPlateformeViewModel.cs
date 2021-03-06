using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsPlateformeViewModel : ViewModelBase<ChsPlateforme>
    {
        public ChsPlateformeViewModel(ChsPlateforme model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsCdPortance=new ChsCdPortanceViewModel( this.Model.ChsCdPortance);
            this.ChsCdMpa=new ChsCdMpaViewModel( this.Model.ChsCdMpa);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
        }
        public override void Write()
        {
            this.Model.ChsCdPortance=this. ChsCdPortance.Model;
            this.Model.ChsCdMpa=this. ChsCdMpa.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
        }
        private ChsCdPortanceViewModel _chsCdPortance;
        [DisplayName("Classe de Portance")]
        public virtual ChsCdPortanceViewModel ChsCdPortance
        {
            get
            {
                return this._chsCdPortance;
            }
            set
            {
                this._chsCdPortance = value;
                RaisePropertyChange("ChsCdPortance");
            }
        }
        
        private ChsCdMpaViewModel _chsCdMpa;
        [DisplayName("Valeur de portance")]
        public virtual ChsCdMpaViewModel ChsCdMpa
        {
            get
            {
                return this._chsCdMpa;
            }
            set
            {
                this._chsCdMpa = value;
                RaisePropertyChange("ChsCdMpa");
            }
        }
        
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
            }
        }
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
            }
        }
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Liaison"] != null)
                {
                    errors.Add("Liaison : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
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
                if (columnName.Equals("Liaison"))
                {
                    if (String.IsNullOrEmpty(this.Liaison))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Sens"))
                {
                    if (String.IsNullOrEmpty(this.Sens))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                return null;
            }
        }
    }
}
