using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ENTETE_OA",Schema="OA")]
    public partial class OaEntete : ModelBase
    {
        public virtual OaCdEntete OaCdEntete {get;set;}
        
        [Required()]
        [Column("CD_ENTETE_OA_ID_PK",Order=0)]
        public Int64 OaCdEnteteIdPk {get;set;}
        
        public virtual OaVst OaVst {get;set;}
        
        [Required()]
        [Column("VST_OA_ID_PK",Order=1)]
        public Int64 OaVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant Entête")]
        [Column("CD_ENTETE_OA__ID_ENTETE",Order=5)]
        [Required()]
        public Int64 CdEnteteOaIdEntete { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=6)]
        [MaxLength(250)] 
        public String Valeur { get; set; }
        
    }
}
