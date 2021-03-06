using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_GMS",Schema="GMS")]
    public partial class GmsPhotoEltInsp : ModelBase
    {
        private GmsEltInsp _gmsEltInsp;
        public virtual GmsEltInsp GmsEltInsp 
        {
            get
            {
                return this._gmsEltInsp;
                
            }
            set
            {
                this._gmsEltInsp = value;
                this.GrpGmsIdGrp = this._gmsEltInsp.GrpGmsIdGrp;
                this.PrtGmsIdPrt = this._gmsEltInsp.PrtGmsIdPrt;
                this.SprtGmsIdSprt = this._gmsEltInsp.SprtGmsIdSprt;
                this.EltGmsIdElem = this._gmsEltInsp.EltGmsIdElem;
                this.CampGmsIdCamp = this._gmsEltInsp.CampGmsIdCamp;
                this.DscGmsNumGms = this._gmsEltInsp.DscGmsNumGms;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_GMS_ID_PK",Order=0)]
        public Int64 GmsEltInspIdPk {get;set;}
        
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
        
        [Description("Identifiant élément")]
        [Column("ELT_GMS__ID_ELEM",Order=5)]
        [Required()]
        public Int64 EltGmsIdElem { get; set; }
        
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=7)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
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
