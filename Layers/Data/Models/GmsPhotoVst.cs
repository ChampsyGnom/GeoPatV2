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
        public virtual GmsVst GmsVst {get;set;}
        
        [Key]
        [Description("Id photo")]
        [Column("ID",Order=0)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=2)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Commentaire photo")]
        [Column("COMMENTAIRE",Order=3)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
