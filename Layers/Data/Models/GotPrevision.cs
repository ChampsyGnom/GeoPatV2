using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREVISION_GOT",Schema="GOT")]
    public partial class GotPrevision : ModelBase
    {
        private GotBpu _gotBpu;
        public virtual GotBpu GotBpu 
        {
            get
            {
                return this._gotBpu;
                
            }
            set
            {
                this._gotBpu = value;
                this.BpuGotIdBpu = this._gotBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_GOT_ID_PK",Order=0)]
        public Int64 GotBpuIdPk {get;set;}
        
        private GotCdContrainte _gotCdContrainte;
        public virtual GotCdContrainte GotCdContrainte 
        {
            get
            {
                return this._gotCdContrainte;
                
            }
            set
            {
                this._gotCdContrainte = value;
                this.CdContrainteGotType = this._gotCdContrainte.Type;
            }
        }
        
        [Column("CD_CONTRAINTE_GOT_ID_PK",Order=1)]
        public Nullable<Int64> GotCdContrainteIdPk {get;set;}
        
        private GotDsc _gotDsc;
        public virtual GotDsc GotDsc 
        {
            get
            {
                return this._gotDsc;
                
            }
            set
            {
                this._gotDsc = value;
                this.DscGotNumGot = this._gotDsc.NumGot;
            }
        }
        
        [Required()]
        [Column("DSC_GOT_ID_PK",Order=2)]
        public Int64 GotDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Bordereau")]
        [Column("BPU_GOT__ID_BPU",Order=4)]
        [Required()]
        public Int64 BpuGotIdBpu { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=5)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEBUT",Order=6)]
        [Required()]
        public DateTime DateDebut { get; set; }
        
        [Description("Contrainte exploit")]
        [Column("CD_CONTRAINTE_GOT__TYPE",Order=7)]
        [MaxLength(100)] 
        public String CdContrainteGotType { get; set; }
        
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
