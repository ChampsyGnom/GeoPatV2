using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAVAUX_BSN",Schema="BSN")]
    public partial class BsnTravaux : ModelBase
    {
        public virtual BsnDsc BsnDsc {get;set;}
        
        public virtual BsnNatureTrav BsnNatureTrav {get;set;}
        
        public virtual BsnCdEntp BsnCdEntp {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_BSN__CODE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxBsnCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_BSN__NATURE",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String NatureTravBsnNature { get; set; }
        
        [Description("Date Réception")]
        [Column("DATE_RCP",Order=3)]
        [Required()]
        public DateTime DateRcp { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_BSN__ENTREPRISE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String CdEntpBsnEntreprise { get; set; }
        
        [Description("Fin de garantie")]
        [Column("DATE_FIN_GAR",Order=5)]
        public Nullable<DateTime> DateFinGar { get; set; }
        
        [Description("Coût")]
        [Column("COUT",Order=6)]
        public Nullable<Int64> Cout { get; set; }
        
        [Description("No Marché")]
        [Column("MARCHE",Order=7)]
        [MaxLength(25)] 
        public String Marche { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=8)]
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
    }
}
