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
        private BsnDsc _bsnDsc;
        public virtual BsnDsc BsnDsc 
        {
            get
            {
                return this._bsnDsc;
                
            }
            set
            {
                this._bsnDsc = value;
                this.DscBsnNumBsn = this._bsnDsc.NumBsn;
            }
        }
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=0)]
        public Int64 BsnDscIdPk {get;set;}
        
        private BsnNatureTrav _bsnNatureTrav;
        public virtual BsnNatureTrav BsnNatureTrav 
        {
            get
            {
                return this._bsnNatureTrav;
                
            }
            set
            {
                this._bsnNatureTrav = value;
                this.CdTravauxBsnCode = this._bsnNatureTrav.CdTravauxBsnCode;
                this.NatureTravBsnNature = this._bsnNatureTrav.Nature;
            }
        }
        
        [Required()]
        [Column("NATURE_TRAV_BSN_ID_PK",Order=1)]
        public Int64 BsnNatureTravIdPk {get;set;}
        
        private BsnCdEntp _bsnCdEntp;
        public virtual BsnCdEntp BsnCdEntp 
        {
            get
            {
                return this._bsnCdEntp;
                
            }
            set
            {
                this._bsnCdEntp = value;
                this.CdEntpBsnEntreprise = this._bsnCdEntp.Entreprise;
            }
        }
        
        [Required()]
        [Column("CD_ENTP_BSN_ID_PK",Order=2)]
        public Int64 BsnCdEntpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_BSN__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxBsnCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_BSN__NATURE",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String NatureTravBsnNature { get; set; }
        
        [Description("Date Réception")]
        [Column("DATE_RCP",Order=7)]
        [Required()]
        public DateTime DateRcp { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_BSN__ENTREPRISE",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdEntpBsnEntreprise { get; set; }
        
        [Description("Fin de garantie")]
        [Column("DATE_FIN_GAR",Order=9)]
        public Nullable<DateTime> DateFinGar { get; set; }
        
        [Description("Coût")]
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
