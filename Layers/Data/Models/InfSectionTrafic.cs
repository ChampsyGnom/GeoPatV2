using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SECTION_TRAFIC_INF",Schema="INF")]
    public partial class InfSectionTrafic : ModelBase
    {
        public virtual InfChaussee InfChaussee {get;set;}
        
        [Required()]
        [Column("CHAUSSEE_INF_ID_PK",Order=0)]
        public Int64 InfChausseeIdPk {get;set;}
        
        public virtual InfCdClassTraf InfCdClassTraf {get;set;}
        
        [Required()]
        [Column("CD_CLASS_TRAF_INF_ID_PK",Order=1)]
        public Int64 InfCdClassTrafIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Classe de trafic")]
        [Column("CD_CLASS_TRAF_INF__CODE",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String CdClassTrafInfCode { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=7)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Tenant")]
        [Column("TENANT",Order=8)]
        [MaxLength(60)] 
        public String Tenant { get; set; }
        
        [Description("Aboutissant")]
        [Column("ABOUTIS",Order=9)]
        [MaxLength(60)] 
        public String Aboutis { get; set; }
        
    }
}
