using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAVAUX_OH",Schema="OH")]
    public partial class OhTravaux : ModelBase
    {
        private OhDsc _ohDsc;
        public virtual OhDsc OhDsc 
        {
            get
            {
                return this._ohDsc;
                
            }
            set
            {
                this._ohDsc = value;
                this.DscOhNumOh = this._ohDsc.NumOh;
            }
        }
        
        [Required()]
        [Column("DSC_OH_ID_PK",Order=0)]
        public Int64 OhDscIdPk {get;set;}
        
        private OhNatureTrav _ohNatureTrav;
        public virtual OhNatureTrav OhNatureTrav 
        {
            get
            {
                return this._ohNatureTrav;
                
            }
            set
            {
                this._ohNatureTrav = value;
                this.CdTravauxOhCode = this._ohNatureTrav.CdTravauxOhCode;
                this.NatureTravOhNature = this._ohNatureTrav.Nature;
            }
        }
        
        [Required()]
        [Column("NATURE_TRAV_OH_ID_PK",Order=1)]
        public Int64 OhNatureTravIdPk {get;set;}
        
        private OhCdEntp _ohCdEntp;
        public virtual OhCdEntp OhCdEntp 
        {
            get
            {
                return this._ohCdEntp;
                
            }
            set
            {
                this._ohCdEntp = value;
                this.CdEntpOhEntreprise = this._ohCdEntp.Entreprise;
            }
        }
        
        [Required()]
        [Column("CD_ENTP_OH_ID_PK",Order=2)]
        public Int64 OhCdEntpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_OH__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxOhCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_OH__NATURE",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String NatureTravOhNature { get; set; }
        
        [Description("Date Réception")]
        [Column("DATE_RCP",Order=7)]
        [Required()]
        public DateTime DateRcp { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_OH__ENTREPRISE",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdEntpOhEntreprise { get; set; }
        
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
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
    }
}
