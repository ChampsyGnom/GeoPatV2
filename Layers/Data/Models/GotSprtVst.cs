using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_VST_GOT",Schema="GOT")]
    public partial class GotSprtVst : ModelBase
    {
        private GotCdLigne _gotCdLigne;
        public virtual GotCdLigne GotCdLigne 
        {
            get
            {
                return this._gotCdLigne;
                
            }
            set
            {
                this._gotCdLigne = value;
                this.CdChapitreGotIdChap = this._gotCdLigne.CdChapitreGotIdChap;
                this.CdLigneGotIdLigne = this._gotCdLigne.IdLigne;
            }
        }
        
        [Required()]
        [Column("CD_LIGNE_GOT_ID_PK",Order=0)]
        public Int64 GotCdLigneIdPk {get;set;}
        
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
        [Column("VST_GOT_ID_PK",Order=1)]
        public Int64 GotVstIdPk {get;set;}
        
        public virtual ICollection<GotPhotoSprtVst> GotPhotoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
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
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GOT__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreGotIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GOT__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneGotIdLigne { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=7)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=8)]
        [MaxLength(500)] 
        public String Obs { get; set; }
        
    }
}
