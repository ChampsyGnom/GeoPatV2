using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_TMP_GMS",Schema="GMS")]
    public partial class GmsPhotoEltInspTmp : ModelBase
    {
        private GmsEltInspTmp _gmsEltInspTmp;
        public virtual GmsEltInspTmp GmsEltInspTmp 
        {
            get
            {
                return this._gmsEltInspTmp;
                
            }
            set
            {
                this._gmsEltInspTmp = value;
                this.GrpGmsIdGrp = this._gmsEltInspTmp.GrpGmsIdGrp;
                this.PrtGmsIdPrt = this._gmsEltInspTmp.PrtGmsIdPrt;
                this.SprtGmsIdSprt = this._gmsEltInspTmp.SprtGmsIdSprt;
                this.CampGmsIdCamp = this._gmsEltInspTmp.CampGmsIdCamp;
                this.DscTempGmsNumGms = this._gmsEltInspTmp.DscTempGmsNumGms;
                this.EltGmsIdElem = this._gmsEltInspTmp.EltGmsIdElem;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_TMP_GMS_ID_PK",Order=0)]
        public Int64 GmsEltInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GMS__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGmsIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GMS__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtGmsIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_GMS__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtGmsIdSprt { get; set; }
        
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_TEMP_GMS__NUM_GMS",Order=6)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGmsNumGms { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_GMS__ID_ELEM",Order=7)]
        [Required()]
        public Int64 EltGmsIdElem { get; set; }
        
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
