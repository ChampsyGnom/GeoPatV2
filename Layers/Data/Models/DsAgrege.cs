using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("AGREGE_DS",Schema="DS")]
    public partial class DsAgrege : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("AGREGE_DS__CODE")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("AGREGE_DS__LIBELLE")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(200)] 
        public String Libelle { get; set; }
        
        [Description("AGREGE_DS__SRC_AGR")]
        [Column("SRC_AGR",Order=3)]
        [MaxLength(15)] 
        public String SrcAgr { get; set; }
        
        [Description("AGREGE_DS__SRC_INDIC")]
        [Column("SRC_INDIC",Order=4)]
        [MaxLength(15)] 
        public String SrcIndic { get; set; }
        
        [Description("AGREGE_DS__SEUIL1")]
        [Column("SEUIL1",Order=5)]
        public Nullable<Double> Seuil1 { get; set; }
        
        [Description("AGREGE_DS__SEUIL2")]
        [Column("SEUIL2",Order=6)]
        public Nullable<Double> Seuil2 { get; set; }
        
        [Description("AGREGE_DS__SEUIL3")]
        [Column("SEUIL3",Order=7)]
        public Nullable<Double> Seuil3 { get; set; }
        
        [Description("AGREGE_DS__SEUIL4")]
        [Column("SEUIL4",Order=8)]
        public Nullable<Double> Seuil4 { get; set; }
        
        [Description("AGREGE_DS__VALEUR_SENS")]
        [Column("VALEUR_SENS",Order=9)]
        [MaxLength(2)] 
        public String ValeurSens { get; set; }
        
        [Description("AGREGE_DS__VALEUR_ABS")]
        [Column("VALEUR_ABS",Order=10)]
        public Nullable<int> ValeurAbsValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> ValeurAbs 
        {
            get
            {
                if (ValeurAbsValueInt.HasValue) return Convert.ToBoolean(ValeurAbsValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.ValeurAbsValueInt = Convert.ToInt32(value.Value);}
                else {this.ValeurAbsValueInt =null;}
            }
        }
        
    }
}
