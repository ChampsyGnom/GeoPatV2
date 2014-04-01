using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_TMP_GOT",Schema="GOT")]
    public partial class GotPhotoEltInspTmp : ModelBase
    {
        public virtual GotEltInspTmp GotEltInspTmp {get;set;}
        
        [Key]
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=0)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Key]
        [Description("Identifiant Partie")]
        [Column("PRT_GOT__ID_PRT",Order=1)]
        [Required()]
        public Int64 PrtGotIdPrt { get; set; }
        
        [Key]
        [Description("Identifiant sous partie")]
        [Column("SPRT_GOT__ID_SPRT",Order=2)]
        [Required()]
        public Int64 SprtGotIdSprt { get; set; }
        
        [Key]
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Key]
        [Description("N° Ouvrage")]
        [Column("DSC_TEMP_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGotNumGot { get; set; }
        
        [Key]
        [Description("Identifiant Elément")]
        [Column("ELT_GOT__ID_ELEM",Order=5)]
        [Required()]
        public Int64 EltGotIdElem { get; set; }
        
        [Key]
        [Description("Identifiant")]
        [Column("ID",Order=6)]
        [Required()]
        [MaxLength(50)] 
        public String Id { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=7)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
