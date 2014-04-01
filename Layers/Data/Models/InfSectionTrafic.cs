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
        
        public virtual InfCdClassTraf InfCdClassTraf {get;set;}
        
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
        
        [Description("Début")]
        [Column("ABS_DEB",Order=2)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Classe de trafic")]
        [Column("CD_CLASS_TRAF_INF__CODE",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String CdClassTrafInfCode { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=4)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Tenant")]
        [Column("TENANT",Order=5)]
        [MaxLength(60)] 
        public String Tenant { get; set; }
        
        [Description("Aboutissant")]
        [Column("ABOUTIS",Order=6)]
        [MaxLength(60)] 
        public String Aboutis { get; set; }
        
    }
}
