using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_SEUIL_CHS",Schema="CHS")]
    public partial class ChsCdSeuil : ModelBase
    {
        private ChsCdIndic _chsCdIndic;
        public virtual ChsCdIndic ChsCdIndic 
        {
            get
            {
                return this._chsCdIndic;
                
            }
            set
            {
                this._chsCdIndic = value;
                this.CdMesureChsAgr = this._chsCdIndic.CdMesureChsAgr;
                this.CdIndicChsIndic = this._chsCdIndic.Indic;
            }
        }
        
        [Required()]
        [Column("CD_INDIC_CHS_ID_PK",Order=0)]
        public Int64 ChsCdIndicIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code Agr")]
        [Column("CD_MESURE_CHS__AGR",Order=2)]
        [Required()]
        [MaxLength(12)] 
        public String CdMesureChsAgr { get; set; }
        
        [Description("Indicateur")]
        [Column("CD_INDIC_CHS__INDIC",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String CdIndicChsIndic { get; set; }
        
        [Description("< Seuil 1")]
        [Column("SEUIL1",Order=4)]
        [Required()]
        public Double Seuil1 { get; set; }
        
        [Description("< Seuil 2")]
        [Column("SEUIL2",Order=5)]
        public Nullable<Double> Seuil2 { get; set; }
        
        [Description("< Seuil 3")]
        [Column("SEUIL3",Order=6)]
        public Nullable<Double> Seuil3 { get; set; }
        
        [Description(">= Seuil 4")]
        [Column("SEUIL4",Order=7)]
        public Nullable<Double> Seuil4 { get; set; }
        
        [Description("Sens interprétation")]
        [Column("INTERP",Order=8)]
        [Required()]
        [MaxLength(1)] 
        public String Interp { get; set; }
        
        [Description("Valeur Absolue")]
        [Column("VALABS",Order=9)]
        [Required()]
        public int ValabsValueInt { get; set; }
        [NotMapped]
        public Boolean Valabs 
        {
            get
            {
                return Convert.ToBoolean(ValabsValueInt);
            }
            set
            {
                this.ValabsValueInt = Convert.ToInt32(value);
            }
        }
        
        [Description("Zone Homogène")]
        [Column("ZONE",Order=10)]
        public Nullable<int> ZoneValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Zone 
        {
            get
            {
                if (ZoneValueInt.HasValue) return Convert.ToBoolean(ZoneValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.ZoneValueInt = Convert.ToInt32(value.Value);}
                else {this.ZoneValueInt =null;}
            }
        }
        
        [Description("U Alpha")]
        [Column("U_ALPHA",Order=11)]
        public Nullable<Double> UAlpha { get; set; }
        
        [Description("Caractéristique Ecart")]
        [Column("CARACT_ECART",Order=12)]
        public Nullable<Double> CaractEcart { get; set; }
        
    }
}
