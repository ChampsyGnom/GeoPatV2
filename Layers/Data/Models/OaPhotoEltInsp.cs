using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_OA",Schema="OA")]
    public partial class OaPhotoEltInsp : ModelBase
    {
        private OaEltInsp _oaEltInsp;
        public virtual OaEltInsp OaEltInsp 
        {
            get
            {
                return this._oaEltInsp;
                
            }
            set
            {
                this._oaEltInsp = value;
                this.GrpOaIdGrp = this._oaEltInsp.GrpOaIdGrp;
                this.PrtOaIdPrt = this._oaEltInsp.PrtOaIdPrt;
                this.SprtOaIdSprt = this._oaEltInsp.SprtOaIdSprt;
                this.DscOaNumOa = this._oaEltInsp.DscOaNumOa;
                this.CampOaIdCamp = this._oaEltInsp.CampOaIdCamp;
                this.EltOaIdElem = this._oaEltInsp.EltOaIdElem;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_OA_ID_PK",Order=0)]
        public Int64 OaEltInspIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OA__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOaIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OA__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtOaIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_OA__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtOaIdSprt { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_OA__ID_ELEM",Order=7)]
        [Required()]
        public Int64 EltOaIdElem { get; set; }
        
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
