using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SI_STYLE_VALEUR",Schema="MAPINFO")]
    public partial class MapinfoSiStyleValeur : ModelBase
    {
        private MapinfoSiZone _mapinfoSiZone;
        public virtual MapinfoSiZone MapinfoSiZone 
        {
            get
            {
                return this._mapinfoSiZone;
                
            }
            set
            {
                this._mapinfoSiZone = value;
                this.SiModelNomModel = this._mapinfoSiZone.SiModelNomModel;
                this.SiZoneNomZone = this._mapinfoSiZone.NomZone;
            }
        }
        
        [Required()]
        [Column("SI_ZONE_ID_PK",Order=0)]
        public Int64 MapinfoSiZoneIdPk {get;set;}
        
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
        [Column("SI_ZONE__NOM_ZONE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String SiZoneNomZone { get; set; }
        
        [Description("Si Style Valeur  Valeur")]
        [Column("VALEUR",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String Valeur { get; set; }
        
        [Description("Si Style Valeur  Couleur")]
        [Column("COULEUR",Order=5)]
        [MaxLength(9)] 
        public String Couleur { get; set; }
        
        [Description("Si Style Valeur  Border")]
        [Column("BORDER",Order=6)]
        public Nullable<Int64> Border { get; set; }
        
        [Description("Si Style Valeur  Taille")]
        [Column("TAILLE",Order=7)]
        public Nullable<Int64> Taille { get; set; }
        
        [Description("Si Style Valeur  Representation")]
        [Column("REPRESENTATION",Order=8)]
        [MaxLength(20)] 
        public String Representation { get; set; }
        
        [Description("Si Style Valeur  Chemin")]
        [Column("CHEMIN",Order=9)]
        [MaxLength(1024)] 
        public String Chemin { get; set; }
        
        [Description("Si Style Valeur Font Name")]
        [Column("FONT_NAME",Order=10)]
        [MaxLength(50)] 
        public String FontName { get; set; }
        
        [Description("Si Style Valeur Font Char")]
        [Column("FONT_CHAR",Order=11)]
        public Nullable<Int64> FontChar { get; set; }
        
        [Description("Si Style Valeur  Opacity")]
        [Column("OPACITY",Order=12)]
        public Nullable<Double> Opacity { get; set; }
        
    }
}
