using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_INDIC_CHS",Schema="CHS")]
    public partial class ChsCdIndic : ModelBase
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
        
        public virtual ICollection<ChsCdSeuil> ChsCdSeuils { get; set; }
        
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
        
        [Description("Indicateur")]
        [Column("INDIC",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String Indic { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Unité")]
        [Column("UNITE",Order=5)]
        [MaxLength(8)] 
        public String Unite { get; set; }
        
        [Description("Min")]
        [Column("VMIN",Order=6)]
        public Nullable<Int64> Vmin { get; set; }
        
        [Description("Max")]
        [Column("VMAX",Order=7)]
        public Nullable<Int64> Vmax { get; set; }
        
        [Description("Invalide")]
        [Column("INVALIDE",Order=8)]
        public Nullable<Int64> Invalide { get; set; }
        
        [Description("Format Ind")]
        [Column("FORMATS",Order=9)]
        [MaxLength(12)] 
        public String Formats { get; set; }
        
    }
}
