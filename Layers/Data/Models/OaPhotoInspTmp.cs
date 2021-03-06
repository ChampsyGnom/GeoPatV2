using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_TMP_OA",Schema="OA")]
    public partial class OaPhotoInspTmp : ModelBase
    {
        private OaInspTmp _oaInspTmp;
        public virtual OaInspTmp OaInspTmp 
        {
            get
            {
                return this._oaInspTmp;
                
            }
            set
            {
                this._oaInspTmp = value;
                this.CampOaIdCamp = this._oaInspTmp.CampOaIdCamp;
                this.DscTempOaNumOa = this._oaInspTmp.DscTempOaNumOa;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_OA_ID_PK",Order=0)]
        public Int64 OaInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_TEMP_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOaNumOa { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
