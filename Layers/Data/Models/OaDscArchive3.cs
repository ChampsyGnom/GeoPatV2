using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC__ARCHIVE_3_OA",Schema="OA")]
    public partial class OaDscArchive3 : ModelBase
    {
        private OaArchive3 _oaArchive3;
        public virtual OaArchive3 OaArchive3 
        {
            get
            {
                return this._oaArchive3;
                
            }
            set
            {
                this._oaArchive3 = value;
                this.Archive3OaDateCalc = this._oaArchive3.DateCalc;
            }
        }
        
        [Required()]
        [Column("ARCHIVE_3_OA_ID_PK",Order=0)]
        public Int64 OaArchive3IdPk {get;set;}
        
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
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Date Calcul")]
        [Column("ARCHIVE_3_OA__DATE_CALC",Order=3)]
        [Required()]
        public DateTime Archive3OaDateCalc { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Note 3x")]
        [Column("NOTE3X",Order=5)]
        [Required()]
        [MaxLength(3)] 
        public String Note3x { get; set; }
        
        [Description("Ouvrage écarté")]
        [Column("ECARTE",Order=6)]
        public Nullable<int> EcarteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Ecarte 
        {
            get
            {
                if (EcarteValueInt.HasValue) return Convert.ToBoolean(EcarteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.EcarteValueInt = Convert.ToInt32(value.Value);}
                else {this.EcarteValueInt =null;}
            }
        }
        
    }
}
