using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_GMS",Schema="GMS")]
    public partial class GmsPhotoInsp : ModelBase
    {
        private GmsInsp _gmsInsp;
        public virtual GmsInsp GmsInsp 
        {
            get
            {
                return this._gmsInsp;
                
            }
            set
            {
                this._gmsInsp = value;
                this.CampGmsIdCamp = this._gmsInsp.CampGmsIdCamp;
                this.DscGmsNumGms = this._gmsInsp.DscGmsNumGms;
            }
        }
        
        [Required()]
        [Column("INSP_GMS_ID_PK",Order=0)]
        public Int64 GmsInspIdPk {get;set;}
        
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
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
