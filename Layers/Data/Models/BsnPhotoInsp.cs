using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_BSN",Schema="BSN")]
    public partial class BsnPhotoInsp : ModelBase
    {
        private BsnInsp _bsnInsp;
        public virtual BsnInsp BsnInsp 
        {
            get
            {
                return this._bsnInsp;
                
            }
            set
            {
                this._bsnInsp = value;
                this.CampBsnIdCamp = this._bsnInsp.CampBsnIdCamp;
                this.DscBsnNumBsn = this._bsnInsp.DscBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("INSP_BSN_ID_PK",Order=0)]
        public Int64 BsnInspIdPk {get;set;}
        
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
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
