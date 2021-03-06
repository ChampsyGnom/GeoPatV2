using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoSiZoneViewModel : ViewModelBase<MapinfoSiZone>
    {
        public MapinfoSiZoneViewModel(MapinfoSiZone model) : base(model)
        {
            this.MapinfoSiStyleValeurs = new  ObservableCollection<MapinfoSiStyleValeurViewModel>();
            
        }
        public override void Read()
        {
            this.MapinfoSiModel=new MapinfoSiModelViewModel( this.Model.MapinfoSiModel);
            this.NomZone=this.Model.NomZone;
            this.SchemaZone=this.Model.SchemaZone;
            this.TableZone=this.Model.TableZone;
            this.FieldZone=this.Model.FieldZone;
            this.TypeZone=this.Model.TypeZone;
            this.Position=this.Model.Position;
            this.Hauteur=this.Model.Hauteur;
            this.Valeur=this.Model.Valeur;
            this.ValeurSub=this.Model.ValeurSub;
            this.AnneeMesure=this.Model.AnneeMesure;
            this.PositionEtiquette=this.Model.PositionEtiquette;
            this.ChampEtiquette=this.Model.ChampEtiquette;
            this.Withcote=this.Model.Withcote;
        }
        public override void Write()
        {
            this.Model.MapinfoSiModel=this. MapinfoSiModel.Model;
            this.Model.NomZone=this.NomZone;
            this.Model.SchemaZone=this.SchemaZone;
            this.Model.TableZone=this.TableZone;
            this.Model.FieldZone=this.FieldZone;
            this.Model.TypeZone=this.TypeZone;
            this.Model.Position=this.Position;
            this.Model.Hauteur=this.Hauteur;
            this.Model.Valeur=this.Valeur;
            this.Model.ValeurSub=this.ValeurSub;
            this.Model.AnneeMesure=this.AnneeMesure;
            this.Model.PositionEtiquette=this.PositionEtiquette;
            this.Model.ChampEtiquette=this.ChampEtiquette;
            this.Model.Withcote=this.Withcote;
        }
        private MapinfoSiModelViewModel _mapinfoSiModel;
        [DisplayName("SI_MODEL")]
        public virtual MapinfoSiModelViewModel MapinfoSiModel
        {
            get
            {
                return this._mapinfoSiModel;
            }
            set
            {
                this._mapinfoSiModel = value;
                RaisePropertyChange("MapinfoSiModel");
            }
        }
        
        public virtual ObservableCollection<MapinfoSiStyleValeurViewModel> MapinfoSiStyleValeurs { get; set; }
        
        private String _nomZone;
        [DisplayName("Si Zone  Nom Zone")]
        public String NomZone
        {
            get
            {
                return this._nomZone;
            }
            set
            {
                this._nomZone = value;
                RaisePropertyChange("NomZone");
            }
        }
        private String _schemaZone;
        [DisplayName("Si Zone  Schema Zone")]
        public String SchemaZone
        {
            get
            {
                return this._schemaZone;
            }
            set
            {
                this._schemaZone = value;
                RaisePropertyChange("SchemaZone");
            }
        }
        private String _tableZone;
        [DisplayName("Si Zone  Table Zone")]
        public String TableZone
        {
            get
            {
                return this._tableZone;
            }
            set
            {
                this._tableZone = value;
                RaisePropertyChange("TableZone");
            }
        }
        private String _fieldZone;
        [DisplayName("Si Zone  Field Zone")]
        public String FieldZone
        {
            get
            {
                return this._fieldZone;
            }
            set
            {
                this._fieldZone = value;
                RaisePropertyChange("FieldZone");
            }
        }
        private String _typeZone;
        [DisplayName("Si Zone  Type Zone")]
        public String TypeZone
        {
            get
            {
                return this._typeZone;
            }
            set
            {
                this._typeZone = value;
                RaisePropertyChange("TypeZone");
            }
        }
        private Nullable<Int64> _position;
        [DisplayName("Si Zone  Position")]
        public Nullable<Int64> Position
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
        
        private Nullable<Int64> _hauteur;
        [DisplayName("Si Zone  Hauteur")]
        public Nullable<Int64> Hauteur
        {
            get
            {
                return this._hauteur;
            }
            set
            {
                this._hauteur = value;
                RaisePropertyChange("Hauteur");
            }
        }
        
        private String _valeur;
        [DisplayName("Si Zone  Valeur")]
        public String Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        private String _valeurSub;
        [DisplayName("Si Zone  Valeur Sub")]
        public String ValeurSub
        {
            get
            {
                return this._valeurSub;
            }
            set
            {
                this._valeurSub = value;
                RaisePropertyChange("ValeurSub");
            }
        }
        private Nullable<Int64> _anneeMesure;
        [DisplayName("Si Zone  Annee Mesure")]
        public Nullable<Int64> AnneeMesure
        {
            get
            {
                return this._anneeMesure;
            }
            set
            {
                this._anneeMesure = value;
                RaisePropertyChange("AnneeMesure");
            }
        }
        
        private String _positionEtiquette;
        [DisplayName("Si Zone  Position Etiquette")]
        public String PositionEtiquette
        {
            get
            {
                return this._positionEtiquette;
            }
            set
            {
                this._positionEtiquette = value;
                RaisePropertyChange("PositionEtiquette");
            }
        }
        private String _champEtiquette;
        [DisplayName("Si Zone  Champ Etiquette")]
        public String ChampEtiquette
        {
            get
            {
                return this._champEtiquette;
            }
            set
            {
                this._champEtiquette = value;
                RaisePropertyChange("ChampEtiquette");
            }
        }
        private Nullable<Int64> _withcote;
        [DisplayName("Si Zone  WithCote")]
        public Nullable<Int64> Withcote
        {
            get
            {
                return this._withcote;
            }
            set
            {
                this._withcote = value;
                RaisePropertyChange("Withcote");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["NomZone"] != null)
                {
                    errors.Add("Si Zone  Nom Zone : "+this["NomZone"]);
                }
                if (this["SchemaZone"] != null)
                {
                    errors.Add("Si Zone  Schema Zone : "+this["SchemaZone"]);
                }
                if (this["TableZone"] != null)
                {
                    errors.Add("Si Zone  Table Zone : "+this["TableZone"]);
                }
                if (this["FieldZone"] != null)
                {
                    errors.Add("Si Zone  Field Zone : "+this["FieldZone"]);
                }
                if (this["TypeZone"] != null)
                {
                    errors.Add("Si Zone  Type Zone : "+this["TypeZone"]);
                }
                if (this["Position"] != null)
                {
                    errors.Add("Si Zone  Position : "+this["Position"]);
                }
                if (this["Hauteur"] != null)
                {
                    errors.Add("Si Zone  Hauteur : "+this["Hauteur"]);
                }
                if (this["Valeur"] != null)
                {
                    errors.Add("Si Zone  Valeur : "+this["Valeur"]);
                }
                if (this["ValeurSub"] != null)
                {
                    errors.Add("Si Zone  Valeur Sub : "+this["ValeurSub"]);
                }
                if (this["AnneeMesure"] != null)
                {
                    errors.Add("Si Zone  Annee Mesure : "+this["AnneeMesure"]);
                }
                if (this["PositionEtiquette"] != null)
                {
                    errors.Add("Si Zone  Position Etiquette : "+this["PositionEtiquette"]);
                }
                if (this["ChampEtiquette"] != null)
                {
                    errors.Add("Si Zone  Champ Etiquette : "+this["ChampEtiquette"]);
                }
                if (this["Withcote"] != null)
                {
                    errors.Add("Si Zone  WithCote : "+this["Withcote"]);
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
                if (columnName.Equals("NomZone"))
                {
                    if (String.IsNullOrEmpty(this.NomZone))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("SchemaZone"))
                {
                }
                if (columnName.Equals("TableZone"))
                {
                }
                if (columnName.Equals("FieldZone"))
                {
                }
                if (columnName.Equals("TypeZone"))
                {
                }
                if (columnName.Equals("Position"))
                {
                }
                if (columnName.Equals("Hauteur"))
                {
                }
                if (columnName.Equals("Valeur"))
                {
                }
                if (columnName.Equals("ValeurSub"))
                {
                }
                if (columnName.Equals("AnneeMesure"))
                {
                }
                if (columnName.Equals("PositionEtiquette"))
                {
                }
                if (columnName.Equals("ChampEtiquette"))
                {
                }
                if (columnName.Equals("Withcote"))
                {
                }
                return null;
            }
        }
    }
}
