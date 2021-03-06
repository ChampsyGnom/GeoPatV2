using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("HISTO_NOTE_OA",Schema="OA")]
    public partial class OaHistoNote : ModelBase
    {
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
        [Column("DSC_OA_ID_PK",Order=0)]
        public Int64 OaDscIdPk {get;set;}
        
        private OaCdOrigin _oaCdOrigin;
        public virtual OaCdOrigin OaCdOrigin 
        {
            get
            {
                return this._oaCdOrigin;
                
            }
            set
            {
                this._oaCdOrigin = value;
                this.CdOriginOaOrigine = this._oaCdOrigin.Origine;
            }
        }
        
        [Required()]
        [Column("CD_ORIGIN_OA_ID_PK",Order=1)]
        public Int64 OaCdOriginIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Date Note")]
        [Column("DATE_NOTE",Order=4)]
        [Required()]
        public DateTime DateNote { get; set; }
        
        [Description("Origine")]
        [Column("CD_ORIGIN_OA__ORIGINE",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String CdOriginOaOrigine { get; set; }
        
        [Description("Note IQOA")]
        [Column("NOTE_IQOA",Order=6)]
        [MaxLength(3)] 
        public String NoteIqoa { get; set; }
        
        [Description("Note Appuis")]
        [Column("NOTE1",Order=7)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Tablier")]
        [Column("NOTE2",Order=8)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Equipement")]
        [Column("NOTE3",Order=9)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=10)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=11)]
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
        
        [Description("Urgence Traitement")]
        [Column("PRIORITAIRE",Order=12)]
        [Required()]
        public int PrioritaireValueInt { get; set; }
        [NotMapped]
        public Boolean Prioritaire 
        {
            get
            {
                return Convert.ToBoolean(PrioritaireValueInt);
            }
            set
            {
                this.PrioritaireValueInt = Convert.ToInt32(value);
            }
        }
        
    }
}
