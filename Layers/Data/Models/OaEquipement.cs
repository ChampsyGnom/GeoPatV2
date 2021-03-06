using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EQUIPEMENT_OA",Schema="OA")]
    public partial class OaEquipement : ModelBase
    {
        private OaCdDpr _oaCdDpr;
        public virtual OaCdDpr OaCdDpr 
        {
            get
            {
                return this._oaCdDpr;
                
            }
            set
            {
                this._oaCdDpr = value;
                this.CdDprOaDpr = this._oaCdDpr.Dpr;
            }
        }
        
        [Column("CD_DPR_OA_ID_PK",Order=0)]
        public Nullable<Int64> OaCdDprIdPk {get;set;}
        
        private OaTablier _oaTablier;
        public virtual OaTablier OaTablier 
        {
            get
            {
                return this._oaTablier;
                
            }
            set
            {
                this._oaTablier = value;
                this.DscOaNumOa = this._oaTablier.DscOaNumOa;
                this.TablierOaNumTab = this._oaTablier.NumTab;
            }
        }
        
        [Required()]
        [Column("TABLIER_OA_ID_PK",Order=1)]
        public Int64 OaTablierIdPk {get;set;}
        
        private OaCdGc _oaCdGc;
        public virtual OaCdGc OaCdGc 
        {
            get
            {
                return this._oaCdGc;
                
            }
            set
            {
                this._oaCdGc = value;
                this.CdGcOaGardeCorps = this._oaCdGc.GardeCorps;
            }
        }
        
        [Column("CD_GC_OA_ID_PK",Order=2)]
        public Nullable<Int64> OaCdGcIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("N° Tablier")]
        [Column("TABLIER_OA__NUM_TAB",Order=5)]
        [Required()]
        public Int64 TablierOaNumTab { get; set; }
        
        [Description("Coté")]
        [Column("COTE",Order=6)]
        [Required()]
        [MaxLength(1)] 
        public String Cote { get; set; }
        
        [Description("Dispositif de retenue")]
        [Column("CD_DPR_OA__DPR",Order=7)]
        [MaxLength(60)] 
        public String CdDprOaDpr { get; set; }
        
        [Description("Garde-corps")]
        [Column("CD_GC_OA__GARDE_CORPS",Order=8)]
        [MaxLength(60)] 
        public String CdGcOaGardeCorps { get; set; }
        
        [Description("Date MS DPR")]
        [Column("DATE_DPR",Order=9)]
        public Nullable<DateTime> DateDpr { get; set; }
        
        [Description("Date MS GC")]
        [Column("DATE_GC",Order=10)]
        public Nullable<DateTime> DateGc { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=11)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
