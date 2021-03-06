using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_GMS",Schema="GMS")]
    public partial class GmsCdConclusionInsp : ModelBase
    {
        private GmsCdConclusion _gmsCdConclusion;
        public virtual GmsCdConclusion GmsCdConclusion 
        {
            get
            {
                return this._gmsCdConclusion;
                
            }
            set
            {
                this._gmsCdConclusion = value;
                this.CdConclusionGmsIdConc = this._gmsCdConclusion.IdConc;
            }
        }
        
        [Required()]
        [Column("CD_CONCLUSION_GMS_ID_PK",Order=0)]
        public Int64 GmsCdConclusionIdPk {get;set;}
        
        private GmsInsp _gmsInsp;
        public virtual GmsInsp GmsInsp 
        {
            get
            {
                return this._gmsInsp;
                
            }
            set
            {
                this._gmsInsp = value;
                this.CampGmsIdCamp = this._gmsInsp.CampGmsIdCamp;
                this.DscGmsNumGms = this._gmsInsp.DscGmsNumGms;
            }
        }
        
        [Required()]
        [Column("INSP_GMS_ID_PK",Order=1)]
        public Int64 GmsInspIdPk {get;set;}
        
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
        
        [Description("Identifiant Conclusion")]
        [Column("CD_CONCLUSION_GMS__ID_CONC",Order=5)]
        [Required()]
        public Int64 CdConclusionGmsIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=6)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
