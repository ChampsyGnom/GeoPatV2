using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("HISTO_NOTE_OH",Schema="OH")]
    public partial class OhHistoNote : ModelBase
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
        
        private OhCdOrigin _ohCdOrigin;
        public virtual OhCdOrigin OhCdOrigin 
        {
            get
            {
                return this._ohCdOrigin;
                
            }
            set
            {
                this._ohCdOrigin = value;
                this.CdOriginOhOrigine = this._ohCdOrigin.Origine;
            }
        }
        
        [Required()]
        [Column("CD_ORIGIN_OH_ID_PK",Order=1)]
        public Int64 OhCdOriginIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Date Note")]
        [Column("DATE_NOTE",Order=4)]
        [Required()]
        public DateTime DateNote { get; set; }
        
        [Description("Origine Note")]
        [Column("CD_ORIGIN_OH__ORIGINE",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String CdOriginOhOrigine { get; set; }
        
        [Description("Note Abords Amont")]
        [Column("NOTE1",Order=6)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Protection Amont")]
        [Column("NOTE2",Order=7)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Conduit")]
        [Column("NOTE3",Order=8)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Protection Aval")]
        [Column("NOTE4",Order=9)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Abords Aval")]
        [Column("NOTE5",Order=10)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=11)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=12)]
        public Nullable<int> SecuriteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Securite 
        {
            get
            {
                if (SecuriteValueInt.HasValue) return Convert.ToBoolean(SecuriteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SecuriteValueInt = Convert.ToInt32(value.Value);}
                else {this.SecuriteValueInt =null;}
            }
        }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=13)]
        public Nullable<int> PrioritaireValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Prioritaire 
        {
            get
            {
                if (PrioritaireValueInt.HasValue) return Convert.ToBoolean(PrioritaireValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PrioritaireValueInt = Convert.ToInt32(value.Value);}
                else {this.PrioritaireValueInt =null;}
            }
        }
        
    }
}
