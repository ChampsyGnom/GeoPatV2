using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_TMP_OA",Schema="OA")]
    public partial class OaPhotoEltInspTmp : ModelBase
    {
        private OaEltInspTmp _oaEltInspTmp;
        public virtual OaEltInspTmp OaEltInspTmp 
        {
            get
            {
                return this._oaEltInspTmp;
                
            }
            set
            {
                this._oaEltInspTmp = value;
                this.GrpOaIdGrp = this._oaEltInspTmp.GrpOaIdGrp;
                this.PrtOaIdPrt = this._oaEltInspTmp.PrtOaIdPrt;
                this.SprtOaIdSprt = this._oaEltInspTmp.SprtOaIdSprt;
                this.CampOaIdCamp = this._oaEltInspTmp.CampOaIdCamp;
                this.DscTempOaNumOa = this._oaEltInspTmp.DscTempOaNumOa;
                this.EltOaIdElem = this._oaEltInspTmp.EltOaIdElem;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_TMP_OA_ID_PK",Order=0)]
        public Int64 OaEltInspTmpIdPk {get;set;}
        
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
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_TEMP_OA__NUM_OA",Order=6)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOaNumOa { get; set; }
        
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
