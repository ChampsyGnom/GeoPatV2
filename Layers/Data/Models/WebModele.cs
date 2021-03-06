using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MODELE_WEB",Schema="WEB")]
    public partial class WebModele : ModelBase
    {
        private WebCdModele _webCdModele;
        public virtual WebCdModele WebCdModele 
        {
            get
            {
                return this._webCdModele;
                
            }
            set
            {
                this._webCdModele = value;
                this.CdModeleWebCode = this._webCdModele.Code;
            }
        }
        
        [Required()]
        [Column("CD_MODELE_WEB_ID_PK",Order=0)]
        public Int64 WebCdModeleIdPk {get;set;}
        
        public virtual ICollection<WebModeleWebNode> WebModeleWebNodes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du modèle")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code du type de modèle (SIG_REF_DETAIL SIG_REF_SCHEMA)")]
        [Column("CD_MODELE_WEB__CODE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CdModeleWebCode { get; set; }
        
        [Description("Libellé du modèle")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(255)] 
        public String Libelle { get; set; }
        
        [Description("Public")]
        [Column("IS_PUBLIC",Order=5)]
        public Nullable<int> IsPublicValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> IsPublic 
        {
            get
            {
                if (IsPublicValueInt.HasValue) return Convert.ToBoolean(IsPublicValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.IsPublicValueInt = Convert.ToInt32(value.Value);}
                else {this.IsPublicValueInt =null;}
            }
        }
        
    }
}
