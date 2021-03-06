using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("OCCUPATION_OA",Schema="OA")]
    public partial class OaOccupation : ModelBase
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
        
        private OaCdOccupant _oaCdOccupant;
        public virtual OaCdOccupant OaCdOccupant 
        {
            get
            {
                return this._oaCdOccupant;
                
            }
            set
            {
                this._oaCdOccupant = value;
                this.CdOccupantOaNom = this._oaCdOccupant.Nom;
            }
        }
        
        [Required()]
        [Column("CD_OCCUPANT_OA_ID_PK",Order=1)]
        public Int64 OaCdOccupantIdPk {get;set;}
        
        private OaCdOccup _oaCdOccup;
        public virtual OaCdOccup OaCdOccup 
        {
            get
            {
                return this._oaCdOccup;
                
            }
            set
            {
                this._oaCdOccup = value;
                this.CdOccupOaType = this._oaCdOccup.Type;
            }
        }
        
        [Required()]
        [Column("CD_OCCUP_OA_ID_PK",Order=2)]
        public Int64 OaCdOccupIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Nom occupant")]
        [Column("CD_OCCUPANT_OA__NOM",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupantOaNom { get; set; }
        
        [Description("Type Occupation")]
        [Column("CD_OCCUP_OA__TYPE",Order=6)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupOaType { get; set; }
        
        [Description("Date Début")]
        [Column("DATE_MS",Order=7)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Date Fin")]
        [Column("DATE_FV",Order=8)]
        public Nullable<DateTime> DateFv { get; set; }
        
        [Description("Traversé")]
        [Column("TRAV",Order=9)]
        public Nullable<int> TravValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Trav 
        {
            get
            {
                if (TravValueInt.HasValue) return Convert.ToBoolean(TravValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.TravValueInt = Convert.ToInt32(value.Value);}
                else {this.TravValueInt =null;}
            }
        }
        
        [Description("N° convention")]
        [Column("NUM_CONV",Order=10)]
        [MaxLength(60)] 
        public String NumConv { get; set; }
        
        [Description("Commentaires")]
        [Column("OBSERV",Order=11)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
