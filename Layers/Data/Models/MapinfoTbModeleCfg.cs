using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MODELE_CFG",Schema="MAPINFO")]
    public partial class MapinfoTbModeleCfg : ModelBase
    {
        private MapinfoTbModele _mapinfoTbModele;
        public virtual MapinfoTbModele MapinfoTbModele 
        {
            get
            {
                return this._mapinfoTbModele;
                
            }
            set
            {
                this._mapinfoTbModele = value;
                this.TbModeleModele = this._mapinfoTbModele.Modele;
            }
        }
        
        [Required()]
        [Column("TB_MODELE_ID_PK",Order=0)]
        public Int64 MapinfoTbModeleIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom")]
        [Column("TB_MODELE__MODELE",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String TbModeleModele { get; set; }
        
        [Description("Utilisateur")]
        [Column("USERCODE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Description("Propriété")]
        [Column("CODE_PRP",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Valeur")]
        [Column("VAL_PRP",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String ValPrp { get; set; }
        
    }
}
