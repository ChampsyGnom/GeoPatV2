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
        
        [Required()]
        [Column("BM_USER_ID_PK",Order=0)]
        public Int64 PrfBmUserIdPk {get;set;}
        
        public virtual PrfBmProfil PrfBmProfil {get;set;}
        
        [Required()]
        [Column("BM_PROFIL_ID_PK",Order=1)]
        public Int64 PrfBmProfilIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Domaine_Login")]
        [Column("BM_USER__LOGIN",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String BmUserLogin { get; set; }
        
        [Description("Profil")]
        [Column("BM_PROFIL__PROFIL",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String BmProfilProfil { get; set; }
        
    }
}
