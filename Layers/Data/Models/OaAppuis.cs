using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("APPUIS_OA",Schema="OA")]
    public partial class OaAppuis : ModelBase
    {
        private OaDsc _oaDsc;
        public virtual OaDsc OaDsc 
        {
            get
            {
                return this._oaDsc;
                
            }
            set
            {
                this._oaDsc = value;
                this.DscOaNumOa = this._oaDsc.NumOa;
            }
        }
        
        [Required()]
        [Column("DSC_OA_ID_PK",Order=0)]
        public Int64 OaDscIdPk {get;set;}
        
        private OaCdFamAppui _oaCdFamAppui;
        public virtual OaCdFamAppui OaCdFamAppui 
        {
            get
            {
                return this._oaCdFamAppui;
                
            }
            set
            {
                this._oaCdFamAppui = value;
                this.CdFamAppuiOaFamApp = this._oaCdFamAppui.FamApp;
            }
        }
        
        [Required()]
        [Column("CD_FAM_APPUI_OA_ID_PK",Order=1)]
        public Int64 OaCdFamAppuiIdPk {get;set;}
        
        private OaCdAppui _oaCdAppui;
        public virtual OaCdAppui OaCdAppui 
        {
            get
            {
                return this._oaCdAppui;
                
            }
            set
            {
                this._oaCdAppui = value;
                this.CdAppuiOaApp = this._oaCdAppui.App;
            }
        }
        
        [Required()]
        [Column("CD_APPUI_OA_ID_PK",Order=2)]
        public Int64 OaCdAppuiIdPk {get;set;}
        
        private OaCdAppAppui _oaCdAppAppui;
        public virtual OaCdAppAppui OaCdAppAppui 
        {
            get
            {
                return this._oaCdAppAppui;
                
            }
            set
            {
                this._oaCdAppAppui = value;
                this.CdAppAppuiOaAppui = this._oaCdAppAppui.Appui;
            }
        }
        
        [Required()]
        [Column("CD_APP_APPUI_OA_ID_PK",Order=3)]
        public Int64 OaCdAppAppuiIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Famille d'appuis")]
        [Column("CD_FAM_APPUI_OA__FAM_APP",Order=6)]
        [Required()]
        [MaxLength(60)] 
        public String CdFamAppuiOaFamApp { get; set; }
        
        [Description("Type d'appui")]
        [Column("CD_APPUI_OA__APP",Order=7)]
        [Required()]
        [MaxLength(60)] 
        public String CdAppuiOaApp { get; set; }
        
        [Description("Type app appui")]
        [Column("CD_APP_APPUI_OA__APPUI",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String CdAppAppuiOaAppui { get; set; }
        
        [Description("Nbr app. appui")]
        [Column("NBR_APPAREIL",Order=9)]
        public Nullable<Int64> NbrAppareil { get; set; }
        
        [Description("Date MS app appui")]
        [Column("DATE_MS",Order=10)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=11)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
