using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_TMP_OH",Schema="OH")]
    public partial class OhPhotoInspTmp : ModelBase
    {
        private OhInspTmp _ohInspTmp;
        public virtual OhInspTmp OhInspTmp 
        {
            get
            {
                return this._ohInspTmp;
                
            }
            set
            {
                this._ohInspTmp = value;
                this.CampOhIdCamp = this._ohInspTmp.CampOhIdCamp;
                this.DscTempOhNumOh = this._ohInspTmp.DscTempOhNumOh;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_OH_ID_PK",Order=0)]
        public Int64 OhInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant2")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_TEMP_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOhNumOh { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
