using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_OH",Schema="OH")]
    public partial class OhClsDoc : ModelBase
    {
        public virtual OhCls OhCls {get;set;}
        
        public virtual OhDoc OhDoc {get;set;}
        
        [Key]
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_OH__ID",Order=0)]
        [Required()]
        public Int64 ClsOhId { get; set; }
        
        [Key]
        [Description("Id document")]
        [Column("DOC_OH__ID",Order=1)]
        [Required()]
        public Int64 DocOhId { get; set; }
        
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
