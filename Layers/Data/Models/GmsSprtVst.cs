using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_VST_GMS",Schema="GMS")]
    public partial class GmsSprtVst : ModelBase
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
        
        private GmsCdLigne _gmsCdLigne;
        public virtual GmsCdLigne GmsCdLigne 
        {
            get
            {
                return this._gmsCdLigne;
                
            }
            set
            {
                this._gmsCdLigne = value;
                this.CdChapitreGmsIdChap = this._gmsCdLigne.CdChapitreGmsIdChap;
                this.CdLigneGmsIdLigne = this._gmsCdLigne.IdLigne;
            }
        }
        
        [Required()]
        [Column("CD_LIGNE_GMS_ID_PK",Order=1)]
        public Int64 GmsCdLigneIdPk {get;set;}
        
        public virtual ICollection<GmsPhotoSprtVst> GmsPhotoSprtVsts { get; set; }
        
        public virtual ICollection<GmsCdPrecoSprtVst> GmsCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
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
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GMS__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreGmsIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GMS__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneGmsIdLigne { get; set; }
        
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
