using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_CHS",Schema="CHS")]
    public partial class ChsEvt : ModelBase
    {
        private ChsCdEvt _chsCdEvt;
        public virtual ChsCdEvt ChsCdEvt 
        {
            get
            {
                return this._chsCdEvt;
                
            }
            set
            {
                this._chsCdEvt = value;
                this.CdEvtChsType = this._chsCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_CHS_ID_PK",Order=0)]
        public Int64 ChsCdEvtIdPk {get;set;}
        
        private ChsCdPosit _chsCdPosit;
        public virtual ChsCdPosit ChsCdPosit 
        {
            get
            {
                return this._chsCdPosit;
                
            }
            set
            {
                this._chsCdPosit = value;
                this.CdPositChsPosit = this._chsCdPosit.Posit;
            }
        }
        
        [Column("CD_POSIT_CHS_ID_PK",Order=1)]
        public Nullable<Int64> ChsCdPositIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_CHS__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtChsType { get; set; }
        
        [Description("Identifiant Evénement")]
        [Column("ID_EVT",Order=4)]
        [Required()]
        public Int64 IdEvt { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_CHS__POSIT",Order=5)]
        [MaxLength(60)] 
        public String CdPositChsPosit { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=8)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=9)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=10)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Visite annuelle")]
        [Column("VSTA",Order=11)]
        public Nullable<int> VstaValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Vsta 
        {
            get
            {
                if (VstaValueInt.HasValue) return Convert.ToBoolean(VstaValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.VstaValueInt = Convert.ToInt32(value.Value);}
                else {this.VstaValueInt =null;}
            }
        }
        
        [Description("Observation")]
        [Column("OBSV",Order=12)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=13)]
        public Nullable<DateTime> DateTrt { get; set; }
        
    }
}
