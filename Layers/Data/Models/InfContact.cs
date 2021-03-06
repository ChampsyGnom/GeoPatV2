using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CONTACT_INF",Schema="INF")]
    public partial class InfContact : ModelBase
    {
        private InfDoc _infDoc;
        public virtual InfDoc InfDoc 
        {
            get
            {
                return this._infDoc;
                
            }
            set
            {
                this._infDoc = value;
                this.DocInfId = this._infDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_INF_ID_PK",Order=0)]
        public Int64 InfDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identificant(cpt)")]
        [Column("DOC_INF__ID",Order=2)]
        [Required()]
        public Int64 DocInfId { get; set; }
        
        [Description("Prénom")]
        [Column("givenName",Order=3)]
        [MaxLength(60)] 
        public String Givenname { get; set; }
        
        [Description("Nom")]
        [Column("sn",Order=4)]
        [MaxLength(60)] 
        public String Sn { get; set; }
        
        [Description("Nom complet")]
        [Column("cn",Order=5)]
        [MaxLength(125)] 
        public String Cn { get; set; }
        
        [Description("Organisation")]
        [Column("o",Order=6)]
        [MaxLength(60)] 
        public String O { get; set; }
        
        [Description("Email")]
        [Column("mail",Order=7)]
        [MaxLength(60)] 
        public String Mail { get; set; }
        
        [Description("Téléphone fixe")]
        [Column("telephoneNumber",Order=8)]
        [MaxLength(20)] 
        public String Telephonenumber { get; set; }
        
        [Description("Téléphone mobile")]
        [Column("mobile",Order=9)]
        [MaxLength(20)] 
        public String Mobile { get; set; }
        
        [Description("Fax")]
        [Column("facsimiletelephonenumber",Order=10)]
        [MaxLength(20)] 
        public String Facsimiletelephonenumber { get; set; }
        
        [Description("Adresse")]
        [Column("street",Order=11)]
        [MaxLength(60)] 
        public String Street { get; set; }
        
        [Description("Adresse complémentaire")]
        [Column("mozillaWorkStreet2",Order=12)]
        [MaxLength(60)] 
        public String Mozillaworkstreet2 { get; set; }
        
        [Description("Ville")]
        [Column("l",Order=13)]
        [MaxLength(60)] 
        public String L { get; set; }
        
        [Description("Code Postal")]
        [Column("postalCode",Order=14)]
        [MaxLength(12)] 
        public String Postalcode { get; set; }
        
        [Description("Date MAJ")]
        [Column("modifytimestamp",Order=15)]
        public Nullable<DateTime> Modifytimestamp { get; set; }
        
    }
}
