using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_USER_PROFIL",Schema="PRF")]
    public partial class PrfBmUserProfil : ModelBase
    {
        public virtual PrfBmUser PrfBmUser {get;set;}
        
        public virtual PrfBmProfil PrfBmProfil {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Domaine_Login")]
        [Column("BM_USER__LOGIN",Order=0)]
        [Required()]
        [MaxLength(50)] 
        public String BmUserLogin { get; set; }
        
        [Description("Profil")]
        [Column("BM_PROFIL__PROFIL",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String BmProfilProfil { get; set; }
        
    }
}
