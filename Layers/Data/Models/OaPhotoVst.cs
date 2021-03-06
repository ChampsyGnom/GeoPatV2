using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_VST_OA",Schema="OA")]
    public partial class OaPhotoVst : ModelBase
    {
        private OaVst _oaVst;
        public virtual OaVst OaVst 
        {
            get
            {
                return this._oaVst;
                
            }
            set
            {
                this._oaVst = value;
                this.DscOaNumOa = this._oaVst.DscOaNumOa;
                this.CampOaIdCamp = this._oaVst.CampOaIdCamp;
            }
        }
        
        [Required()]
        [Column("VST_OA_ID_PK",Order=0)]
        public Int64 OaVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("ID",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String Id { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
