using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_OH",Schema="OH")]
    public partial class OhEvt : ModelBase
    {
        private OhCdEvt _ohCdEvt;
        public virtual OhCdEvt OhCdEvt 
        {
            get
            {
                return this._ohCdEvt;
                
            }
            set
            {
                this._ohCdEvt = value;
                this.CdEvtOhType = this._ohCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_OH_ID_PK",Order=0)]
        public Int64 OhCdEvtIdPk {get;set;}
        
        private OhDsc _ohDsc;
        public virtual OhDsc OhDsc 
        {
            get
            {
                return this._ohDsc;
                
            }
            set
            {
                this._ohDsc = value;
                this.DscOhNumOh = this._ohDsc.NumOh;
            }
        }
        
        [Required()]
        [Column("DSC_OH_ID_PK",Order=1)]
        public Int64 OhDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_OH__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtOhType { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
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
