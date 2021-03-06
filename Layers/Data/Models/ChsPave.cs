using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PAVE_CHS",Schema="CHS")]
    public partial class ChsPave : ModelBase
    {
        private ChsCdCause _chsCdCause;
        public virtual ChsCdCause ChsCdCause 
        {
            get
            {
                return this._chsCdCause;
                
            }
            set
            {
                this._chsCdCause = value;
                this.CdCauseChsCause = this._chsCdCause.Cause;
            }
        }
        
        [Column("CD_CAUSE_CHS_ID_PK",Order=0)]
        public Nullable<Int64> ChsCdCauseIdPk {get;set;}
        
        private ChsCdEntp _chsCdEntp;
        public virtual ChsCdEntp ChsCdEntp 
        {
            get
            {
                return this._chsCdEntp;
                
            }
            set
            {
                this._chsCdEntp = value;
                this.CdEntpChsEntreprise = this._chsCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_CHS_ID_PK",Order=1)]
        public Nullable<Int64> ChsCdEntpIdPk {get;set;}
        
        private ChsCdTech _chsCdTech;
        public virtual ChsCdTech ChsCdTech 
        {
            get
            {
                return this._chsCdTech;
                
            }
            set
            {
                this._chsCdTech = value;
                this.CdFamTechChsCode = this._chsCdTech.CdFamTechChsCode;
                this.CdTechChsTechnique = this._chsCdTech.Technique;
            }
        }
        
        [Required()]
        [Column("CD_TECH_CHS_ID_PK",Order=2)]
        public Int64 ChsCdTechIdPk {get;set;}
        
        private ChsCdCou _chsCdCou;
        public virtual ChsCdCou ChsCdCou 
        {
            get
            {
                return this._chsCdCou;
                
            }
            set
            {
                this._chsCdCou = value;
                this.CdCouChsCouche = this._chsCdCou.Couche;
            }
        }
        
        [Required()]
        [Column("CD_COU_CHS_ID_PK",Order=3)]
        public Int64 ChsCdCouIdPk {get;set;}
        
        private ChsCdTravaux _chsCdTravaux;
        public virtual ChsCdTravaux ChsCdTravaux 
        {
            get
            {
                return this._chsCdTravaux;
                
            }
            set
            {
                this._chsCdTravaux = value;
                this.CdTravauxChsCode = this._chsCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_CHS_ID_PK",Order=4)]
        public Int64 ChsCdTravauxIdPk {get;set;}
        
        private ChsCdMo _chsCdMo;
        public virtual ChsCdMo ChsCdMo 
        {
            get
            {
                return this._chsCdMo;
                
            }
            set
            {
                this._chsCdMo = value;
                this.CdMoChsMo = this._chsCdMo.Mo;
            }
        }
        
        [Column("CD_MO_CHS_ID_PK",Order=5)]
        public Nullable<Int64> ChsCdMoIdPk {get;set;}
        
        public virtual ICollection<ChsMatPave> ChsMatPaves { get; set; }
        
        public virtual ICollection<ChsSousCouche> ChsSousCouches { get; set; }
        
        public virtual ICollection<ChsPaveVoie> ChsPaveVoies { get; set; }
        
        [Key]
        [Column("ID_PK",Order=6)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Couche")]
        [Column("CD_COU_CHS__COUCHE",Order=7)]
        [Required()]
        [MaxLength(14)] 
        public String CdCouChsCouche { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=8)]
        [Required()]
        public DateTime DateMs { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=9)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=10)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=11)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=12)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_CHS__ENTREPRISE",Order=13)]
        [MaxLength(60)] 
        public String CdEntpChsEntreprise { get; set; }
        
        [Description("Cause")]
        [Column("CD_CAUSE_CHS__CAUSE",Order=14)]
        [MaxLength(60)] 
        public String CdCauseChsCause { get; set; }
        
        [Description("Maître d'oeuvre")]
        [Column("CD_MO_CHS__MO",Order=15)]
        [MaxLength(25)] 
        public String CdMoChsMo { get; set; }
        
        [Description("Famille technique")]
        [Column("CD_FAM_TECH_CHS__CODE",Order=16)]
        [Required()]
        [MaxLength(15)] 
        public String CdFamTechChsCode { get; set; }
        
        [Description("Technique")]
        [Column("CD_TECH_CHS__TECHNIQUE",Order=17)]
        [Required()]
        [MaxLength(12)] 
        public String CdTechChsTechnique { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_CHS__CODE",Order=18)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxChsCode { get; set; }
        
        [Description("Largeur (m)")]
        [Column("LARGEUR",Order=19)]
        public Nullable<Double> Largeur { get; set; }
        
        [Description("Epaisseur (cm)")]
        [Column("EPAIS",Order=20)]
        [Required()]
        public Double Epais { get; set; }
        
        [Description("Granulométrie")]
        [Column("GRANULO",Order=21)]
        [MaxLength(6)] 
        public String Granulo { get; set; }
        
        [Description("Durée de vie")]
        [Column("DUREE_VIE",Order=22)]
        public Nullable<Double> DureeVie { get; set; }
        
        [Description("Archive")]
        [Column("ARCHIVE",Order=23)]
        [MaxLength(255)] 
        public String Archive { get; set; }
        
        [Description("N° Marché")]
        [Column("MARCHE",Order=24)]
        [MaxLength(25)] 
        public String Marche { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=25)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("Montant (€)")]
        [Column("MONTANT",Order=26)]
        public Nullable<Int64> Montant { get; set; }
        
    }
}
