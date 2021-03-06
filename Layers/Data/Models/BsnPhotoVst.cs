using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_VST_BSN",Schema="BSN")]
    public partial class BsnPhotoVst : ModelBase
    {
        private BsnVst _bsnVst;
        public virtual BsnVst BsnVst 
        {
            get
            {
                return this._bsnVst;
                
            }
            set
            {
                this._bsnVst = value;
                this.CampBsnIdCamp = this._bsnVst.CampBsnIdCamp;
                this.DscBsnNumBsn = this._bsnVst.DscBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("VST_BSN_ID_PK",Order=0)]
        public Int64 BsnVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("photo vst BSN id")]
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
        
        [Description("photo vst BSN commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
