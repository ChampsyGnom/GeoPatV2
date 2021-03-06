using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CONTACT_EQP",Schema="EQP")]
    public partial class EqpContact : ModelBase
    {
        private EqpDoc _eqpDoc;
        public virtual EqpDoc EqpDoc 
        {
            get
            {
                return this._eqpDoc;
                
            }
            set
            {
                this._eqpDoc = value;
                this.DocEqpId = this._eqpDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_EQP_ID_PK",Order=0)]
        public Int64 EqpDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Id document")]
        [Column("DOC_EQP__ID",Order=2)]
        [Required()]
        public Int64 DocEqpId { get; set; }
        
        [Description("Prénom")]
        [Column("GIVENNAME",Order=3)]
        [MaxLength(60)] 
        public String Givenname { get; set; }
        
        [Description("Nom")]
        [Column("SN",Order=4)]
        [MaxLength(60)] 
        public String Sn { get; set; }
        
        [Description("Nom complet")]
        [Column("CN",Order=5)]
        [MaxLength(125)] 
        public String Cn { get; set; }
        
        [Description("Organisation")]
        [Column("O",Order=6)]
        [MaxLength(60)] 
        public String O { get; set; }
        
        [Description("Email")]
        [Column("MAIL",Order=7)]
        [MaxLength(60)] 
        public String Mail { get; set; }
        
        [Description("Téléphone fixe")]
        [Column("TELEPHONENUMBER",Order=8)]
        [MaxLength(20)] 
        public String Telephonenumber { get; set; }
        
        [Description("Téléphone mobile")]
        [Column("MOBILE",Order=9)]
        [MaxLength(20)] 
        public String Mobile { get; set; }
        
        [Description("Fax")]
        [Column("FACSIMILETELEPHONENUMBER",Order=10)]
        [MaxLength(20)] 
        public String Facsimiletelephonenumber { get; set; }
        
        [Description("Adresse")]
        [Column("STREET",Order=11)]
        [MaxLength(60)] 
        public String Street { get; set; }
        
        [Description("Adresse complémentaire")]
        [Column("MOZILLAWORKSTREET2",Order=12)]
        [MaxLength(60)] 
        public String Mozillaworkstreet2 { get; set; }
        
        [Description("Ville")]
        [Column("L",Order=13)]
        [MaxLength(60)] 
        public String L { get; set; }
        
        [Description("Code Postal")]
        [Column("POSTALCODE",Order=14)]
        [MaxLength(12)] 
        public String Postalcode { get; set; }
        
        [Description("Date MAJ")]
        [Column("MODIFYTIMESTAMP",Order=15)]
        public Nullable<DateTime> Modifytimestamp { get; set; }
        
    }
}
