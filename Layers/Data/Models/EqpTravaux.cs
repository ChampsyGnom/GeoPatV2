using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAVAUX_EQP",Schema="EQP")]
    public partial class EqpTravaux : ModelBase
    {
        private EqpNatureTrav _eqpNatureTrav;
        public virtual EqpNatureTrav EqpNatureTrav 
        {
            get
            {
                return this._eqpNatureTrav;
                
            }
            set
            {
                this._eqpNatureTrav = value;
                this.CdTravauxEqpCode = this._eqpNatureTrav.CdTravauxEqpCode;
                this.NatureTravEqpNature = this._eqpNatureTrav.Nature;
            }
        }
        
        [Required()]
        [Column("NATURE_TRAV_EQP_ID_PK",Order=0)]
        public Int64 EqpNatureTravIdPk {get;set;}
        
        private EqpCdEntp _eqpCdEntp;
        public virtual EqpCdEntp EqpCdEntp 
        {
            get
            {
                return this._eqpCdEntp;
                
            }
            set
            {
                this._eqpCdEntp = value;
                this.CdEntpEqpEntreprise = this._eqpCdEntp.Entreprise;
            }
        }
        
        [Required()]
        [Column("CD_ENTP_EQP_ID_PK",Order=1)]
        public Int64 EqpCdEntpIdPk {get;set;}
        
        private EqpCdType _eqpCdType;
        public virtual EqpCdType EqpCdType 
        {
            get
            {
                return this._eqpCdType;
                
            }
            set
            {
                this._eqpCdType = value;
                this.CdTypeEqpTypeEquip = this._eqpCdType.TypeEquip;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_EQP_ID_PK",Order=2)]
        public Int64 EqpCdTypeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_EQP__CODE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxEqpCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE_TRAV_EQP__NATURE",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String NatureTravEqpNature { get; set; }
        
        [Description("Type d'équipement")]
        [Column("CD_TYPE_EQP__TYPE_EQUIP",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String CdTypeEqpTypeEquip { get; set; }
        
        [Description("Identifiant Travaux")]
        [Column("ID_TRAV",Order=7)]
        [Required()]
        public Int64 IdTrav { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("OUVRAGE",Order=9)]
        [MaxLength(30)] 
        public String Ouvrage { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=10)]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=11)]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Position")]
        [Column("POSITION",Order=12)]
        [MaxLength(60)] 
        public String Position { get; set; }
        
        [Description("du PR")]
        [Column("ABS_DEB",Order=13)]
        public Nullable<Int64> AbsDeb { get; set; }
        
        [Description("au PR")]
        [Column("ABS_FIN",Order=14)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date Réception")]
        [Column("DATE_RCP",Order=15)]
        public Nullable<DateTime> DateRcp { get; set; }
        
        [Description("Coût (€)")]
        [Column("COUT",Order=16)]
        public Nullable<Int64> Cout { get; set; }
        
        [Description("Fin de garantie")]
        [Column("DATE_FIN_GAR",Order=17)]
        public Nullable<DateTime> DateFinGar { get; set; }
        
        [Description("No Marché")]
        [Column("MARCHE",Order=18)]
        [MaxLength(25)] 
        public String Marche { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=19)]
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
    }
}
