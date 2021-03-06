using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_GMS",Schema="GMS")]
    public partial class GmsEvt : ModelBase
    {
        private GmsCdEvt _gmsCdEvt;
        public virtual GmsCdEvt GmsCdEvt 
        {
            get
            {
                return this._gmsCdEvt;
                
            }
            set
            {
                this._gmsCdEvt = value;
                this.CdEvtGmsType = this._gmsCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_GMS_ID_PK",Order=0)]
        public Int64 GmsCdEvtIdPk {get;set;}
        
        private GmsDsc _gmsDsc;
        public virtual GmsDsc GmsDsc 
        {
            get
            {
                return this._gmsDsc;
                
            }
            set
            {
                this._gmsDsc = value;
                this.DscGmsNumGms = this._gmsDsc.NumGms;
            }
        }
        
        [Required()]
        [Column("DSC_GMS_ID_PK",Order=1)]
        public Int64 GmsDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_GMS__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtGmsType { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
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
