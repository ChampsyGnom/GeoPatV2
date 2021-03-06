using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TECH_CHS",Schema="CHS")]
    public partial class ChsCdTech : ModelBase
    {
        private ChsCdFamTech _chsCdFamTech;
        public virtual ChsCdFamTech ChsCdFamTech 
        {
            get
            {
                return this._chsCdFamTech;
                
            }
            set
            {
                this._chsCdFamTech = value;
                this.CdFamTechChsCode = this._chsCdFamTech.Code;
            }
        }
        
        [Required()]
        [Column("CD_FAM_TECH_CHS_ID_PK",Order=0)]
        public Int64 ChsCdFamTechIdPk {get;set;}
        
        public virtual ICollection<ChsPave> ChsPaves { get; set; }
        
        public virtual ICollection<ChsSousCouche> ChsSousCouches { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille technique")]
        [Column("CD_FAM_TECH_CHS__CODE",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String CdFamTechChsCode { get; set; }
        
        [Description("Technique")]
        [Column("TECHNIQUE",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String Technique { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Garantie (mois)")]
        [Column("GARANTIE",Order=5)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=6)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
