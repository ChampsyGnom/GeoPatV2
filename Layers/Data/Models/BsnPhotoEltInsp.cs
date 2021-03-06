using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_BSN",Schema="BSN")]
    public partial class BsnPhotoEltInsp : ModelBase
    {
        private BsnEltInsp _bsnEltInsp;
        public virtual BsnEltInsp BsnEltInsp 
        {
            get
            {
                return this._bsnEltInsp;
                
            }
            set
            {
                this._bsnEltInsp = value;
                this.GrpBsnIdGrp = this._bsnEltInsp.GrpBsnIdGrp;
                this.PrtBsnIdPrt = this._bsnEltInsp.PrtBsnIdPrt;
                this.SprtBsnIdSprt = this._bsnEltInsp.SprtBsnIdSprt;
                this.CampBsnIdCamp = this._bsnEltInsp.CampBsnIdCamp;
                this.EltBsnIdElem = this._bsnEltInsp.EltBsnIdElem;
                this.DscBsnNumBsn = this._bsnEltInsp.DscBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_BSN_ID_PK",Order=0)]
        public Int64 BsnEltInspIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_BSN__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpBsnIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_BSN__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtBsnIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_BSN__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtBsnIdSprt { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ELT_BSN__ID_ELEM",Order=6)]
        [Required()]
        public Int64 EltBsnIdElem { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=7)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant de la photo")]
        [Column("ID",Order=8)]
        [Required()]
        [MaxLength(50)] 
        public String Id { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=9)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
