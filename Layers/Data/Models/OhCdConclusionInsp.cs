using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_OH",Schema="OH")]
    public partial class OhCdConclusionInsp : ModelBase
    {
        private OhInsp _ohInsp;
        public virtual OhInsp OhInsp 
        {
            get
            {
                return this._ohInsp;
                
            }
            set
            {
                this._ohInsp = value;
                this.CampOhIdCamp = this._ohInsp.CampOhIdCamp;
                this.DscOhNumOh = this._ohInsp.DscOhNumOh;
            }
        }
        
        [Required()]
        [Column("INSP_OH_ID_PK",Order=0)]
        public Int64 OhInspIdPk {get;set;}
        
        private OhCdConclusion _ohCdConclusion;
        public virtual OhCdConclusion OhCdConclusion 
        {
            get
            {
                return this._ohCdConclusion;
                
            }
            set
            {
                this._ohCdConclusion = value;
                this.CdConclusionOhIdConc = this._ohCdConclusion.IdConc;
            }
        }
        
        [Required()]
        [Column("CD_CONCLUSION_OH_ID_PK",Order=1)]
        public Int64 OhCdConclusionIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant conclusion")]
        [Column("CD_CONCLUSION_OH__ID_CONC",Order=5)]
        [Required()]
        public Int64 CdConclusionOhIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=6)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
