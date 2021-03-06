using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_SPRT_VST_OA",Schema="OA")]
    public partial class OaPhotoSprtVst : ModelBase
    {
        private OaSprtVst _oaSprtVst;
        public virtual OaSprtVst OaSprtVst 
        {
            get
            {
                return this._oaSprtVst;
                
            }
            set
            {
                this._oaSprtVst = value;
                this.DscOaNumOa = this._oaSprtVst.DscOaNumOa;
                this.CampOaIdCamp = this._oaSprtVst.CampOaIdCamp;
                this.CdChapitreOaIdChap = this._oaSprtVst.CdChapitreOaIdChap;
                this.CdLigneOaIdLigne = this._oaSprtVst.CdLigneOaIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_OA_ID_PK",Order=0)]
        public Int64 OaSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=2)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OA__ID_CHAP",Order=4)]
        [Required()]
        public Int64 CdChapitreOaIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_OA__ID_LIGNE",Order=5)]
        [Required()]
        public Int64 CdLigneOaIdLigne { get; set; }
        
        [Description("Identifiant de la photo")]
        [Column("ID",Order=6)]
        [Required()]
        [MaxLength(50)] 
        public String Id { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=7)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
