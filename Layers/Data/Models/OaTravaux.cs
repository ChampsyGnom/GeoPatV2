using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAVAUX_OA",Schema="OA")]
    public partial class OaTravaux : ModelBase
    {
        public virtual OaDsc OaDsc {get;set;}
        
        [Required()]
        [Column("DSC_OA_ID_PK",Order=0)]
        public Int64 OaDscIdPk {get;set;}
        
        public virtual OaNatureTrav OaNatureTrav {get;set;}
        
        [Required()]
        [Column("NATURE_TRAV_OA_ID_PK",Order=1)]
        public Int64 OaNatureTravIdPk {get;set;}
        
        public virtual OaCdEntp OaCdEntp {get;set;}
        
        [Column("CD_ENTP_OA_ID_PK",Order=2)]
        public Nullable<Int64> OaCdEntpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_OA__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxOaCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_OA__NATURE",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String NatureTravOaNature { get; set; }
        
        [Description("Date Réception")]
        [Column("DATE_RCP",Order=7)]
        [Required()]
        public DateTime DateRcp { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_OA__ENTREPRISE",Order=8)]
        [MaxLength(60)] 
        public String CdEntpOaEntreprise { get; set; }
        
        [Description("Fin de garantie")]
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
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
    }
}
