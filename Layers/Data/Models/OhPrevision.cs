using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREVISION_OH",Schema="OH")]
    public partial class OhPrevision : ModelBase
    {
        private OhDsc _ohDsc;
        public virtual OhDsc OhDsc 
        {
            get
            {
                return this._ohDsc;
                
            }
            set
            {
                this._ohDsc = value;
                this.DscOhNumOh = this._ohDsc.NumOh;
            }
        }
        
        [Required()]
        [Column("DSC_OH_ID_PK",Order=0)]
        public Int64 OhDscIdPk {get;set;}
        
        private OhBpu _ohBpu;
        public virtual OhBpu OhBpu 
        {
            get
            {
                return this._ohBpu;
                
            }
            set
            {
                this._ohBpu = value;
                this.BpuOhIdBpu = this._ohBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_OH_ID_PK",Order=1)]
        public Int64 OhBpuIdPk {get;set;}
        
        private OhCdContrainte _ohCdContrainte;
        public virtual OhCdContrainte OhCdContrainte 
        {
            get
            {
                return this._ohCdContrainte;
                
            }
            set
            {
                this._ohCdContrainte = value;
                this.CdContrainteOhType = this._ohCdContrainte.Type;
            }
        }
        
        [Column("CD_CONTRAINTE_OH_ID_PK",Order=2)]
        public Nullable<Int64> OhCdContrainteIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_OH__ID_BPU",Order=5)]
        [Required()]
        public Int64 BpuOhIdBpu { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEBUT",Order=6)]
        [Required()]
        public DateTime DateDebut { get; set; }
        
        [Description("Contrainte exploit")]
        [Column("CD_CONTRAINTE_OH__TYPE",Order=7)]
        [MaxLength(100)] 
        public String CdContrainteOhType { get; set; }
        
        [Description("Date fin")]
        [Column("DATE_FIN",Order=8)]
        public Nullable<DateTime> DateFin { get; set; }
        
        [Description("Coûts (€)")]
        [Column("MONTANT",Order=9)]
        public Nullable<Int64> Montant { get; set; }
        
        [Description("Date demande publication")]
        [Column("DATE_DEM_PUB",Order=10)]
        public Nullable<DateTime> DateDemPub { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=11)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("Réalisé")]
        [Column("REALISE",Order=12)]
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
        
    }
}
