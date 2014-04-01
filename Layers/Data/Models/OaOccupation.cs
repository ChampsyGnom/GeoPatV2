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
        public virtual OaDsc OaDsc {get;set;}
        
        public virtual OaCdOccupant OaCdOccupant {get;set;}
        
        public virtual OaCdOccup OaCdOccup {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Nom occupant")]
        [Column("CD_OCCUPANT_OA__NOM",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupantOaNom { get; set; }
        
        [Description("Type Occupation")]
        [Column("CD_OCCUP_OA__TYPE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdOccupOaType { get; set; }
        
        [Description("Date Début")]
        [Column("DATE_MS",Order=3)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Date Fin")]
        [Column("DATE_FV",Order=4)]
        public Nullable<DateTime> DateFv { get; set; }
        
        [Description("Traversé")]
        [Column("TRAV",Order=5)]
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
        [Column("NUM_CONV",Order=6)]
        [MaxLength(60)] 
        public String NumConv { get; set; }
        
        [Description("Commentaires")]
        [Column("OBSERV",Order=7)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
