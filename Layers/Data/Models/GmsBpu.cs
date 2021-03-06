using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BPU_GMS",Schema="GMS")]
    public partial class GmsBpu : ModelBase
    {
        private GmsCdTravaux _gmsCdTravaux;
        public virtual GmsCdTravaux GmsCdTravaux 
        {
            get
            {
                return this._gmsCdTravaux;
                
            }
            set
            {
                this._gmsCdTravaux = value;
                this.CdTravauxGmsCode = this._gmsCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_GMS_ID_PK",Order=0)]
        public Int64 GmsCdTravauxIdPk {get;set;}
        
        private GmsCdUnite _gmsCdUnite;
        public virtual GmsCdUnite GmsCdUnite 
        {
            get
            {
                return this._gmsCdUnite;
                
            }
            set
            {
                this._gmsCdUnite = value;
                this.CdUniteGmsUnite = this._gmsCdUnite.Unite;
            }
        }
        
        [Column("CD_UNITE_GMS_ID_PK",Order=1)]
        public Nullable<Int64> GmsCdUniteIdPk {get;set;}
        
        public virtual ICollection<GmsPrevision> GmsPrevisions { get; set; }
        
        public virtual ICollection<GmsCdPrecoSprtVst> GmsCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Bordereau")]
        [Column("ID_BPU",Order=3)]
        [Required()]
        public Int64 IdBpu { get; set; }
        
        [Description("Unité")]
        [Column("CD_UNITE_GMS__UNITE",Order=4)]
        [MaxLength(12)] 
        public String CdUniteGmsUnite { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_GMS__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxGmsCode { get; set; }
        
        [Description("Technique")]
        [Column("TECHN",Order=6)]
        [Required()]
        [MaxLength(255)] 
        public String Techn { get; set; }
        
        [Description("Prix Unitaire (€)")]
        [Column("PRIX",Order=7)]
        public Nullable<Int64> Prix { get; set; }
        
        [Description("Date MAJ")]
        [Column("DATE_MAJ",Order=8)]
        public Nullable<DateTime> DateMaj { get; set; }
        
        [Description("Fréquence (mois)")]
        [Column("FREQ",Order=9)]
        public Nullable<Int64> Freq { get; set; }
        
        [Description("Préconisation Visite")]
        [Column("PRECO_VST",Order=10)]
        public Nullable<int> PrecoVstValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> PrecoVst 
        {
            get
            {
                if (PrecoVstValueInt.HasValue) return Convert.ToBoolean(PrecoVstValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PrecoVstValueInt = Convert.ToInt32(value.Value);}
                else {this.PrecoVstValueInt =null;}
            }
        }
        
        [Description("Entretien réalisable")]
        [Column("REALIS_VST",Order=11)]
        public Nullable<int> RealisVstValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> RealisVst 
        {
            get
            {
                if (RealisVstValueInt.HasValue) return Convert.ToBoolean(RealisVstValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealisVstValueInt = Convert.ToInt32(value.Value);}
                else {this.RealisVstValueInt =null;}
            }
        }
        
    }
}
