using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_OA",Schema="OA")]
    public partial class OaCdPrecoSprtVst : ModelBase
    {
        private OaVst _oaVst;
        public virtual OaVst OaVst 
        {
            get
            {
                return this._oaVst;
                
            }
            set
            {
                this._oaVst = value;
                this.DscOaNumOa = this._oaVst.DscOaNumOa;
                this.CampOaIdCamp = this._oaVst.CampOaIdCamp;
            }
        }
        
        [Required()]
        [Column("VST_OA_ID_PK",Order=0)]
        public Int64 OaVstIdPk {get;set;}
        
        private OaBpu _oaBpu;
        public virtual OaBpu OaBpu 
        {
            get
            {
                return this._oaBpu;
                
            }
            set
            {
                this._oaBpu = value;
                this.BpuOaIdBpu = this._oaBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_OA_ID_PK",Order=1)]
        public Int64 OaBpuIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_OA__ID_BPU",Order=5)]
        [Required()]
        public Int64 BpuOaIdBpu { get; set; }
        
        [Description("Entretien réalisé")]
        [Column("CD_PRECO__SPRT_VST_OH__REALISE",Order=6)]
        public Nullable<int> CdPrecoSprtVstOhRealiseValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> CdPrecoSprtVstOhRealise 
        {
            get
            {
                if (CdPrecoSprtVstOhRealiseValueInt.HasValue) return Convert.ToBoolean(CdPrecoSprtVstOhRealiseValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.CdPrecoSprtVstOhRealiseValueInt = Convert.ToInt32(value.Value);}
                else {this.CdPrecoSprtVstOhRealiseValueInt =null;}
            }
        }
        
    }
}
