using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TYPEQP_BSN",Schema="BSN")]
    public partial class BsnCdTypeqp : ModelBase
    {
        private BsnCdFameqp _bsnCdFameqp;
        public virtual BsnCdFameqp BsnCdFameqp 
        {
            get
            {
                return this._bsnCdFameqp;
                
            }
            set
            {
                this._bsnCdFameqp = value;
                this.CdFameqpBsnFam = this._bsnCdFameqp.Fam;
            }
        }
        
        [Required()]
        [Column("CD_FAMEQP_BSN_ID_PK",Order=0)]
        public Int64 BsnCdFameqpIdPk {get;set;}
        
        public virtual ICollection<BsnEquipement> BsnEquipements { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille EQP")]
        [Column("CD_FAMEQP_BSN__FAM",Order=2)]
        [Required()]
        [MaxLength(25)] 
        public String CdFameqpBsnFam { get; set; }
        
        [Description("Type EQP")]
        [Column("TYPE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Garantie (mois)")]
        [Column("GARANTIE",Order=4)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=5)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
