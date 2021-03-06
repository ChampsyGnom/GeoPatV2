using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_ELT_INSP_TMP_GOT",Schema="GOT")]
    public partial class GotPhotoEltInspTmp : ModelBase
    {
        private GotEltInspTmp _gotEltInspTmp;
        public virtual GotEltInspTmp GotEltInspTmp 
        {
            get
            {
                return this._gotEltInspTmp;
                
            }
            set
            {
                this._gotEltInspTmp = value;
                this.GrpGotIdGrp = this._gotEltInspTmp.GrpGotIdGrp;
                this.PrtGotIdPrt = this._gotEltInspTmp.PrtGotIdPrt;
                this.SprtGotIdSprt = this._gotEltInspTmp.SprtGotIdSprt;
                this.CampGotIdCamp = this._gotEltInspTmp.CampGotIdCamp;
                this.DscTempGotNumGot = this._gotEltInspTmp.DscTempGotNumGot;
                this.EltGotIdElem = this._gotEltInspTmp.EltGotIdElem;
            }
        }
        
        [Required()]
        [Column("ELT_INSP_TMP_GOT_ID_PK",Order=0)]
        public Int64 GotEltInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_GOT__ID_GRP",Order=2)]
        [Required()]
        public Int64 GrpGotIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GOT__ID_PRT",Order=3)]
        [Required()]
        public Int64 PrtGotIdPrt { get; set; }
        
        [Description("Identifiant sous partie")]
        [Column("SPRT_GOT__ID_SPRT",Order=4)]
        [Required()]
        public Int64 SprtGotIdSprt { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_TEMP_GOT__NUM_GOT",Order=6)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGotNumGot { get; set; }
        
        [Description("Identifiant Elément")]
        [Column("ELT_GOT__ID_ELEM",Order=7)]
        [Required()]
        public Int64 EltGotIdElem { get; set; }
        
        [Description("Identifiant")]
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
