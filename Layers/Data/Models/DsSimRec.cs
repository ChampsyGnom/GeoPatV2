using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SIM_REC_DS",Schema="DS")]
    public partial class DsSimRec : ModelBase
    {
        public virtual DsSimEtude DsSimEtude {get;set;}
        
        public virtual ICollection<DsSimCalculTrafic> DsSimCalculTrafics { get; set; }
        
        public virtual ICollection<DsSimRecValues> DsSimRecValuess { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SIM_REC_DS__ID")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("SIM_ETUDE_DS__ID")]
        [Column("SIM_ETUDE_DS__ID",Order=1)]
        [Required()]
        public Int64 SimEtudeDsId { get; set; }
        
        [Description("SIM_REC_DS__LIBELLE")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("SIM_REC_DS__COULEUR")]
        [Column("COULEUR",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String Couleur { get; set; }
        
        [Description("SIM_REC_DS__DURREE_SERVICE")]
        [Column("DURREE_SERVICE",Order=4)]
        [Required()]
        public Int64 DurreeService { get; set; }
        
    }
}
