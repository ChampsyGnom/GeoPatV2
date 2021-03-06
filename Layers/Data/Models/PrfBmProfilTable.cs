using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_PROFIL_TABLE",Schema="PRF")]
    public partial class PrfBmProfilTable : ModelBase
    {
        private PrfBmProfil _prfBmProfil;
        public virtual PrfBmProfil PrfBmProfil 
        {
            get
            {
                return this._prfBmProfil;
                
            }
            set
            {
                this._prfBmProfil = value;
                this.BmProfilProfil = this._prfBmProfil.Profil;
            }
        }
        
        [Required()]
        [Column("BM_PROFIL_ID_PK",Order=0)]
        public Int64 PrfBmProfilIdPk {get;set;}
        
        private PrfBmTable _prfBmTable;
        public virtual PrfBmTable PrfBmTable 
        {
            get
            {
                return this._prfBmTable;
                
            }
            set
            {
                this._prfBmTable = value;
                this.BmTableNom = this._prfBmTable.Nom;
            }
        }
        
        [Required()]
        [Column("BM_TABLE_ID_PK",Order=1)]
        public Int64 PrfBmTableIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Profil")]
        [Column("BM_PROFIL__PROFIL",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String BmProfilProfil { get; set; }
        
        [Description("Nom")]
        [Column("BM_TABLE__NOM",Order=4)]
        [Required()]
        [MaxLength(30)] 
        public String BmTableNom { get; set; }
        
        [Description("Ecrire")]
        [Column("ECRIRE",Order=5)]
        [Required()]
        public int EcrireValueInt { get; set; }
        [NotMapped]
        public Boolean Ecrire 
        {
            get
            {
                return Convert.ToBoolean(EcrireValueInt);
            }
            set
            {
                this.EcrireValueInt = Convert.ToInt32(value);
            }
        }
        
        [Description("Importer")]
        [Column("IMPORTER",Order=6)]
        [Required()]
        public int ImporterValueInt { get; set; }
        [NotMapped]
        public Boolean Importer 
        {
            get
            {
                return Convert.ToBoolean(ImporterValueInt);
            }
            set
            {
                this.ImporterValueInt = Convert.ToInt32(value);
            }
        }
        
        [Description("Afficher")]
        [Column("AFFICHER",Order=7)]
        public Nullable<int> AfficherValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Afficher 
        {
            get
            {
                if (AfficherValueInt.HasValue) return Convert.ToBoolean(AfficherValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.AfficherValueInt = Convert.ToInt32(value.Value);}
                else {this.AfficherValueInt =null;}
            }
        }
        
    }
}
