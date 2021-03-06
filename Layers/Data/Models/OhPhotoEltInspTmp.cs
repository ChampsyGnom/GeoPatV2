using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_TMP_OH",Schema="OH")]
    public partial class OhPhotoEltInspTmp : ModelBase
    {
        private OhEltInspTmp _ohEltInspTmp;
        public virtual OhEltInspTmp OhEltInspTmp 
        {
            get
            {
                return this._ohEltInspTmp;
                
            }
            set
            {
                this._ohEltInspTmp = value;
                this.GrpOhIdGrp = this._ohEltInspTmp.GrpOhIdGrp;
                this.PrtOhIdPrt = this._ohEltInspTmp.PrtOhIdPrt;
                this.SprtOhIdSprt = this._ohEltInspTmp.SprtOhIdSprt;
                this.CampOhIdCamp = this._ohEltInspTmp.CampOhIdCamp;
                this.DscTempOhNumOh = this._ohEltInspTmp.DscTempOhNumOh;
                this.EltOhIdElem = this._ohEltInspTmp.EltOhIdElem;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_TMP_OH_ID_PK",Order=0)]
        public Int64 OhEltInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OH__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpOhIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OH__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtOhIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_OH__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtOhIdSprt { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_TEMP_OH__NUM_OH",Order=6)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOhNumOh { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_OH__ID_ELEM",Order=7)]
        [Required()]
        public Int64 EltOhIdElem { get; set; }
        
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
