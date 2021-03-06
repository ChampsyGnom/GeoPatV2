using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_OA",Schema="OA")]
    public partial class OaEvt : ModelBase
    {
        private OaCdEvt _oaCdEvt;
        public virtual OaCdEvt OaCdEvt 
        {
            get
            {
                return this._oaCdEvt;
                
            }
            set
            {
                this._oaCdEvt = value;
                this.CdEvtOaType = this._oaCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_OA_ID_PK",Order=0)]
        public Int64 OaCdEvtIdPk {get;set;}
        
        private OaDsc _oaDsc;
        public virtual OaDsc OaDsc 
        {
            get
            {
                return this._oaDsc;
                
            }
            set
            {
                this._oaDsc = value;
                this.DscOaNumOa = this._oaDsc.NumOa;
            }
        }
        
        [Required()]
        [Column("DSC_OA_ID_PK",Order=1)]
        public Int64 OaDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_OA__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtOaType { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
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
