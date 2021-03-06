using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_GOT",Schema="GOT")]
    public partial class GotEvt : ModelBase
    {
        private GotCdEvt _gotCdEvt;
        public virtual GotCdEvt GotCdEvt 
        {
            get
            {
                return this._gotCdEvt;
                
            }
            set
            {
                this._gotCdEvt = value;
                this.CdEvtGotType = this._gotCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_GOT_ID_PK",Order=0)]
        public Int64 GotCdEvtIdPk {get;set;}
        
        private GotDsc _gotDsc;
        public virtual GotDsc GotDsc 
        {
            get
            {
                return this._gotDsc;
                
            }
            set
            {
                this._gotDsc = value;
                this.DscGotNumGot = this._gotDsc.NumGot;
            }
        }
        
        [Required()]
        [Column("DSC_GOT_ID_PK",Order=1)]
        public Int64 GotDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_GOT__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtGotType { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
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
