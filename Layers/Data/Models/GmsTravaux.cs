using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAVAUX_GMS",Schema="GMS")]
    public partial class GmsTravaux : ModelBase
    {
        public virtual GmsDsc GmsDsc {get;set;}
        
        [Required()]
        [Column("DSC_GMS_ID_PK",Order=0)]
        public Int64 GmsDscIdPk {get;set;}
        
        public virtual GmsNatureTrav GmsNatureTrav {get;set;}
        
        [Required()]
        [Column("NATURE_TRAV_GMS_ID_PK",Order=1)]
        public Int64 GmsNatureTravIdPk {get;set;}
        
        public virtual GmsCdEntp GmsCdEntp {get;set;}
        
        [Required()]
        [Column("CD_ENTP_GMS_ID_PK",Order=2)]
        public Int64 GmsCdEntpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_GMS__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxGmsCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_GMS__NATURE",Order=6)]
        [Required()]
        [MaxLength(255)] 
        public String NatureTravGmsNature { get; set; }
        
        [Description("Date réception")]
        [Column("DATE_RCP",Order=7)]
        [Required()]
        public DateTime DateRcp { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_GMS__ENTREPRISE",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdEntpGmsEntreprise { get; set; }
        
        [Description("Date fin de garantie")]
        [Column("DATE_FIN_GAR",Order=9)]
        public Nullable<DateTime> DateFinGar { get; set; }
        
        [Description("Coûts (€)")]
        [Column("COUT",Order=10)]
        public Nullable<Int64> Cout { get; set; }
        
        [Description("No Marché")]
        [Column("MARCHE",Order=11)]
        [MaxLength(25)] 
        public String Marche { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=12)]
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
    }
}
