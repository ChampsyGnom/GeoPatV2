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
        
        public virtual OaVst OaVst {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant Entête")]
        [Column("CD_ENTETE_OA__ID_ENTETE",Order=2)]
        [Required()]
        public Int64 CdEnteteOaIdEntete { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=3)]
        [MaxLength(250)] 
        public String Valeur { get; set; }
        
    }
}
