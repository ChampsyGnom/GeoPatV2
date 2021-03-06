using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_TEMPLATE_CFG",Schema="MAPINFO")]
    public partial class MapinfoTbTemplateCfg : ModelBase
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
        
        [Description("Utilisateur")]
        [Column("USERCODE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Description("Propriétée")]
        [Column("CODE_PRP",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String CodePrp { get; set; }
        
        [Description("Valeur")]
        [Column("VAL_PRP",Order=6)]
        [Required()]
        [MaxLength(254)] 
        public String ValPrp { get; set; }
        
    }
}
