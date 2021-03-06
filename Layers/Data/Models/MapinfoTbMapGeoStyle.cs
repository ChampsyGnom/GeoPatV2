using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MAP_GEO_STYLE",Schema="MAPINFO")]
    public partial class MapinfoTbMapGeoStyle : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Map")]
        [Column("MAP",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Map { get; set; }
        
        [Description("UserName")]
        [Column("USERNAME",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String Username { get; set; }
        
        [Description("Représentation")]
        [Column("REPRESENTATION",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Representation { get; set; }
        
        [Description("Couleur")]
        [Column("COLOR",Order=4)]
        [Required()]
        public Int64 Color { get; set; }
        
        [Description("Largeur")]
        [Column("WIDTH",Order=5)]
        [Required()]
        public Int64 Width { get; set; }
        
        [Description("Police")]
        [Column("FONT",Order=6)]
        [MaxLength(50)] 
        public String Font { get; set; }
        
        [Description("Code ASCII")]
        [Column("ASCII",Order=7)]
        public Nullable<Int64> Ascii { get; set; }
        
        [Description("Style")]
        [Column("STYLE",Order=8)]
        public Nullable<Int64> Style { get; set; }
        
        [Description("Interleaved")]
        [Column("INTERLEAVED",Order=9)]
        public Nullable<Int64> Interleaved { get; set; }
        
        [Description("BorderColor")]
        [Column("BORDERCOLOR",Order=10)]
        public Nullable<Int64> Bordercolor { get; set; }
        
        [Description("BorderStyle")]
        [Column("BORDERSTYLE",Order=11)]
        public Nullable<Int64> Borderstyle { get; set; }
        
        [Description("RegionBackground")]
        [Column("REGIONBACKGROUND",Order=12)]
        public Nullable<Int64> Regionbackground { get; set; }
        
    }
}
