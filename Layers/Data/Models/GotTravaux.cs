using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAVAUX_GOT",Schema="GOT")]
    public partial class GotTravaux : ModelBase
    {
        private GotDsc _gotDsc;
        public virtual GotDsc GotDsc 
        {
            get
            {
                return this._gotDsc;
                
            }
            set
            {
                this._gotDsc = value;
                this.DscGotNumGot = this._gotDsc.NumGot;
            }
        }
        
        [Required()]
        [Column("DSC_GOT_ID_PK",Order=0)]
        public Int64 GotDscIdPk {get;set;}
        
        private GotNatureTrav _gotNatureTrav;
        public virtual GotNatureTrav GotNatureTrav 
        {
            get
            {
                return this._gotNatureTrav;
                
            }
            set
            {
                this._gotNatureTrav = value;
                this.CdTravauxGotCode = this._gotNatureTrav.CdTravauxGotCode;
                this.NatureTravGotNature = this._gotNatureTrav.Nature;
            }
        }
        
        [Required()]
        [Column("NATURE_TRAV_GOT_ID_PK",Order=1)]
        public Int64 GotNatureTravIdPk {get;set;}
        
        private GotCdEntp _gotCdEntp;
        public virtual GotCdEntp GotCdEntp 
        {
            get
            {
                return this._gotCdEntp;
                
            }
            set
            {
                this._gotCdEntp = value;
                this.CdEntpGotEntreprise = this._gotCdEntp.Entreprise;
            }
        }
        
        [Required()]
        [Column("CD_ENTP_GOT_ID_PK",Order=2)]
        public Int64 GotCdEntpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_GOT__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxGotCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_GOT__NATURE",Order=6)]
        [Required()]
        [MaxLength(255)] 
        public String NatureTravGotNature { get; set; }
        
        [Description("Date réception")]
        [Column("DATE_RCP",Order=7)]
        [Required()]
        public DateTime DateRcp { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_GOT__ENTREPRISE",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdEntpGotEntreprise { get; set; }
        
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
