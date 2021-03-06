using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_GMS",Schema="GMS")]
    public partial class GmsCdPrecoSprtVst : ModelBase
    {
        private GmsBpu _gmsBpu;
        public virtual GmsBpu GmsBpu 
        {
            get
            {
                return this._gmsBpu;
                
            }
            set
            {
                this._gmsBpu = value;
                this.BpuGmsIdBpu = this._gmsBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_GMS_ID_PK",Order=0)]
        public Int64 GmsBpuIdPk {get;set;}
        
        private GmsSprtVst _gmsSprtVst;
        public virtual GmsSprtVst GmsSprtVst 
        {
            get
            {
                return this._gmsSprtVst;
                
            }
            set
            {
                this._gmsSprtVst = value;
                this.CampGmsIdCamp = this._gmsSprtVst.CampGmsIdCamp;
                this.DscGmsNumGms = this._gmsSprtVst.DscGmsNumGms;
                this.CdChapitreGmsIdChap = this._gmsSprtVst.CdChapitreGmsIdChap;
                this.CdLigneGmsIdLigne = this._gmsSprtVst.CdLigneGmsIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_GMS_ID_PK",Order=1)]
        public Int64 GmsSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GMS__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreGmsIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GMS__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneGmsIdLigne { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_GMS__ID_BPU",Order=7)]
        [Required()]
        public Int64 BpuGmsIdBpu { get; set; }
        
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
