using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("HISTO_NOTE_GOT",Schema="GOT")]
    public partial class GotHistoNote : ModelBase
    {
        private GotCdOrigin _gotCdOrigin;
        public virtual GotCdOrigin GotCdOrigin 
        {
            get
            {
                return this._gotCdOrigin;
                
            }
            set
            {
                this._gotCdOrigin = value;
                this.CdOriginGotOrigine = this._gotCdOrigin.Origine;
            }
        }
        
        [Required()]
        [Column("CD_ORIGIN_GOT_ID_PK",Order=0)]
        public Int64 GotCdOriginIdPk {get;set;}
        
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
        [Column("DSC_GOT_ID_PK",Order=1)]
        public Int64 GotDscIdPk {get;set;}
        
        private GotCdRisque _gotCdRisque;
        public virtual GotCdRisque GotCdRisque 
        {
            get
            {
                return this._gotCdRisque;
                
            }
            set
            {
                this._gotCdRisque = value;
                this.CdRisqueGotRisque = this._gotCdRisque.Risque;
            }
        }
        
        [Column("CD_RISQUE_GOT_ID_PK",Order=2)]
        public Nullable<Int64> GotCdRisqueIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Date Note")]
        [Column("DATE_NOTE",Order=5)]
        [Required()]
        public DateTime DateNote { get; set; }
        
        [Description("Origine Note")]
        [Column("CD_ORIGIN_GOT__ORIGINE",Order=6)]
        [Required()]
        [MaxLength(20)] 
        public String CdOriginGotOrigine { get; set; }
        
        [Description("Note Risque")]
        [Column("CD_RISQUE_GOT__RISQUE",Order=7)]
        [MaxLength(3)] 
        public String CdRisqueGotRisque { get; set; }
        
        [Description("Note Plateforme 1")]
        [Column("NOTE1",Order=8)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Plateforme 2")]
        [Column("NOTE2",Order=9)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Talus 1")]
        [Column("NOTE3",Order=10)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Talus 2")]
        [Column("NOTE4",Order=11)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Environnement")]
        [Column("NOTE5",Order=12)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=13)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=14)]
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
        [Column("PRIORITAIRE",Order=15)]
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
