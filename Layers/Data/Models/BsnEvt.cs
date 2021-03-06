using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_BSN",Schema="BSN")]
    public partial class BsnEvt : ModelBase
    {
        private BsnCdEvt _bsnCdEvt;
        public virtual BsnCdEvt BsnCdEvt 
        {
            get
            {
                return this._bsnCdEvt;
                
            }
            set
            {
                this._bsnCdEvt = value;
                this.CdEvtBsnType = this._bsnCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_BSN_ID_PK",Order=0)]
        public Int64 BsnCdEvtIdPk {get;set;}
        
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
        [Description("Type événement")]
        [Column("CD_EVT_BSN__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtBsnType { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=5)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=6)]
        public Nullable<DateTime> DateTrt { get; set; }
        
        [Description("Observation")]
        [Column("OBSV",Order=7)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
    }
}
