using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_SPRT_VST_GMS",Schema="GMS")]
    public partial class GmsPhotoSprtVst : ModelBase
    {
        private GmsSprtVst _gmsSprtVst;
        public virtual GmsSprtVst GmsSprtVst 
        {
            get
            {
                return this._gmsSprtVst;
                
            }
            set
            {
                this._gmsSprtVst = value;
                this.CampGmsIdCamp = this._gmsSprtVst.CampGmsIdCamp;
                this.DscGmsNumGms = this._gmsSprtVst.DscGmsNumGms;
                this.CdChapitreGmsIdChap = this._gmsSprtVst.CdChapitreGmsIdChap;
                this.CdLigneGmsIdLigne = this._gmsSprtVst.CdLigneGmsIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_GMS_ID_PK",Order=0)]
        public Int64 GmsSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GMS__ID_CHAP",Order=4)]
        [Required()]
        public Int64 CdChapitreGmsIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GMS__ID_LIGNE",Order=5)]
        [Required()]
        public Int64 CdLigneGmsIdLigne { get; set; }
        
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
