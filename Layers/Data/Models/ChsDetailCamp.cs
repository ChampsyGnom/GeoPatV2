using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DETAIL_CAMP_CHS",Schema="CHS")]
    public partial class ChsDetailCamp : ModelBase
    {
        public virtual ChsCdIndic ChsCdIndic {get;set;}
        
        [Required()]
        [Column("CD_INDIC_CHS_ID_PK",Order=0)]
        public Int64 ChsCdIndicIdPk {get;set;}
        
        public virtual ChsCamp ChsCamp {get;set;}
        
        [Required()]
        [Column("CAMP_CHS_ID_PK",Order=1)]
        public Int64 ChsCampIdPk {get;set;}
        
        public virtual ICollection<ChsMesure> ChsMesures { get; set; }
        
        public virtual ICollection<ChsAgrege> ChsAgreges { get; set; }
        
        public virtual ICollection<ChsZh> ChsZhs { get; set; }
        
        public virtual ICollection<ChsClCamp> ChsClCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Ind_Code Agr")]
        [Column("CD__CD_MESURE_CHS__AGR",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String CdCdMesureChsAgr { get; set; }
        
        [Description("Indicateur")]
        [Column("CD_INDIC_CHS__INDIC",Order=4)]
        [Required()]
        [MaxLength(12)] 
        public String CdIndicChsIndic { get; set; }
        
        [Description("Code Agr")]
        [Column("CD_MESURE_CHS__AGR",Order=5)]
        [Required()]
        [MaxLength(12)] 
        public String CdMesureChsAgr { get; set; }
        
        [Description("Num Section")]
        [Column("CAMP_CHS__SECTION",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String CampChsSection { get; set; }
        
        [Description("Année")]
        [Column("CAMP_CHS__ANNEE",Order=7)]
        [Required()]
        public Int64 CampChsAnnee { get; set; }
        
        [Description("Liaison")]
        [Column("CAMP_CHS__LIAISON",Order=8)]
        [Required()]
        [MaxLength(15)] 
        public String CampChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CAMP_CHS__SENS",Order=9)]
        [Required()]
        [MaxLength(6)] 
        public String CampChsSens { get; set; }
        
        [Description("Voie")]
        [Column("CAMP_CHS__VOIE",Order=10)]
        [Required()]
        [MaxLength(6)] 
        public String CampChsVoie { get; set; }
        
    }
}
