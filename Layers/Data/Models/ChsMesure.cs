using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MESURE_CHS",Schema="CHS")]
    public partial class ChsMesure : ModelBase
    {
        private ChsDetailCamp _chsDetailCamp;
        public virtual ChsDetailCamp ChsDetailCamp 
        {
            get
            {
                return this._chsDetailCamp;
                
            }
            set
            {
                this._chsDetailCamp = value;
                this.CdCdMesureChsAgr = this._chsDetailCamp.CdCdMesureChsAgr;
                this.CdMesureChsAgr = this._chsDetailCamp.CdMesureChsAgr;
                this.CdIndicChsIndic = this._chsDetailCamp.CdIndicChsIndic;
                this.CampChsSection = this._chsDetailCamp.CampChsSection;
                this.CampChsAnnee = this._chsDetailCamp.CampChsAnnee;
                this.CampChsLiaison = this._chsDetailCamp.CampChsLiaison;
                this.CampChsSens = this._chsDetailCamp.CampChsSens;
                this.CampChsVoie = this._chsDetailCamp.CampChsVoie;
            }
        }
        
        [Required()]
        [Column("DETAIL_CAMP_CHS_ID_PK",Order=0)]
        public Int64 ChsDetailCampIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Ind_Code Agr")]
        [Column("CD__CD_MESURE_CHS__AGR",Order=2)]
        [Required()]
        [MaxLength(12)] 
        public String CdCdMesureChsAgr { get; set; }
        
        [Description("Code Agr")]
        [Column("CD_MESURE_CHS__AGR",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String CdMesureChsAgr { get; set; }
        
        [Description("Indicateur")]
        [Column("CD_INDIC_CHS__INDIC",Order=4)]
        [Required()]
        [MaxLength(12)] 
        public String CdIndicChsIndic { get; set; }
        
        [Description("Num Section")]
        [Column("CAMP_CHS__SECTION",Order=5)]
        [Required()]
        [MaxLength(15)] 
        public String CampChsSection { get; set; }
        
        [Description("Année")]
        [Column("CAMP_CHS__ANNEE",Order=6)]
        [Required()]
        public Int64 CampChsAnnee { get; set; }
        
        [Description("Liaison")]
        [Column("CAMP_CHS__LIAISON",Order=7)]
        [Required()]
        [MaxLength(15)] 
        public String CampChsLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CAMP_CHS__SENS",Order=8)]
        [Required()]
        [MaxLength(6)] 
        public String CampChsSens { get; set; }
        
        [Description("Voie2")]
        [Column("CAMP_CHS__VOIE",Order=9)]
        [Required()]
        [MaxLength(6)] 
        public String CampChsVoie { get; set; }
        
        [Description("Voie")]
        [Column("VOIE",Order=10)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=11)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=12)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Valeur")]
        [Column("VALEUR",Order=13)]
        public Nullable<Double> Valeur { get; set; }
        
    }
}
