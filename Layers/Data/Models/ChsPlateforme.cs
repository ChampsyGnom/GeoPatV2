using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PLATEFORME_CHS",Schema="CHS")]
    public partial class ChsPlateforme : ModelBase
    {
        private ChsCdPortance _chsCdPortance;
        public virtual ChsCdPortance ChsCdPortance 
        {
            get
            {
                return this._chsCdPortance;
                
            }
            set
            {
                this._chsCdPortance = value;
                this.CdPortanceChsClasse = this._chsCdPortance.Classe;
            }
        }
        
        [Required()]
        [Column("CD_PORTANCE_CHS_ID_PK",Order=0)]
        public Int64 ChsCdPortanceIdPk {get;set;}
        
        private ChsCdMpa _chsCdMpa;
        public virtual ChsCdMpa ChsCdMpa 
        {
            get
            {
                return this._chsCdMpa;
                
            }
            set
            {
                this._chsCdMpa = value;
                this.CdMpaChsValeur = this._chsCdMpa.Valeur;
            }
        }
        
        [Required()]
        [Column("CD_MPA_CHS_ID_PK",Order=1)]
        public Int64 ChsCdMpaIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
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
        
        [Description("Début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Valeur (MPa)")]
        [Column("CD_MPA_CHS__VALEUR",Order=6)]
        [Required()]
        public Int64 CdMpaChsValeur { get; set; }
        
        [Description("Classe portance")]
        [Column("CD_PORTANCE_CHS__CLASSE",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String CdPortanceChsClasse { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=8)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
    }
}
