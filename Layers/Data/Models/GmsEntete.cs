using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ENTETE_GMS",Schema="GMS")]
    public partial class GmsEntete : ModelBase
    {
        public virtual GmsCdEntete GmsCdEntete {get;set;}
        
        [Required()]
        [Column("CD_ENTETE_GMS_ID_PK",Order=0)]
        public Int64 GmsCdEnteteIdPk {get;set;}
        
        public virtual GmsVst GmsVst {get;set;}
        
        [Required()]
        [Column("VST_GMS_ID_PK",Order=1)]
        public Int64 GmsVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Identifiant Entête")]
        [Column("CD_ENTETE_GMS__ID_ENTETE",Order=5)]
        [Required()]
        public Int64 CdEnteteGmsIdEntete { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=6)]
        [MaxLength(250)] 
        public String Valeur { get; set; }
        
    }
}
