using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ENTETE_GOT",Schema="GOT")]
    public partial class GotEntete : ModelBase
    {
        public virtual GotCdEntete GotCdEntete {get;set;}
        
        [Required()]
        [Column("CD_ENTETE_GOT_ID_PK",Order=0)]
        public Int64 GotCdEnteteIdPk {get;set;}
        
        public virtual GotVst GotVst {get;set;}
        
        [Required()]
        [Column("VST_GOT_ID_PK",Order=1)]
        public Int64 GotVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Identifiant Entête")]
        [Column("CD_ENTETE_GOT__ID_ENTETE",Order=5)]
        [Required()]
        public Int64 CdEnteteGotIdEntete { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=6)]
        [MaxLength(250)] 
        public String Valeur { get; set; }
        
    }
}
