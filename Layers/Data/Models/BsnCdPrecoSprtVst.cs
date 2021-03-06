using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_BSN",Schema="BSN")]
    public partial class BsnCdPrecoSprtVst : ModelBase
    {
        private BsnBpu _bsnBpu;
        public virtual BsnBpu BsnBpu 
        {
            get
            {
                return this._bsnBpu;
                
            }
            set
            {
                this._bsnBpu = value;
                this.BpuBsnIdBpu = this._bsnBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_BSN_ID_PK",Order=0)]
        public Int64 BsnBpuIdPk {get;set;}
        
        private BsnSprtVst _bsnSprtVst;
        public virtual BsnSprtVst BsnSprtVst 
        {
            get
            {
                return this._bsnSprtVst;
                
            }
            set
            {
                this._bsnSprtVst = value;
                this.CampBsnIdCamp = this._bsnSprtVst.CampBsnIdCamp;
                this.DscBsnNumBsn = this._bsnSprtVst.DscBsnNumBsn;
                this.CdChapitreBsnIdChap = this._bsnSprtVst.CdChapitreBsnIdChap;
                this.CdLigneBsnIdLigne = this._bsnSprtVst.CdLigneBsnIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_BSN_ID_PK",Order=1)]
        public Int64 BsnSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_BSN__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreBsnIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_BSN__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneBsnIdLigne { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_BSN__ID_BPU",Order=7)]
        [Required()]
        public Int64 BpuBsnIdBpu { get; set; }
        
        [Description("Entretien réalisé")]
        [Column("REALISE",Order=8)]
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
