using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_GROUPE_CFG",Schema="MAPINFO")]
    public partial class MapinfoTbGroupeCfg : ModelBase
    {
        private MapinfoTbGroupe _mapinfoTbGroupe;
        public virtual MapinfoTbGroupe MapinfoTbGroupe 
        {
            get
            {
                return this._mapinfoTbGroupe;
                
            }
            set
            {
                this._mapinfoTbGroupe = value;
                this.TbModeleModele = this._mapinfoTbGroupe.TbModeleModele;
                this.TbTemplateTpl = this._mapinfoTbGroupe.TbTemplateTpl;
                this.TbGroupeGroupe = this._mapinfoTbGroupe.Groupe;
            }
        }
        
        [Required()]
        [Column("TB_GROUPE_ID_PK",Order=0)]
        public Int64 MapinfoTbGroupeIdPk {get;set;}
        
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
        
        [Description("Utilisateur")]
        [Column("USERCODE",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Description("Propriété")]
        [Column("CODE_PRP",Order=6)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Valeur")]
        [Column("VAL_PRP",Order=7)]
        [MaxLength(254)] 
        public String ValPrp { get; set; }
        
    }
}
