using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TR_DEC_INF",Schema="INF")]
    public partial class InfTrDec : ModelBase
    {
        public virtual InfChaussee InfChaussee {get;set;}
        
        public virtual InfCdDec InfCdDec {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=0)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Code famille")]
        [Column("FAM_DEC_INF__FAM_DEC",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String FamDecInfFamDec { get; set; }
        
        [Description("Code decoupage")]
        [Column("CD_DEC_INF__CD_DEC",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDecInfCdDec { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=4)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=5)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
    }
}
