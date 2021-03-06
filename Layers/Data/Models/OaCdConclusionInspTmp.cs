using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_TMP_OA",Schema="OA")]
    public partial class OaCdConclusionInspTmp : ModelBase
    {
        private OaCdConclusion _oaCdConclusion;
        public virtual OaCdConclusion OaCdConclusion 
        {
            get
            {
                return this._oaCdConclusion;
                
            }
            set
            {
                this._oaCdConclusion = value;
                this.CdConclusionOaIdConc = this._oaCdConclusion.IdConc;
            }
        }
        
        [Required()]
        [Column("CD_CONCLUSION_OA_ID_PK",Order=0)]
        public Int64 OaCdConclusionIdPk {get;set;}
        
        private OaInspTmp _oaInspTmp;
        public virtual OaInspTmp OaInspTmp 
        {
            get
            {
                return this._oaInspTmp;
                
            }
            set
            {
                this._oaInspTmp = value;
                this.CampOaIdCamp = this._oaInspTmp.CampOaIdCamp;
                this.DscTempOaNumOa = this._oaInspTmp.DscTempOaNumOa;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_OA_ID_PK",Order=1)]
        public Int64 OaInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_TEMP_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOaNumOa { get; set; }
        
        [Description("Identifiant conclusion")]
        [Column("CD_CONCLUSION_OA__ID_CONC",Order=5)]
        [Required()]
        public Int64 CdConclusionOaIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=6)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
