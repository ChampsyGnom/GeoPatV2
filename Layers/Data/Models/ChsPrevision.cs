using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREVISION_CHS",Schema="CHS")]
    public partial class ChsPrevision : ModelBase
    {
        private ChsCdContrainte _chsCdContrainte;
        public virtual ChsCdContrainte ChsCdContrainte 
        {
            get
            {
                return this._chsCdContrainte;
                
            }
            set
            {
                this._chsCdContrainte = value;
                this.CdContrainteChsType = this._chsCdContrainte.Type;
            }
        }
        
        [Column("CD_CONTRAINTE_CHS_ID_PK",Order=0)]
        public Nullable<Int64> ChsCdContrainteIdPk {get;set;}
        
        private ChsBpu _chsBpu;
        public virtual ChsBpu ChsBpu 
        {
            get
            {
                return this._chsBpu;
                
            }
            set
            {
                this._chsBpu = value;
                this.BpuChsCode = this._chsBpu.Code;
            }
        }
        
        [Required()]
        [Column("BPU_CHS_ID_PK",Order=1)]
        public Int64 ChsBpuIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Technique")]
        [Column("BPU_CHS__CODE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String BpuChsCode { get; set; }
        
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
        
        [Description("Début")]
        [Column("ABS_DEB",Order=8)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Contrainte")]
        [Column("CD_CONTRAINTE_CHS__TYPE",Order=9)]
        [MaxLength(100)] 
        public String CdContrainteChsType { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=10)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Coût (€)")]
        [Column("MONTANT",Order=11)]
        public Nullable<Int64> Montant { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEBUT",Order=12)]
        public Nullable<DateTime> DateDebut { get; set; }
        
        [Description("Date fin")]
        [Column("DATE_FIN",Order=13)]
        public Nullable<DateTime> DateFin { get; set; }
        
        [Description("Date demande publication")]
        [Column("DATE_DEM_PUB",Order=14)]
        public Nullable<DateTime> DateDemPub { get; set; }
        
        [Description("Réalisé")]
        [Column("REALISE",Order=15)]
        public Nullable<int> RealiseValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Realise 
        {
            get
            {
                if (RealiseValueInt.HasValue) return Convert.ToBoolean(RealiseValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealiseValueInt = Convert.ToInt32(value.Value);}
                else {this.RealiseValueInt =null;}
            }
        }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=16)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
