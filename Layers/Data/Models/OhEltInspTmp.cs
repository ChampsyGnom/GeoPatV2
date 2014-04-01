using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_TMP_OH",Schema="OH")]
    public partial class OhEltInspTmp : ModelBase
    {
        public virtual OhInspTmp OhInspTmp {get;set;}
        
        public virtual OhElt OhElt {get;set;}
        
        public virtual ICollection<OhPhotoEltInspTmp> OhPhotoEltInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_TEMP_OH__NUM_OH",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOhNumOh { get; set; }
        
        [Description("Identifiant Groupe")]
        [Column("GRP_OH__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOhIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OH__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtOhIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_OH__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtOhIdSprt { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_OH__ID_ELEM",Order=5)]
        [Required()]
        public Int64 EltOhIdElem { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=6)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observations")]
        [Column("OBS",Order=7)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
