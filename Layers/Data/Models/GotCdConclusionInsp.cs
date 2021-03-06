using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_GOT",Schema="GOT")]
    public partial class GotCdConclusionInsp : ModelBase
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
        
        private GotInsp _gotInsp;
        public virtual GotInsp GotInsp 
        {
            get
            {
                return this._gotInsp;
                
            }
            set
            {
                this._gotInsp = value;
                this.DscGotNumGot = this._gotInsp.DscGotNumGot;
                this.CampGotIdCamp = this._gotInsp.CampGotIdCamp;
            }
        }
        
        [Required()]
        [Column("INSP_GOT_ID_PK",Order=1)]
        public Int64 GotInspIdPk {get;set;}
        
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
