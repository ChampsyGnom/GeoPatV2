using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsFamCarViewModel : ViewModelBase<ChsFamCar>
    {
        public ChsFamCarViewModel(ChsFamCar model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsCdFamCar=new ChsCdFamCarViewModel( this.Model.ChsCdFamCar);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Progressive=this.Model.Progressive;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.ChsCdFamCar=this. ChsCdFamCar.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Progressive=this.Progressive;
            this.Model.Commentaire=this.Commentaire;
        }
        private ChsCdFamCarViewModel _chsCdFamCar;
        [DisplayName("Code famille")]
        public virtual ChsCdFamCarViewModel ChsCdFamCar
        {
            get
            {
                return this._chsCdFamCar;
            }
            set
            {
                this._chsCdFamCar = value;
                RaisePropertyChange("ChsCdFamCar");
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
        
        private Nullable<Boolean> _progressive;
        [DisplayName("Structure progressive")]
        public Nullable<Boolean> Progressive
        {
            get
            {
                return this._progressive;
            }
            set
            {
                this._progressive = value;
                RaisePropertyChange("Progressive");
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
                if (this["Progressive"] != null)
                {
                    errors.Add("Structure progressive : "+this["Progressive"]);
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
                if (columnName.Equals("Progressive"))
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
