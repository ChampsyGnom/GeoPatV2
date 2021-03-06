using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PON_DS",Schema="DS")]
    public partial class DsPon : ModelBase
    {
        public virtual ICollection<DsPonParam> DsPonParams { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("PON_DS__CODE")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("PON_DS__LIBELLE")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(200)] 
        public String Libelle { get; set; }
        
        [Description("PON_DS__AGR")]
        [Column("AGR",Order=3)]
        [MaxLength(15)] 
        public String Agr { get; set; }
        
    }
}
