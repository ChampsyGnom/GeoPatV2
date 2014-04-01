using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BRETELLE_INF",Schema="INF")]
    public partial class InfBretelle : ModelBase
    {
        public virtual InfChaussee InfChaussee {get;set;}
        
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
        
        [Description("Pr raccordement")]
        [Column("ABS_DEB",Order=2)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=3)]
        [MaxLength(15)] 
        public String NumExploit { get; set; }
        
        [Description("N° Bretelle")]
        [Column("NUM_BRETELLE",Order=4)]
        [MaxLength(15)] 
        public String NumBretelle { get; set; }
        
        [Description("Nom Bretelle")]
        [Column("NOM_BRETELLE",Order=5)]
        [MaxLength(15)] 
        public String NomBretelle { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=6)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Type")]
        [Column("TYPE",Order=7)]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Extremité")]
        [Column("EXTREMITE",Order=8)]
        [MaxLength(60)] 
        public String Extremite { get; set; }
        
    }
}
