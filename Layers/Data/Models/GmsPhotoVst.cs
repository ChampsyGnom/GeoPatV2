using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_VST_GMS",Schema="GMS")]
    public partial class GmsPhotoVst : ModelBase
    {
        private GmsVst _gmsVst;
        public virtual GmsVst GmsVst 
        {
            get
            {
                return this._gmsVst;
                
            }
            set
            {
                this._gmsVst = value;
                this.CampGmsIdCamp = this._gmsVst.CampGmsIdCamp;
                this.DscGmsNumGms = this._gmsVst.DscGmsNumGms;
            }
        }
        
        [Required()]
        [Column("VST_GMS_ID_PK",Order=0)]
        public Int64 GmsVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Id photo")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Commentaire photo")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
