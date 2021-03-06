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
        private BsnDsc _bsnDsc;
        public virtual BsnDsc BsnDsc 
        {
            get
            {
                return this._bsnDsc;
                
            }
            set
            {
                this._bsnDsc = value;
                this.DscBsnNumBsn = this._bsnDsc.NumBsn;
            }
        }
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=0)]
        public Int64 BsnDscIdPk {get;set;}
        
        private BsnCdRole _bsnCdRole;
        public virtual BsnCdRole BsnCdRole 
        {
            get
            {
                return this._bsnCdRole;
                
            }
            set
            {
                this._bsnCdRole = value;
                this.CdRoleBsnRole = this._bsnCdRole.Role;
            }
        }
        
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
