using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("HISTO_NOTE_GMS",Schema="GMS")]
    public partial class GmsHistoNote : ModelBase
    {
        private GmsCdOrigin _gmsCdOrigin;
        public virtual GmsCdOrigin GmsCdOrigin 
        {
            get
            {
                return this._gmsCdOrigin;
                
            }
            set
            {
                this._gmsCdOrigin = value;
                this.CdOriginGmsOrigine = this._gmsCdOrigin.Origine;
            }
        }
        
        [Required()]
        [Column("CD_ORIGIN_GMS_ID_PK",Order=0)]
        public Int64 GmsCdOriginIdPk {get;set;}
        
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
        [Column("DSC_GMS_ID_PK",Order=1)]
        public Int64 GmsDscIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Date Note")]
        [Column("DATE_NOTE",Order=4)]
        [Required()]
        public DateTime DateNote { get; set; }
        
        [Description("Origine Note")]
        [Column("CD_ORIGIN_GMS__ORIGINE",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String CdOriginGmsOrigine { get; set; }
        
        [Description("Note Ancrage")]
        [Column("NOTE1",Order=6)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Structure")]
        [Column("NOTE2",Order=7)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Fixation")]
        [Column("NOTE3",Order=8)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Panneau")]
        [Column("NOTE4",Order=9)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Accessibilité")]
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
