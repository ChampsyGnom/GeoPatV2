using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebStyleRuleViewModel : ViewModelBase<WebStyleRule>
    {
        public WebStyleRuleViewModel(WebStyleRule model) : base(model)
        {
        }
        public override void Read()
        {
            this.WebStyle=new WebStyleViewModel( this.Model.WebStyle);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.IncrementRange=this.Model.IncrementRange;
            this.IsActive=this.Model.IsActive;
            this.MaxRange=this.Model.MaxRange;
            this.MinRange=this.Model.MinRange;
            this.MaxValue=this.Model.MaxValue;
            this.MinValue=this.Model.MinValue;
            this.UniqueValue=this.Model.UniqueValue;
            this.PointSize=this.Model.PointSize;
            this.PointStrokeColor=this.Model.PointStrokeColor;
            this.PointStrokeOpacity=this.Model.PointStrokeOpacity;
            this.PointStrokeStyle=this.Model.PointStrokeStyle;
            this.PointStrokeSize=this.Model.PointStrokeSize;
            this.PointFillColor=this.Model.PointFillColor;
            this.PointFillOpacity=this.Model.PointFillOpacity;
            this.PointSymbol=this.Model.PointSymbol;
            this.PointImage=this.Model.PointImage;
            this.LineSize=this.Model.LineSize;
            this.LineStrokeColor=this.Model.LineStrokeColor;
            this.LineStrokeOpacity=this.Model.LineStrokeOpacity;
            this.LineStrokeStyle=this.Model.LineStrokeStyle;
            this.PolyStrokeColor=this.Model.PolyStrokeColor;
            this.PolyStrokeOpacity=this.Model.PolyStrokeOpacity;
            this.PolyStrokeStyle=this.Model.PolyStrokeStyle;
            this.PolyStrokeSize=this.Model.PolyStrokeSize;
            this.PolyFillColor=this.Model.PolyFillColor;
            this.PolyFillOpacity=this.Model.PolyFillOpacity;
        }
        public override void Write()
        {
            this.Model.WebStyle=this. WebStyle.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.IncrementRange=this.IncrementRange;
            this.Model.IsActive=this.IsActive;
            this.Model.MaxRange=this.MaxRange;
            this.Model.MinRange=this.MinRange;
            this.Model.MaxValue=this.MaxValue;
            this.Model.MinValue=this.MinValue;
            this.Model.UniqueValue=this.UniqueValue;
            this.Model.PointSize=this.PointSize;
            this.Model.PointStrokeColor=this.PointStrokeColor;
            this.Model.PointStrokeOpacity=this.PointStrokeOpacity;
            this.Model.PointStrokeStyle=this.PointStrokeStyle;
            this.Model.PointStrokeSize=this.PointStrokeSize;
            this.Model.PointFillColor=this.PointFillColor;
            this.Model.PointFillOpacity=this.PointFillOpacity;
            this.Model.PointSymbol=this.PointSymbol;
            this.Model.PointImage=this.PointImage;
            this.Model.LineSize=this.LineSize;
            this.Model.LineStrokeColor=this.LineStrokeColor;
            this.Model.LineStrokeOpacity=this.LineStrokeOpacity;
            this.Model.LineStrokeStyle=this.LineStrokeStyle;
            this.Model.PolyStrokeColor=this.PolyStrokeColor;
            this.Model.PolyStrokeOpacity=this.PolyStrokeOpacity;
            this.Model.PolyStrokeStyle=this.PolyStrokeStyle;
            this.Model.PolyStrokeSize=this.PolyStrokeSize;
            this.Model.PolyFillColor=this.PolyFillColor;
            this.Model.PolyFillOpacity=this.PolyFillOpacity;
        }
        private WebStyleViewModel _webStyle;
        [DisplayName("Style d'un couche")]
        public virtual WebStyleViewModel WebStyle
        {
            get
            {
                return this._webStyle;
            }
            set
            {
                this._webStyle = value;
                RaisePropertyChange("WebStyle");
            }
        }
        
        private Int64 _id;
        [DisplayName("Identifiant de la règle")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                RaisePropertyChange("Id");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé de la règle")]
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
        private Nullable<Double> _incrementRange;
        [DisplayName("Increment des classe de valeurs")]
        public Nullable<Double> IncrementRange
        {
            get
            {
                return this._incrementRange;
            }
            set
            {
                this._incrementRange = value;
                RaisePropertyChange("IncrementRange");
            }
        }
        
        private Boolean _isActive;
        [DisplayName("La règle de style est active")]
        public Boolean IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
                RaisePropertyChange("IsActive");
            }
        }
        
        private Nullable<Double> _maxRange;
        [DisplayName("Borne maximale des classe de valeurs")]
        public Nullable<Double> MaxRange
        {
            get
            {
                return this._maxRange;
            }
            set
            {
                this._maxRange = value;
                RaisePropertyChange("MaxRange");
            }
        }
        
        private Nullable<Double> _minRange;
        [DisplayName("Borne minimal des classe de valeurs")]
        public Nullable<Double> MinRange
        {
            get
            {
                return this._minRange;
            }
            set
            {
                this._minRange = value;
                RaisePropertyChange("MinRange");
            }
        }
        
        private Nullable<Double> _maxValue;
        [DisplayName("Valeur maximal de la classe de valeur")]
        public Nullable<Double> MaxValue
        {
            get
            {
                return this._maxValue;
            }
            set
            {
                this._maxValue = value;
                RaisePropertyChange("MaxValue");
            }
        }
        
        private Nullable<Double> _minValue;
        [DisplayName("Valeur minimal de la classe de valeur")]
        public Nullable<Double> MinValue
        {
            get
            {
                return this._minValue;
            }
            set
            {
                this._minValue = value;
                RaisePropertyChange("MinValue");
            }
        }
        
        private String _uniqueValue;
        [DisplayName("Valeur unique de la règle")]
        public String UniqueValue
        {
            get
            {
                return this._uniqueValue;
            }
            set
            {
                this._uniqueValue = value;
                RaisePropertyChange("UniqueValue");
            }
        }
        private Int64 _pointSize;
        [DisplayName("Taille des points")]
        public Int64 PointSize
        {
            get
            {
                return this._pointSize;
            }
            set
            {
                this._pointSize = value;
                RaisePropertyChange("PointSize");
            }
        }
        
        private String _pointStrokeColor;
        [DisplayName("Couleur du contour des points")]
        public String PointStrokeColor
        {
            get
            {
                return this._pointStrokeColor;
            }
            set
            {
                this._pointStrokeColor = value;
                RaisePropertyChange("PointStrokeColor");
            }
        }
        private Int64 _pointStrokeOpacity;
        [DisplayName("Opacité du contour des points")]
        public Int64 PointStrokeOpacity
        {
            get
            {
                return this._pointStrokeOpacity;
            }
            set
            {
                this._pointStrokeOpacity = value;
                RaisePropertyChange("PointStrokeOpacity");
            }
        }
        
        private String _pointStrokeStyle;
        [DisplayName("Style du contour des points")]
        public String PointStrokeStyle
        {
            get
            {
                return this._pointStrokeStyle;
            }
            set
            {
                this._pointStrokeStyle = value;
                RaisePropertyChange("PointStrokeStyle");
            }
        }
        private Int64 _pointStrokeSize;
        [DisplayName("Taille du contour des points")]
        public Int64 PointStrokeSize
        {
            get
            {
                return this._pointStrokeSize;
            }
            set
            {
                this._pointStrokeSize = value;
                RaisePropertyChange("PointStrokeSize");
            }
        }
        
        private String _pointFillColor;
        [DisplayName("Couleur de remplissage des points")]
        public String PointFillColor
        {
            get
            {
                return this._pointFillColor;
            }
            set
            {
                this._pointFillColor = value;
                RaisePropertyChange("PointFillColor");
            }
        }
        private Int64 _pointFillOpacity;
        [DisplayName("Opacité du remplissage des points")]
        public Int64 PointFillOpacity
        {
            get
            {
                return this._pointFillOpacity;
            }
            set
            {
                this._pointFillOpacity = value;
                RaisePropertyChange("PointFillOpacity");
            }
        }
        
        private String _pointSymbol;
        [DisplayName("Symbole des points")]
        public String PointSymbol
        {
            get
            {
                return this._pointSymbol;
            }
            set
            {
                this._pointSymbol = value;
                RaisePropertyChange("PointSymbol");
            }
        }
        private String _pointImage;
        [DisplayName("Image des points")]
        public String PointImage
        {
            get
            {
                return this._pointImage;
            }
            set
            {
                this._pointImage = value;
                RaisePropertyChange("PointImage");
            }
        }
        private Int64 _lineSize;
        [DisplayName("Taille des lignes")]
        public Int64 LineSize
        {
            get
            {
                return this._lineSize;
            }
            set
            {
                this._lineSize = value;
                RaisePropertyChange("LineSize");
            }
        }
        
        private String _lineStrokeColor;
        [DisplayName("Couleur des lignes")]
        public String LineStrokeColor
        {
            get
            {
                return this._lineStrokeColor;
            }
            set
            {
                this._lineStrokeColor = value;
                RaisePropertyChange("LineStrokeColor");
            }
        }
        private Int64 _lineStrokeOpacity;
        [DisplayName("Opacité des lignes")]
        public Int64 LineStrokeOpacity
        {
            get
            {
                return this._lineStrokeOpacity;
            }
            set
            {
                this._lineStrokeOpacity = value;
                RaisePropertyChange("LineStrokeOpacity");
            }
        }
        
        private String _lineStrokeStyle;
        [DisplayName("Style des lignes")]
        public String LineStrokeStyle
        {
            get
            {
                return this._lineStrokeStyle;
            }
            set
            {
                this._lineStrokeStyle = value;
                RaisePropertyChange("LineStrokeStyle");
            }
        }
        private String _polyStrokeColor;
        [DisplayName("Couleur des contours des polygones")]
        public String PolyStrokeColor
        {
            get
            {
                return this._polyStrokeColor;
            }
            set
            {
                this._polyStrokeColor = value;
                RaisePropertyChange("PolyStrokeColor");
            }
        }
        private Int64 _polyStrokeOpacity;
        [DisplayName("Opacité des contours des polygones")]
        public Int64 PolyStrokeOpacity
        {
            get
            {
                return this._polyStrokeOpacity;
            }
            set
            {
                this._polyStrokeOpacity = value;
                RaisePropertyChange("PolyStrokeOpacity");
            }
        }
        
        private String _polyStrokeStyle;
        [DisplayName("Style du contours des polygones")]
        public String PolyStrokeStyle
        {
            get
            {
                return this._polyStrokeStyle;
            }
            set
            {
                this._polyStrokeStyle = value;
                RaisePropertyChange("PolyStrokeStyle");
            }
        }
        private Int64 _polyStrokeSize;
        [DisplayName("Taille du contour des polygones")]
        public Int64 PolyStrokeSize
        {
            get
            {
                return this._polyStrokeSize;
            }
            set
            {
                this._polyStrokeSize = value;
                RaisePropertyChange("PolyStrokeSize");
            }
        }
        
        private String _polyFillColor;
        [DisplayName("Couleur de remplissage des polygones")]
        public String PolyFillColor
        {
            get
            {
                return this._polyFillColor;
            }
            set
            {
                this._polyFillColor = value;
                RaisePropertyChange("PolyFillColor");
            }
        }
        private Int64 _polyFillOpacity;
        [DisplayName("Opacité du remplissage des polygones")]
        public Int64 PolyFillOpacity
        {
            get
            {
                return this._polyFillOpacity;
            }
            set
            {
                this._polyFillOpacity = value;
                RaisePropertyChange("PolyFillOpacity");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("Identifiant de la règle : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé de la règle : "+this["Libelle"]);
                }
                if (this["IncrementRange"] != null)
                {
                    errors.Add("Increment des classe de valeurs : "+this["IncrementRange"]);
                }
                if (this["IsActive"] != null)
                {
                    errors.Add("La règle de style est active : "+this["IsActive"]);
                }
                if (this["MaxRange"] != null)
                {
                    errors.Add("Borne maximale des classe de valeurs : "+this["MaxRange"]);
                }
                if (this["MinRange"] != null)
                {
                    errors.Add("Borne minimal des classe de valeurs : "+this["MinRange"]);
                }
                if (this["MaxValue"] != null)
                {
                    errors.Add("Valeur maximal de la classe de valeur : "+this["MaxValue"]);
                }
                if (this["MinValue"] != null)
                {
                    errors.Add("Valeur minimal de la classe de valeur : "+this["MinValue"]);
                }
                if (this["UniqueValue"] != null)
                {
                    errors.Add("Valeur unique de la règle : "+this["UniqueValue"]);
                }
                if (this["PointSize"] != null)
                {
                    errors.Add("Taille des points : "+this["PointSize"]);
                }
                if (this["PointStrokeColor"] != null)
                {
                    errors.Add("Couleur du contour des points : "+this["PointStrokeColor"]);
                }
                if (this["PointStrokeOpacity"] != null)
                {
                    errors.Add("Opacité du contour des points : "+this["PointStrokeOpacity"]);
                }
                if (this["PointStrokeStyle"] != null)
                {
                    errors.Add("Style du contour des points : "+this["PointStrokeStyle"]);
                }
                if (this["PointStrokeSize"] != null)
                {
                    errors.Add("Taille du contour des points : "+this["PointStrokeSize"]);
                }
                if (this["PointFillColor"] != null)
                {
                    errors.Add("Couleur de remplissage des points : "+this["PointFillColor"]);
                }
                if (this["PointFillOpacity"] != null)
                {
                    errors.Add("Opacité du remplissage des points : "+this["PointFillOpacity"]);
                }
                if (this["PointSymbol"] != null)
                {
                    errors.Add("Symbole des points : "+this["PointSymbol"]);
                }
                if (this["PointImage"] != null)
                {
                    errors.Add("Image des points : "+this["PointImage"]);
                }
                if (this["LineSize"] != null)
                {
                    errors.Add("Taille des lignes : "+this["LineSize"]);
                }
                if (this["LineStrokeColor"] != null)
                {
                    errors.Add("Couleur des lignes : "+this["LineStrokeColor"]);
                }
                if (this["LineStrokeOpacity"] != null)
                {
                    errors.Add("Opacité des lignes : "+this["LineStrokeOpacity"]);
                }
                if (this["LineStrokeStyle"] != null)
                {
                    errors.Add("Style des lignes : "+this["LineStrokeStyle"]);
                }
                if (this["PolyStrokeColor"] != null)
                {
                    errors.Add("Couleur des contours des polygones : "+this["PolyStrokeColor"]);
                }
                if (this["PolyStrokeOpacity"] != null)
                {
                    errors.Add("Opacité des contours des polygones : "+this["PolyStrokeOpacity"]);
                }
                if (this["PolyStrokeStyle"] != null)
                {
                    errors.Add("Style du contours des polygones : "+this["PolyStrokeStyle"]);
                }
                if (this["PolyStrokeSize"] != null)
                {
                    errors.Add("Taille du contour des polygones : "+this["PolyStrokeSize"]);
                }
                if (this["PolyFillColor"] != null)
                {
                    errors.Add("Couleur de remplissage des polygones : "+this["PolyFillColor"]);
                }
                if (this["PolyFillOpacity"] != null)
                {
                    errors.Add("Opacité du remplissage des polygones : "+this["PolyFillOpacity"]);
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
                if (columnName.Equals("Id"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("IncrementRange"))
                {
                }
                if (columnName.Equals("IsActive"))
                {
                }
                if (columnName.Equals("MaxRange"))
                {
                }
                if (columnName.Equals("MinRange"))
                {
                }
                if (columnName.Equals("MaxValue"))
                {
                }
                if (columnName.Equals("MinValue"))
                {
                }
                if (columnName.Equals("UniqueValue"))
                {
                }
                if (columnName.Equals("PointSize"))
                {
                }
                if (columnName.Equals("PointStrokeColor"))
                {
                    if (String.IsNullOrEmpty(this.PointStrokeColor))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PointStrokeOpacity"))
                {
                }
                if (columnName.Equals("PointStrokeStyle"))
                {
                    if (String.IsNullOrEmpty(this.PointStrokeStyle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PointStrokeSize"))
                {
                }
                if (columnName.Equals("PointFillColor"))
                {
                    if (String.IsNullOrEmpty(this.PointFillColor))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PointFillOpacity"))
                {
                }
                if (columnName.Equals("PointSymbol"))
                {
                    if (String.IsNullOrEmpty(this.PointSymbol))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PointImage"))
                {
                    if (String.IsNullOrEmpty(this.PointImage))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("LineSize"))
                {
                }
                if (columnName.Equals("LineStrokeColor"))
                {
                    if (String.IsNullOrEmpty(this.LineStrokeColor))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("LineStrokeOpacity"))
                {
                }
                if (columnName.Equals("LineStrokeStyle"))
                {
                    if (String.IsNullOrEmpty(this.LineStrokeStyle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PolyStrokeColor"))
                {
                    if (String.IsNullOrEmpty(this.PolyStrokeColor))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PolyStrokeOpacity"))
                {
                }
                if (columnName.Equals("PolyStrokeStyle"))
                {
                    if (String.IsNullOrEmpty(this.PolyStrokeStyle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PolyStrokeSize"))
                {
                }
                if (columnName.Equals("PolyFillColor"))
                {
                    if (String.IsNullOrEmpty(this.PolyFillColor))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PolyFillOpacity"))
                {
                }
                return null;
            }
        }
    }
}
