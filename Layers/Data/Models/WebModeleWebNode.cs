using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MODELE_WEB__NODE_WEB",Schema="WEB")]
    public partial class WebModeleWebNode : ModelBase
    {
        public virtual WebNode WebNode {get;set;}
        
        [Required()]
        [Column("NODE_WEB_ID_PK",Order=0)]
        public Int64 WebNodeIdPk {get;set;}
        
        public virtual WebModele WebModele {get;set;}
        
        [Required()]
        [Column("MODELE_WEB_ID_PK",Order=1)]
        public Int64 WebModeleIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du noeud")]
        [Column("NODE_WEB__ID",Order=3)]
        [Required()]
        public Int64 NodeWebId { get; set; }
        
        [Description("Identifiant du modèle")]
        [Column("MODELE_WEB__ID",Order=4)]
        [Required()]
        public Int64 ModeleWebId { get; set; }
        
        [Description("Ordre de la couche dans la carte")]
        [Column("MAP_ORDER",Order=5)]
        public Nullable<Int64> MapOrder { get; set; }
        
        [Description("Style du noeud pour le modèle")]
        [Column("STYLE_WEB__ID",Order=6)]
        public Nullable<Int64> StyleWebId { get; set; }
        
    }
}
