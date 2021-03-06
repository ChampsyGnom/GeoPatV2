using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_TMP_BSN",Schema="BSN")]
    public partial class BsnPhotoInspTmp : ModelBase
    {
        private BsnInspTmp _bsnInspTmp;
        public virtual BsnInspTmp BsnInspTmp 
        {
            get
            {
                return this._bsnInspTmp;
                
            }
            set
            {
                this._bsnInspTmp = value;
                this.CampBsnIdCamp = this._bsnInspTmp.CampBsnIdCamp;
                this.DscTempBsnNumBsn = this._bsnInspTmp.DscTempBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_BSN_ID_PK",Order=0)]
        public Int64 BsnInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_TEMP_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempBsnNumBsn { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
