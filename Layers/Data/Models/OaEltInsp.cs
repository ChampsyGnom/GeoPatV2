using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_OA",Schema="OA")]
    public partial class OaEltInsp : ModelBase
    {
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
        [Column("INSP_OA_ID_PK",Order=0)]
        public Int64 OaInspIdPk {get;set;}
        
        private OaElt _oaElt;
        public virtual OaElt OaElt 
        {
            get
            {
                return this._oaElt;
                
            }
            set
            {
                this._oaElt = value;
                this.GrpOaIdGrp = this._oaElt.GrpOaIdGrp;
                this.PrtOaIdPrt = this._oaElt.PrtOaIdPrt;
                this.SprtOaIdSprt = this._oaElt.SprtOaIdSprt;
                this.EltOaIdElem = this._oaElt.IdElem;
            }
        }
        
        [Required()]
        [Column("ELT_OA_ID_PK",Order=1)]
        public Int64 OaEltIdPk {get;set;}
        
        public virtual ICollection<OaPhotoEltInsp> OaPhotoEltInsps { get; set; }
        
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
        
        [Description("Identifiant Groupe")]
        [Column("GRP_OA__ID_GRP",Order=5)]
        [Required()]
        public Int64 GrpOaIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OA__ID_PRT",Order=6)]
        [Required()]
        public Int64 PrtOaIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_OA__ID_SPRT",Order=7)]
        [Required()]
        public Int64 SprtOaIdSprt { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_OA__ID_ELEM",Order=8)]
        [Required()]
        public Int64 EltOaIdElem { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=9)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observations")]
        [Column("OBS",Order=10)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
