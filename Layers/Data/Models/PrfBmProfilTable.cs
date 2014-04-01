using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_PROFIL_TABLE",Schema="PRF")]
    public partial class PrfBmProfilTable
    {
        public virtual PrfBmProfil PrfBmProfil {get;set;}
        
        public virtual PrfBmTable PrfBmTable {get;set;}
        
        [Key]
        [Description("Profil")]
        [Column("BM_PROFIL__PROFIL",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String BmProfilProfil { get; set; }
        
        [Key]
        [Description("Nom")]
        [Column("BM_TABLE__NOM",Order=1)]
        [Required()]
        [MaxLength(30)] 
        public String BmTableNom { get; set; }
        
        [Description("Ecrire")]
        [Column("ECRIRE",Order=2)]
        [Required()]
        public int Ecrire { get; set; }
        [NotMapped]
        public Boolean EcrireBool 
        {
            get
            {
                return Convert.ToBoolean(Ecrire);
            }
            set
            {
                this.Ecrire = Convert.ToInt32(value);
            }
        }
        
        [Description("Importer")]
        [Column("IMPORTER",Order=3)]
        [Required()]
        public int Importer { get; set; }
        [NotMapped]
        public Boolean ImporterBool 
        {
            get
            {
                return Convert.ToBoolean(Importer);
            }
            set
            {
                this.Importer = Convert.ToInt32(value);
            }
        }
        
        [Description("Afficher")]
        [Column("AFFICHER",Order=4)]
        public Nullable<int> Afficher { get; set; }
        
    }
}
