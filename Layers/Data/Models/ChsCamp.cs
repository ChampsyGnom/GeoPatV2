using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_CHS",Schema="CHS")]
    public partial class ChsCamp : ModelBase
    {
        private ChsCdMesure _chsCdMesure;
        public virtual ChsCdMesure ChsCdMesure 
        {
            get
            {
                return this._chsCdMesure;
                
            }
            set
            {
                this._chsCdMesure = value;
                this.CdMesureChsAgr = this._chsCdMesure.Agr;
            }
        }
        
        [Required()]
        [Column("CD_MESURE_CHS_ID_PK",Order=0)]
        public Int64 ChsCdMesureIdPk {get;set;}
        
        public virtual ICollection<ChsDetailCamp> ChsDetailCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code Agr")]
        [Column("CD_MESURE_CHS__AGR",Order=2)]
        [Required()]
        [MaxLength(12)] 
        public String CdMesureChsAgr { get; set; }
        
        [Description("Num Section")]
        [Column("SECTION",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String Section { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=4)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=5)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Voie")]
        [Column("VOIE",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
        [Description("Date génération")]
        [Column("DATEG",Order=8)]
        public Nullable<DateTime> Dateg { get; set; }
        
        [Description("Date maxi retour")]
        [Column("DATEC",Order=9)]
        [Required()]
        public DateTime Datec { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=10)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=11)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Date de chargement")]
        [Column("DATE_LOAD",Order=12)]
        public Nullable<DateTime> DateLoad { get; set; }
        
        [Description("Date des mesures")]
        [Column("DATE_MES",Order=13)]
        public Nullable<DateTime> DateMes { get; set; }
        
        [Description("Pas mesure")]
        [Column("PAS",Order=14)]
        public Nullable<Int64> Pas { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=15)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
