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
        public virtual GotCdLigne GotCdLigne {get;set;}
        
        public virtual GotVst GotVst {get;set;}
        
        public virtual ICollection<GotPhotoSprtVst> GotPhotoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=0)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GOT__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreGotIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GOT__ID_LIGNE",Order=3)]
        [Required()]
        public Int64 CdLigneGotIdLigne { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=4)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=5)]
        [MaxLength(500)] 
        public String Obs { get; set; }
        
    }
}
