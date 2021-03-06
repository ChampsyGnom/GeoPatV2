using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_INSP_OA",Schema="OA")]
    public partial class OaPhotoInsp : ModelBase
    {
        private OaInsp _oaInsp;
        public virtual OaInsp OaInsp 
        {
            get
            {
                return this._oaInsp;
                
            }
            set
            {
                this._oaInsp = value;
                this.DscOaNumOa = this._oaInsp.DscOaNumOa;
                this.CampOaIdCamp = this._oaInsp.CampOaIdCamp;
            }
        }
        
        [Required()]
        [Column("INSP_OA_ID_PK",Order=0)]
        public Int64 OaInspIdPk {get;set;}
        
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
