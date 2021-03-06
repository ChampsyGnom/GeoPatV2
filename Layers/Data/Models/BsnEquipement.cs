using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EQUIPEMENT_BSN",Schema="BSN")]
    public partial class BsnEquipement : ModelBase
    {
        private BsnCdTypeqp _bsnCdTypeqp;
        public virtual BsnCdTypeqp BsnCdTypeqp 
        {
            get
            {
                return this._bsnCdTypeqp;
                
            }
            set
            {
                this._bsnCdTypeqp = value;
                this.CdFameqpBsnFam = this._bsnCdTypeqp.CdFameqpBsnFam;
                this.CdTypeqpBsnType = this._bsnCdTypeqp.Type;
            }
        }
        
        [Required()]
        [Column("CD_TYPEQP_BSN_ID_PK",Order=0)]
        public Int64 BsnCdTypeqpIdPk {get;set;}
        
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
        [Column("DSC_BSN_ID_PK",Order=1)]
        public Int64 BsnDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille EQP")]
        [Column("CD_FAMEQP_BSN__FAM",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdFameqpBsnFam { get; set; }
        
        [Description("Type EQP")]
        [Column("CD_TYPEQP_BSN__TYPE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String CdTypeqpBsnType { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identification")]
        [Column("POSITION",Order=6)]
        [Required()]
        [MaxLength(60)] 
        public String Position { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=7)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=8)]
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
    }
}
