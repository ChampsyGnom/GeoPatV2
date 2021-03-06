using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MAP",Schema="MAPINFO")]
    public partial class MapinfoTbMap : ModelBase
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
        
        public virtual ICollection<MapinfoTbMapCfg> MapinfoTbMapCfgs { get; set; }
        
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
        [Column("MAP",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String Map { get; set; }
        
        [Description("Titre")]
        [Column("TITRE",Order=6)]
        [Required()]
        [MaxLength(50)] 
        public String Titre { get; set; }
        
        [Description("Type objet")]
        [Column("OBJTYPE",Order=7)]
        public Nullable<Int64> Objtype { get; set; }
        
        [Description("Rang")]
        [Column("RANG",Order=8)]
        public Nullable<Int64> Rang { get; set; }
        
        [Description("Order")]
        [Column("MAP_ORDER",Order=9)]
        [Required()]
        public Int64 MapOrder { get; set; }
        
        [Description("Schéma")]
        [Column("OWNER",Order=10)]
        [Required()]
        [MaxLength(50)] 
        public String Owner { get; set; }
        
        [Description("Est gécodé")]
        [Column("ISGEOCODE",Order=11)]
        public Nullable<Int64> Isgeocode { get; set; }
        
        [Description("Chemin")]
        [Column("CHEMIN",Order=12)]
        [Required()]
        [MaxLength(254)] 
        public String Chemin { get; set; }
        
    }
}
