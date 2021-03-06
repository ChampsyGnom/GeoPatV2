using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfWgsViewModel : ViewModelBase<InfWgs>
    {
        public InfWgsViewModel(InfWgs model) : base(model)
        {
        }
        public override void Read()
        {
            this.LineIndex=this.Model.LineIndex;
            this.LayerName=this.Model.LayerName;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.X2=this.Model.X2;
            this.Y2=this.Model.Y2;
        }
        public override void Write()
        {
            this.Model.LineIndex=this.LineIndex;
            this.Model.LayerName=this.LayerName;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.X2=this.X2;
            this.Model.Y2=this.Y2;
        }
        private Int64 _lineIndex;
        [DisplayName("Index ligne")]
        public Int64 LineIndex
        {
            get
            {
                return this._lineIndex;
            }
            set
            {
                this._lineIndex = value;
                RaisePropertyChange("LineIndex");
            }
        }
        
        private String _layerName;
        [DisplayName("Modèle")]
        public String LayerName
        {
            get
            {
                return this._layerName;
            }
            set
            {
                this._layerName = value;
                RaisePropertyChange("LayerName");
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
        
        private Double _x1;
        [DisplayName("X1")]
        public Double X1
        {
            get
            {
                return this._x1;
            }
            set
            {
                this._x1 = value;
                RaisePropertyChange("X1");
            }
        }
        
        private Double _y1;
        [DisplayName("Y1")]
        public Double Y1
        {
            get
            {
                return this._y1;
            }
            set
            {
                this._y1 = value;
                RaisePropertyChange("Y1");
            }
        }
        
        private Double _x2;
        [DisplayName("X2")]
        public Double X2
        {
            get
            {
                return this._x2;
            }
            set
            {
                this._x2 = value;
                RaisePropertyChange("X2");
            }
        }
        
        private Double _y2;
        [DisplayName("Y2")]
        public Double Y2
        {
            get
            {
                return this._y2;
            }
            set
            {
                this._y2 = value;
                RaisePropertyChange("Y2");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["LineIndex"] != null)
                {
                    errors.Add("Index ligne : "+this["LineIndex"]);
                }
                if (this["LayerName"] != null)
                {
                    errors.Add("Modèle : "+this["LayerName"]);
                }
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
                if (this["X1"] != null)
                {
                    errors.Add("X1 : "+this["X1"]);
                }
                if (this["Y1"] != null)
                {
                    errors.Add("Y1 : "+this["Y1"]);
                }
                if (this["X2"] != null)
                {
                    errors.Add("X2 : "+this["X2"]);
                }
                if (this["Y2"] != null)
                {
                    errors.Add("Y2 : "+this["Y2"]);
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
                if (columnName.Equals("LineIndex"))
                {
                }
                if (columnName.Equals("LayerName"))
                {
                    if (String.IsNullOrEmpty(this.LayerName))
                    {
                        return "valeur vide non autorisée";
                    }
                }
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
                if (columnName.Equals("X1"))
                {
                }
                if (columnName.Equals("Y1"))
                {
                }
                if (columnName.Equals("X2"))
                {
                }
                if (columnName.Equals("Y2"))
                {
                }
                return null;
            }
        }
    }
}
