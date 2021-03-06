using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ROLE_BSN",Schema="BSN")]
    public partial class BsnCdRole : ModelBase
    {
        public virtual ICollection<BsnCdRoleDsc> BsnCdRoleDscs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Rôle")]
        [Column("ROLE",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Role { get; set; }
        
    }
}
