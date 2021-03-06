using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_TMP_GOT",Schema="GOT")]
    public partial class GotCdConclusionInspTmp : ModelBase
    {
        private GotCdConclusion _gotCdConclusion;
        public virtual GotCdConclusion GotCdConclusion 
        {
            get
            {
                return this._gotCdConclusion;
                
            }
            set
            {
                this._gotCdConclusion = value;
                this.CdConclusionGotIdConc = this._gotCdConclusion.IdConc;
            }
        }
        
        [Required()]
        [Column("CD_CONCLUSION_GOT_ID_PK",Order=0)]
        public Int64 GotCdConclusionIdPk {get;set;}
        
        private GotInspTmp _gotInspTmp;
        public virtual GotInspTmp GotInspTmp 
        {
            get
            {
                return this._gotInspTmp;
                
            }
            set
            {
                this._gotInspTmp = value;
                this.CampGotIdCamp = this._gotInspTmp.CampGotIdCamp;
                this.DscTempGotNumGot = this._gotInspTmp.DscTempGotNumGot;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_GOT_ID_PK",Order=1)]
        public Int64 GotInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_TEMP_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGotNumGot { get; set; }
        
        [Description("Identifiant conclusion")]
        [Column("CD_CONCLUSION_GOT__ID_CONC",Order=5)]
        [Required()]
        public Int64 CdConclusionGotIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=6)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
