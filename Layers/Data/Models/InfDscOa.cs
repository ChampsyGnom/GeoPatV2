using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_OA_INF",Schema="INF")]
    public partial class InfDscOa : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("IDOA")]
        [Column("CODE_OA",Order=1)]
        [Required()]
        public Int64 CodeOa { get; set; }
        
        [Description("NumOA")]
        [Column("NUM_OA",Order=2)]
        [MaxLength(40)] 
        public String NumOa { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR_OA")]
        [Column("PR_OA",Order=5)]
        [MaxLength(10)] 
        public String PrOa { get; set; }
        
        [Description("Localisation")]
        [Column("ABS_DEB",Order=6)]
        public Nullable<Int64> AbsDeb { get; set; }
        
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=7)]
        [MaxLength(80)] 
        public String NumExploit { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM_USAGE",Order=8)]
        [MaxLength(100)] 
        public String NomUsage { get; set; }
        
        [Description("Famille")]
        [Column("FAMILLE",Order=9)]
        [MaxLength(80)] 
        public String Famille { get; set; }
        
        [Description("Type d'ouvrage")]
        [Column("TYPE_OUVRAGE",Order=10)]
        [MaxLength(80)] 
        public String TypeOuvrage { get; set; }
        
        [Description("Matériaux")]
        [Column("MATERIAUX",Order=11)]
        [MaxLength(80)] 
        public String Materiaux { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=12)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Nbre Tabliers")]
        [Column("NBRE_TABLIERS",Order=13)]
        public Nullable<Int64> NbreTabliers { get; set; }
        
        [Description("Nbre Travées")]
        [Column("NBRE_TRAVEE",Order=14)]
        public Nullable<Int64> NbreTravee { get; set; }
        
        [Description("Gabarit (m)")]
        [Column("GABARIT",Order=15)]
        public Nullable<Double> Gabarit { get; set; }
        
        [Description("Longueur (m)")]
        [Column("LONGUEUR",Order=16)]
        public Nullable<Double> Longueur { get; set; }
        
        [Description("Largeur (m)")]
        [Column("LARGEUR",Order=17)]
        public Nullable<Double> Largeur { get; set; }
        
        [Description("Section courante")]
        [Column("SECT_COURANTE",Order=18)]
        public Nullable<int> SectCouranteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> SectCourante 
        {
            get
            {
                if (SectCouranteValueInt.HasValue) return Convert.ToBoolean(SectCouranteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SectCouranteValueInt = Convert.ToInt32(value.Value);}
                else {this.SectCouranteValueInt =null;}
            }
        }
        
        [Description("Note IQOA")]
        [Column("IQOA",Order=19)]
        [MaxLength(8)] 
        public String Iqoa { get; set; }
        
        [Description("Niveau d'urgence")]
        [Column("NOTE_URGENCE",Order=20)]
        public Nullable<Double> NoteUrgence { get; set; }
        
    }
}
