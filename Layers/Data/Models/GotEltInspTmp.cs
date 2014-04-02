using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_TMP_GOT",Schema="GOT")]
    public partial class GotEltInspTmp : ModelBase
    {
        public virtual GotInspTmp GotInspTmp {get;set;}
        
        [Required()]
        [Column("INSP_TMP_GOT_ID_PK",Order=0)]
        public Int64 GotInspTmpIdPk {get;set;}
        
        public virtual GotElt GotElt {get;set;}
        
        [Required()]
        [Column("ELT_GOT_ID_PK",Order=1)]
        public Int64 GotEltIdPk {get;set;}
        
        public virtual ICollection<GotPhotoEltInspTmp> GotPhotoEltInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_TEMP_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGotNumGot { get; set; }
        
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=5)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GOT__ID_PRT",Order=6)]
        [Required()]
        public Int64 PrtGotIdPrt { get; set; }
        
        [Description("Identifiant sous partie")]
        [Column("SPRT_GOT__ID_SPRT",Order=7)]
        [Required()]
        public Int64 SprtGotIdSprt { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ELT_GOT__ID_ELEM",Order=8)]
        [Required()]
        public Int64 EltGotIdElem { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=9)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=10)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
