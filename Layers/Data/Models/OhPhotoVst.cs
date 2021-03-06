using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_VST_OH",Schema="OH")]
    public partial class OhPhotoVst : ModelBase
    {
        private OhVst _ohVst;
        public virtual OhVst OhVst 
        {
            get
            {
                return this._ohVst;
                
            }
            set
            {
                this._ohVst = value;
                this.CampOhIdCamp = this._ohVst.CampOhIdCamp;
                this.DscOhNumOh = this._ohVst.DscOhNumOh;
            }
        }
        
        [Required()]
        [Column("VST_OH_ID_PK",Order=0)]
        public Int64 OhVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("photo vst oh id")]
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
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("photo vst oh commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
