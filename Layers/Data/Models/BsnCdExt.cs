using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EXT_BSN",Schema="BSN")]
    public partial class BsnCdExt : ModelBase
    {
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Exutoire")]
        [Column("TYPE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Bassin")]
        [Column("IS_BSN",Order=2)]
        [Required()]
        public int IsBsnValueInt { get; set; }
        [NotMapped]
        public Boolean IsBsn 
        {
            get
            {
                return Convert.ToBoolean(IsBsnValueInt);
            }
            set
            {
                this.IsBsnValueInt = Convert.ToInt32(value);
            }
        }
        
        [Description("Ouvrage hydraulique")]
        [Column("IS_OH",Order=3)]
        [Required()]
        public int IsOhValueInt { get; set; }
        [NotMapped]
        public Boolean IsOh 
        {
            get
            {
                return Convert.ToBoolean(IsOhValueInt);
            }
            set
            {
                this.IsOhValueInt = Convert.ToInt32(value);
            }
        }
        
    }
}
