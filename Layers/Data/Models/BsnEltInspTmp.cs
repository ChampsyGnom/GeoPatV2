using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_TMP_BSN",Schema="BSN")]
    public partial class BsnEltInspTmp : ModelBase
    {
        private BsnInspTmp _bsnInspTmp;
        public virtual BsnInspTmp BsnInspTmp 
        {
            get
            {
                return this._bsnInspTmp;
                
            }
            set
            {
                this._bsnInspTmp = value;
                this.CampBsnIdCamp = this._bsnInspTmp.CampBsnIdCamp;
                this.DscTempBsnNumBsn = this._bsnInspTmp.DscTempBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_BSN_ID_PK",Order=0)]
        public Int64 BsnInspTmpIdPk {get;set;}
        
        private BsnElt _bsnElt;
        public virtual BsnElt BsnElt 
        {
            get
            {
                return this._bsnElt;
                
            }
            set
            {
                this._bsnElt = value;
                this.GrpBsnIdGrp = this._bsnElt.GrpBsnIdGrp;
                this.PrtBsnIdPrt = this._bsnElt.PrtBsnIdPrt;
                this.SprtBsnIdSprt = this._bsnElt.SprtBsnIdSprt;
                this.EltBsnIdElem = this._bsnElt.IdElem;
            }
        }
        
        [Required()]
        [Column("ELT_BSN_ID_PK",Order=1)]
        public Int64 BsnEltIdPk {get;set;}
        
        public virtual ICollection<BsnPhotoEltInspTmp> BsnPhotoEltInspTmps { get; set; }
        
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
        [Column("DSC_TEMP_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempBsnNumBsn { get; set; }
        
        [Description("Identifiant Groupe")]
        [Column("GRP_BSN__ID_GRP",Order=5)]
        [Required()]
        public Int64 GrpBsnIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_BSN__ID_PRT",Order=6)]
        [Required()]
        public Int64 PrtBsnIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_BSN__ID_SPRT",Order=7)]
        [Required()]
        public Int64 SprtBsnIdSprt { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ELT_BSN__ID_ELEM",Order=8)]
        [Required()]
        public Int64 EltBsnIdElem { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=9)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=10)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
