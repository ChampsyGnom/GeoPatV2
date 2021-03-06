using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_TEMPLATE",Schema="MAPINFO")]
    public partial class MapinfoTbTemplate : ModelBase
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
        
        public virtual ICollection<MapinfoTbTemplateCfg> MapinfoTbTemplateCfgs { get; set; }
        
        public virtual ICollection<MapinfoTbGroupe> MapinfoTbGroupes { get; set; }
        
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
        [Column("TPL",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Tpl { get; set; }
        
        [Description("Titre")]
        [Column("TITRE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String Titre { get; set; }
        
        [Description("Rang")]
        [Column("RANG",Order=5)]
        [Required()]
        public Int64 Rang { get; set; }
        
        [Description("Chemin")]
        [Column("CHEMIN",Order=6)]
        [MaxLength(254)] 
        public String Chemin { get; set; }
        
        [Description("Est géocodé")]
        [Column("ISGEOCODE",Order=7)]
        public Nullable<Int64> Isgeocode { get; set; }
        
    }
}
