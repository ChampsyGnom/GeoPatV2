using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_OA",Schema="OA")]
    public partial class OaCdConclusionInsp : ModelBase
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
        
        private OaInsp _oaInsp;
        public virtual OaInsp OaInsp 
        {
            get
            {
                return this._oaInsp;
                
            }
            set
            {
                this._oaInsp = value;
                this.DscOaNumOa = this._oaInsp.DscOaNumOa;
                this.CampOaIdCamp = this._oaInsp.CampOaIdCamp;
            }
        }
        
        [Required()]
        [Column("INSP_OA_ID_PK",Order=1)]
        public Int64 OaInspIdPk {get;set;}
        
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
