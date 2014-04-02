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
        
        [Required()]
        [Column("CLS_OH_ID_PK",Order=0)]
        public Int64 OhClsIdPk {get;set;}
        
        public virtual OhDoc OhDoc {get;set;}
        
        [Required()]
        [Column("DOC_OH_ID_PK",Order=1)]
        public Int64 OhDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_OH__ID",Order=3)]
        [Required()]
        public Int64 ClsOhId { get; set; }
        
        [Description("Id document")]
        [Column("DOC_OH__ID",Order=4)]
        [Required()]
        public Int64 DocOhId { get; set; }
        
        [Description("Document par défaut")]
        [Column("DEFAUT",Order=5)]
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
        [Column("DOSSIER",Order=6)]
        [MaxLength(15)] 
        public String Dossier { get; set; }
        
    }
}
