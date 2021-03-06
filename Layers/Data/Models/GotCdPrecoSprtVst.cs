using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_GOT",Schema="GOT")]
    public partial class GotCdPrecoSprtVst : ModelBase
    {
        private GotVst _gotVst;
        public virtual GotVst GotVst 
        {
            get
            {
                return this._gotVst;
                
            }
            set
            {
                this._gotVst = value;
                this.DscGotNumGot = this._gotVst.DscGotNumGot;
                this.CampGotIdCamp = this._gotVst.CampGotIdCamp;
            }
        }
        
        [Required()]
        [Column("VST_GOT_ID_PK",Order=0)]
        public Int64 GotVstIdPk {get;set;}
        
        private GotBpu _gotBpu;
        public virtual GotBpu GotBpu 
        {
            get
            {
                return this._gotBpu;
                
            }
            set
            {
                this._gotBpu = value;
                this.BpuGotIdBpu = this._gotBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_GOT_ID_PK",Order=1)]
        public Int64 GotBpuIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_GOT__ID_BPU",Order=5)]
        [Required()]
        public Int64 BpuGotIdBpu { get; set; }
        
        [Description("Entretien réalisé")]
        [Column("REALISE",Order=6)]
        public Nullable<int> RealiseValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Realise 
        {
            get
            {
                if (RealiseValueInt.HasValue) return Convert.ToBoolean(RealiseValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealiseValueInt = Convert.ToInt32(value.Value);}
                else {this.RealiseValueInt =null;}
            }
        }
        
    }
}
