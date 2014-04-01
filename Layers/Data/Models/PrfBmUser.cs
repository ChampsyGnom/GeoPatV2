using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_USER",Schema="PRF")]
    public partial class PrfBmUser
    {
        public virtual ICollection<PrfBmUserProfil> PrfBmUserProfils { get; set; }
        
        [Key]
        [Description("Domaine_Login")]
        [Column("LOGIN",Order=0)]
        [Required()]
        [MaxLength(50)] 
        public String Login { get; set; }
        
        [Description("Nom")]
        [Column("NOM",Order=1)]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
        [Description("Prénom")]
        [Column("PRENOM",Order=2)]
        [MaxLength(60)] 
        public String Prenom { get; set; }
        
        [Description("Passwords")]
        [Column("PASSWORDS",Order=3)]
        [MaxLength(100)] 
        public String Passwords { get; set; }
        
        [Description("Famille de découpage")]
        [Column("FAM_DEC_INF",Order=4)]
        [MaxLength(6)] 
        public String FamDecInf { get; set; }
        
        [Description("Code de découpage")]
        [Column("CD_DEC_INF",Order=5)]
        [MaxLength(15)] 
        public String CdDecInf { get; set; }
        
    }
}
