using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SI_ZONE",Schema="MAPINFO")]
    public partial class MapinfoSiZone : ModelBase
    {
        private MapinfoSiModel _mapinfoSiModel;
        public virtual MapinfoSiModel MapinfoSiModel 
        {
            get
            {
                return this._mapinfoSiModel;
                
            }
            set
            {
                this._mapinfoSiModel = value;
                this.SiModelNomModel = this._mapinfoSiModel.NomModel;
            }
        }
        
        [Required()]
        [Column("SI_MODEL_ID_PK",Order=0)]
        public Int64 MapinfoSiModelIdPk {get;set;}
        
        public virtual ICollection<MapinfoSiStyleValeur> MapinfoSiStyleValeurs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Si Model  Nom Model")]
        [Column("SI_MODEL__NOM_MODEL",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String SiModelNomModel { get; set; }
        
        [Description("Si Zone  Nom Zone")]
        [Column("NOM_ZONE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String NomZone { get; set; }
        
        [Description("Si Zone  Schema Zone")]
        [Column("SCHEMA_ZONE",Order=4)]
        [MaxLength(100)] 
        public String SchemaZone { get; set; }
        
        [Description("Si Zone  Table Zone")]
        [Column("TABLE_ZONE",Order=5)]
        [MaxLength(100)] 
        public String TableZone { get; set; }
        
        [Description("Si Zone  Field Zone")]
        [Column("FIELD_ZONE",Order=6)]
        [MaxLength(100)] 
        public String FieldZone { get; set; }
        
        [Description("Si Zone  Type Zone")]
        [Column("TYPE_ZONE",Order=7)]
        [MaxLength(25)] 
        public String TypeZone { get; set; }
        
        [Description("Si Zone  Position")]
        [Column("POSITION",Order=8)]
        public Nullable<Int64> Position { get; set; }
        
        [Description("Si Zone  Hauteur")]
        [Column("HAUTEUR",Order=9)]
        public Nullable<Int64> Hauteur { get; set; }
        
        [Description("Si Zone  Valeur")]
        [Column("VALEUR",Order=10)]
        [MaxLength(100)] 
        public String Valeur { get; set; }
        
        [Description("Si Zone  Valeur Sub")]
        [Column("VALEUR_SUB",Order=11)]
        [MaxLength(100)] 
        public String ValeurSub { get; set; }
        
        [Description("Si Zone  Annee Mesure")]
        [Column("ANNEE_MESURE",Order=12)]
        public Nullable<Int64> AnneeMesure { get; set; }
        
        [Description("Si Zone  Position Etiquette")]
        [Column("POSITION_ETIQUETTE",Order=13)]
        [MaxLength(20)] 
        public String PositionEtiquette { get; set; }
        
        [Description("Si Zone  Champ Etiquette")]
        [Column("CHAMP_ETIQUETTE",Order=14)]
        [MaxLength(50)] 
        public String ChampEtiquette { get; set; }
        
        [Description("Si Zone  WithCote")]
        [Column("WITHCOTE",Order=15)]
        public Nullable<Int64> Withcote { get; set; }
        
    }
}
