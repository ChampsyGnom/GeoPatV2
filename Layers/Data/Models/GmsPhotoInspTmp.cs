using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_TMP_GMS",Schema="GMS")]
    public partial class GmsPhotoInspTmp : ModelBase
    {
        private GmsInspTmp _gmsInspTmp;
        public virtual GmsInspTmp GmsInspTmp 
        {
            get
            {
                return this._gmsInspTmp;
                
            }
            set
            {
                this._gmsInspTmp = value;
                this.CampGmsIdCamp = this._gmsInspTmp.CampGmsIdCamp;
                this.DscTempGmsNumGms = this._gmsInspTmp.DscTempGmsNumGms;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_GMS_ID_PK",Order=0)]
        public Int64 GmsInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("Identifiant2")]
        [Column("CAMP_GMS__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_TEMP_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGmsNumGms { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
