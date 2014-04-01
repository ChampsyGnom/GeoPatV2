using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CL_CAMP_CHS",Schema="CHS")]
    public partial class ChsClCamp : ModelBase
    {
        public virtual ChsDetailCamp ChsDetailCamp {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Ind_Code Agr")]
        [Column("CD__CD_MESURE_CHS__AGR",Order=0)]
        [Required()]
        [MaxLength(12)] 
        public String CdCdMesureChsAgr { get; set; }
        
        [Description("Code Agr")]
        [Column("CD_MESURE_CHS__AGR",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String CdMesureChsAgr { get; set; }
        
        [Description("Indicateur")]
        [Column("CD_INDIC_CHS__INDIC",Order=2)]
        [Required()]
        [MaxLength(12)] 
        public String CdIndicChsIndic { get; set; }
        
        [Description("Num Section")]
        [Column("CAMP_CHS__SECTION",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CampChsSection { get; set; }
        
        [Description("Année")]
        [Column("CAMP_CHS__ANNEE",Order=4)]
        [Required()]
        public Int64 CampChsAnnee { get; set; }
        
        [Description("Liaison")]
        [Column("CAMP_CHS__LIAISON",Order=5)]
        [Required()]
        [MaxLength(15)] 
        public String CampChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CAMP_CHS__SENS",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String CampChsSens { get; set; }
        
        [Description("Voie2")]
        [Column("CAMP_CHS__VOIE",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String CampChsVoie { get; set; }
        
        [Description("Année calculs")]
        [Column("ANNEE_CALC",Order=8)]
        [Required()]
        public Int64 AnneeCalc { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=9)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=10)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Voie")]
        [Column("VOIE",Order=11)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
    }
}
