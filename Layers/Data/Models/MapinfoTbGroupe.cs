using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_GROUPE",Schema="MAPINFO")]
    public partial class MapinfoTbGroupe : ModelBase
    {
        private MapinfoTbTemplate _mapinfoTbTemplate;
        public virtual MapinfoTbTemplate MapinfoTbTemplate 
        {
            get
            {
                return this._mapinfoTbTemplate;
                
            }
            set
            {
                this._mapinfoTbTemplate = value;
                this.TbModeleModele = this._mapinfoTbTemplate.TbModeleModele;
                this.TbTemplateTpl = this._mapinfoTbTemplate.Tpl;
            }
        }
        
        [Required()]
        [Column("TB_TEMPLATE_ID_PK",Order=0)]
        public Int64 MapinfoTbTemplateIdPk {get;set;}
        
        public virtual ICollection<MapinfoTbMap> MapinfoTbMaps { get; set; }
        
        public virtual ICollection<MapinfoTbGroupeCfg> MapinfoTbGroupeCfgs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom")]
        [Column("TB_MODELE__MODELE",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String TbModeleModele { get; set; }
        
        [Description("Template")]
        [Column("TB_TEMPLATE__TPL",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String TbTemplateTpl { get; set; }
        
        [Description("Groupe")]
        [Column("GROUPE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String Groupe { get; set; }
        
        [Description("Titre")]
        [Column("TITRE",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String Titre { get; set; }
        
        [Description("Rang")]
        [Column("RANG",Order=6)]
        [Required()]
        public Int64 Rang { get; set; }
        
        [Description("Chemin")]
        [Column("CHEMIN",Order=7)]
        [MaxLength(254)] 
        public String Chemin { get; set; }
        
        [Description("Afficher")]
        [Column("BOARDVISIBLE",Order=8)]
        public Nullable<Int64> Boardvisible { get; set; }
        
    }
}
