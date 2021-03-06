using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREVISION_OA",Schema="OA")]
    public partial class OaPrevision : ModelBase
    {
        private OaCdContrainte _oaCdContrainte;
        public virtual OaCdContrainte OaCdContrainte 
        {
            get
            {
                return this._oaCdContrainte;
                
            }
            set
            {
                this._oaCdContrainte = value;
                this.CdContrainteOaType = this._oaCdContrainte.Type;
            }
        }
        
        [Column("CD_CONTRAINTE_OA_ID_PK",Order=0)]
        public Nullable<Int64> OaCdContrainteIdPk {get;set;}
        
        private OaDsc _oaDsc;
        public virtual OaDsc OaDsc 
        {
            get
            {
                return this._oaDsc;
                
            }
            set
            {
                this._oaDsc = value;
                this.DscOaNumOa = this._oaDsc.NumOa;
            }
        }
        
        [Required()]
        [Column("DSC_OA_ID_PK",Order=1)]
        public Int64 OaDscIdPk {get;set;}
        
        private OaBpu _oaBpu;
        public virtual OaBpu OaBpu 
        {
            get
            {
                return this._oaBpu;
                
            }
            set
            {
                this._oaBpu = value;
                this.BpuOaIdBpu = this._oaBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_OA_ID_PK",Order=2)]
        public Int64 OaBpuIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_OA__ID_BPU",Order=5)]
        [Required()]
        public Int64 BpuOaIdBpu { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEBUT",Order=6)]
        [Required()]
        public DateTime DateDebut { get; set; }
        
        [Description("Contrainte Exploit.")]
        [Column("CD_CONTRAINTE_OA__TYPE",Order=7)]
        [MaxLength(100)] 
        public String CdContrainteOaType { get; set; }
        
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
