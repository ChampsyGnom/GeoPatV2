using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EXT_BSN",Schema="BSN")]
    public partial class BsnCdExt
    {
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        [Key]
        [Description("Exutoire")]
        [Column("TYPE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Bassin")]
        [Column("IS_BSN",Order=1)]
        [Required()]
        public int IsBsn { get; set; }
        [NotMapped]
        public Boolean IsBsnBool 
        {
            get
            {
                return Convert.ToBoolean(IsBsn);
            }
            set
            {
                this.IsBsn = Convert.ToInt32(value);
            }
        }
        
        [Description("Ouvrage hydraulique")]
        [Column("IS_OH",Order=2)]
        [Required()]
        public int IsOh { get; set; }
        [NotMapped]
        public Boolean IsOhBool 
        {
            get
            {
                return Convert.ToBoolean(IsOh);
            }
            set
            {
                this.IsOh = Convert.ToInt32(value);
            }
        }
        
    }
}
