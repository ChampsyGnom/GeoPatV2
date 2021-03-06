using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MAP_CFG",Schema="MAPINFO")]
    public partial class MapinfoTbMapCfg : ModelBase
    {
        private MapinfoTbMap _mapinfoTbMap;
        public virtual MapinfoTbMap MapinfoTbMap 
        {
            get
            {
                return this._mapinfoTbMap;
                
            }
            set
            {
                this._mapinfoTbMap = value;
                this.TbModeleModele = this._mapinfoTbMap.TbModeleModele;
                this.TbTemplateTpl = this._mapinfoTbMap.TbTemplateTpl;
                this.TbGroupeGroupe = this._mapinfoTbMap.TbGroupeGroupe;
                this.TbMapMap = this._mapinfoTbMap.Map;
            }
        }
        
        [Required()]
        [Column("TB_MAP_ID_PK",Order=0)]
        public Int64 MapinfoTbMapIdPk {get;set;}
        
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
        [Column("TB_GROUPE__GROUPE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String TbGroupeGroupe { get; set; }
        
        [Description("Carte")]
        [Column("TB_MAP__MAP",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String TbMapMap { get; set; }
        
        [Description("Utilisateur")]
        [Column("USERCODE",Order=6)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Description("Propriétée")]
        [Column("CODE_PRP",Order=7)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Valeur")]
        [Column("VAL_PRP",Order=8)]
        [Required()]
        [MaxLength(254)] 
        public String ValPrp { get; set; }
        
    }
}
