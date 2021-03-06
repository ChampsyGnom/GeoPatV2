using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_GMS",Schema="GMS")]
    public partial class GmsEltInsp : ModelBase
    {
        private GmsElt _gmsElt;
        public virtual GmsElt GmsElt 
        {
            get
            {
                return this._gmsElt;
                
            }
            set
            {
                this._gmsElt = value;
                this.GrpGmsIdGrp = this._gmsElt.GrpGmsIdGrp;
                this.PrtGmsIdPrt = this._gmsElt.PrtGmsIdPrt;
                this.SprtGmsIdSprt = this._gmsElt.SprtGmsIdSprt;
                this.EltGmsIdElem = this._gmsElt.IdElem;
            }
        }
        
        [Required()]
        [Column("ELT_GMS_ID_PK",Order=0)]
        public Int64 GmsEltIdPk {get;set;}
        
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
        
        public virtual ICollection<GmsPhotoEltInsp> GmsPhotoEltInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GMS__ID_GRP",Order=3)]
        [Required()]
        public Int64 GrpGmsIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GMS__ID_PRT",Order=4)]
        [Required()]
        public Int64 PrtGmsIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_GMS__ID_SPRT",Order=5)]
        [Required()]
        public Int64 SprtGmsIdSprt { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_GMS__ID_ELEM",Order=6)]
        [Required()]
        public Int64 EltGmsIdElem { get; set; }
        
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=7)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=8)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
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
