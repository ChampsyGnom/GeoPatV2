using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_BSN",Schema="BSN")]
    public partial class BsnClsDoc : ModelBase
    {
        public virtual BsnCls BsnCls {get;set;}
        
        public virtual BsnDoc BsnDoc {get;set;}
        
        [Key]
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_BSN__ID",Order=0)]
        [Required()]
        public Int64 ClsBsnId { get; set; }
        
        [Key]
        [Description("Id document")]
        [Column("DOC_BSN__ID",Order=1)]
        [Required()]
        public Int64 DocBsnId { get; set; }
        
        [Description("Document par défaut")]
        [Column("DEFAUT",Order=2)]
        public Nullable<int> DefautValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Defaut 
        {
            get
            {
                if (DefautValueInt.HasValue) return Convert.ToBoolean(DefautValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.DefautValueInt = Convert.ToInt32(value.Value);}
                else {this.DefautValueInt =null;}
            }
        }
        
        [Description("Dossier")]
        [Column("DOSSIER",Order=3)]
        [MaxLength(15)] 
        public String Dossier { get; set; }
        
    }
}
