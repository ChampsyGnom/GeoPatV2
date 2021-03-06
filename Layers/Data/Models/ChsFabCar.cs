using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("FAB_CAR_CHS",Schema="CHS")]
    public partial class ChsFabCar : ModelBase
    {
        private ChsCdOrig _chsCdOrig;
        public virtual ChsCdOrig ChsCdOrig 
        {
            get
            {
                return this._chsCdOrig;
                
            }
            set
            {
                this._chsCdOrig = value;
                this.CdMatChsCode = this._chsCdOrig.CdMatChsCode;
                this.CdOrigChsCode = this._chsCdOrig.Code;
            }
        }
        
        [Required()]
        [Column("CD_ORIG_CHS_ID_PK",Order=0)]
        public Int64 ChsCdOrigIdPk {get;set;}
        
        public virtual ICollection<ChsMatPave> ChsMatPaves { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nature de matériaux")]
        [Column("CD_MAT_CHS__CODE",Order=2)]
        [Required()]
        [MaxLength(12)] 
        public String CdMatChsCode { get; set; }
        
        [Description("Type fabricant/carrière")]
        [Column("CD_ORIG_CHS__CODE",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String CdOrigChsCode { get; set; }
        
        [Description("Fabricant/carrières")]
        [Column("NOM",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
    }
}
