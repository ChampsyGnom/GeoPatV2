using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ROLE__DSC_BSN",Schema="BSN")]
    public partial class BsnCdRoleDsc : ModelBase
    {
        public virtual BsnDsc BsnDsc {get;set;}
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=0)]
        public Int64 BsnDscIdPk {get;set;}
        
        public virtual BsnCdRole BsnCdRole {get;set;}
        
        [Required()]
        [Column("CD_ROLE_BSN_ID_PK",Order=1)]
        public Int64 BsnCdRoleIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Rôle")]
        [Column("CD_ROLE_BSN__ROLE",Order=4)]
        [Required()]
        [MaxLength(25)] 
        public String CdRoleBsnRole { get; set; }
        
    }
}
