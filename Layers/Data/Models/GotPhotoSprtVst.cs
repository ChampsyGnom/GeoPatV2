using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_SPRT_VST_GOT",Schema="GOT")]
    public partial class GotPhotoSprtVst : ModelBase
    {
        private GotSprtVst _gotSprtVst;
        public virtual GotSprtVst GotSprtVst 
        {
            get
            {
                return this._gotSprtVst;
                
            }
            set
            {
                this._gotSprtVst = value;
                this.DscGotNumGot = this._gotSprtVst.DscGotNumGot;
                this.CampGotIdCamp = this._gotSprtVst.CampGotIdCamp;
                this.CdChapitreGotIdChap = this._gotSprtVst.CdChapitreGotIdChap;
                this.CdLigneGotIdLigne = this._gotSprtVst.CdLigneGotIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_GOT_ID_PK",Order=0)]
        public Int64 GotSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=2)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GOT__ID_CHAP",Order=4)]
        [Required()]
        public Int64 CdChapitreGotIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GOT__ID_LIGNE",Order=5)]
        [Required()]
        public Int64 CdLigneGotIdLigne { get; set; }
        
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
