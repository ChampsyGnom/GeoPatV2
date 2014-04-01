using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EXT_OH",Schema="OH")]
    public partial class OhCdExt : ModelBase
    {
        public virtual ICollection<OhDsc> OhDscs { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        [Key]
        [Description("Type exutoire")]
        [Column("TYPE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Exutoire OH")]
        [Column("IS_OH",Order=1)]
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
        
        [Description("Exétoire Bassin")]
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
        
    }
}
