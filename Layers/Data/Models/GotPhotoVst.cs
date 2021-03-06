using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_VST_GOT",Schema="GOT")]
    public partial class GotPhotoVst : ModelBase
    {
        private GotVst _gotVst;
        public virtual GotVst GotVst 
        {
            get
            {
                return this._gotVst;
                
            }
            set
            {
                this._gotVst = value;
                this.DscGotNumGot = this._gotVst.DscGotNumGot;
                this.CampGotIdCamp = this._gotVst.CampGotIdCamp;
            }
        }
        
        [Required()]
        [Column("VST_GOT_ID_PK",Order=0)]
        public Int64 GotVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Id photo vst")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("photo vst commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
