using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_TMP_GOT",Schema="GOT")]
    public partial class GotPhotoInspTmp : ModelBase
    {
        private GotInspTmp _gotInspTmp;
        public virtual GotInspTmp GotInspTmp 
        {
            get
            {
                return this._gotInspTmp;
                
            }
            set
            {
                this._gotInspTmp = value;
                this.CampGotIdCamp = this._gotInspTmp.CampGotIdCamp;
                this.DscTempGotNumGot = this._gotInspTmp.DscTempGotNumGot;
            }
        }
        
        [Required()]
        [Column("INSP_TMP_GOT_ID_PK",Order=0)]
        public Int64 GotInspTmpIdPk {get;set;}
        
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
        [Column("CAMP_GOT__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_TEMP_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGotNumGot { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
