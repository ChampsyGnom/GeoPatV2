using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_CALCUL_FIS_DS",Schema="DS")]
    public partial class DsSimCalculFis : ModelBase
    {
        public virtual DsSimCalculTrafic DsSimCalculTrafic {get;set;}
        
        public virtual DsSimFis DsSimFis {get;set;}
        
        public virtual ICollection<DsSimResult> DsSimResults { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_CALCUL_TRAFIC_DS__ID")]
        [Column("SIM_CALCUL_TRAFIC_DS__ID",Order=0)]
        [Required()]
        public Int64 SimCalculTraficDsId { get; set; }
        
        [Description("SIM_FIS_DS__ID")]
        [Column("SIM_FIS_DS__ID",Order=1)]
        [Required()]
        public Int64 SimFisDsId { get; set; }
        
    }
}
