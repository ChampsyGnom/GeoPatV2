using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREVISION_GMS",Schema="GMS")]
    public partial class GmsPrevision : ModelBase
    {
        private GmsDsc _gmsDsc;
        public virtual GmsDsc GmsDsc 
        {
            get
            {
                return this._gmsDsc;
                
            }
            set
            {
                this._gmsDsc = value;
                this.DscGmsNumGms = this._gmsDsc.NumGms;
            }
        }
        
        [Required()]
        [Column("DSC_GMS_ID_PK",Order=0)]
        public Int64 GmsDscIdPk {get;set;}
        
        private GmsCdContrainte _gmsCdContrainte;
        public virtual GmsCdContrainte GmsCdContrainte 
        {
            get
            {
                return this._gmsCdContrainte;
                
            }
            set
            {
                this._gmsCdContrainte = value;
                this.CdContrainteGmsType = this._gmsCdContrainte.Type;
            }
        }
        
        [Column("CD_CONTRAINTE_GMS_ID_PK",Order=1)]
        public Nullable<Int64> GmsCdContrainteIdPk {get;set;}
        
        private GmsBpu _gmsBpu;
        public virtual GmsBpu GmsBpu 
        {
            get
            {
                return this._gmsBpu;
                
            }
            set
            {
                this._gmsBpu = value;
                this.BpuGmsIdBpu = this._gmsBpu.IdBpu;
            }
        }
        
        [Required()]
        [Column("BPU_GMS_ID_PK",Order=2)]
        public Int64 GmsBpuIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_GMS__ID_BPU",Order=5)]
        [Required()]
        public Int64 BpuGmsIdBpu { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEBUT",Order=6)]
        [Required()]
        public DateTime DateDebut { get; set; }
        
        [Description("Contrainte exploit")]
        [Column("CD_CONTRAINTE_GMS__TYPE",Order=7)]
        [MaxLength(100)] 
        public String CdContrainteGmsType { get; set; }
        
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
