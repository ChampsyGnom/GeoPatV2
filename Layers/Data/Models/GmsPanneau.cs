using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PANNEAU_GMS",Schema="GMS")]
    public partial class GmsPanneau : ModelBase
    {
        private GmsCdPanneau _gmsCdPanneau;
        public virtual GmsCdPanneau GmsCdPanneau 
        {
            get
            {
                return this._gmsCdPanneau;
                
            }
            set
            {
                this._gmsCdPanneau = value;
                this.CdPanneauGmsType = this._gmsCdPanneau.Type;
            }
        }
        
        [Column("CD_PANNEAU_GMS_ID_PK",Order=0)]
        public Nullable<Int64> GmsCdPanneauIdPk {get;set;}
        
        private GmsCdPosPan _gmsCdPosPan;
        public virtual GmsCdPosPan GmsCdPosPan 
        {
            get
            {
                return this._gmsCdPosPan;
                
            }
            set
            {
                this._gmsCdPosPan = value;
                this.CdPosPanGmsPosit = this._gmsCdPosPan.Posit;
            }
        }
        
        [Required()]
        [Column("CD_POS_PAN_GMS_ID_PK",Order=1)]
        public Int64 GmsCdPosPanIdPk {get;set;}
        
        private GmsCdEntp _gmsCdEntp;
        public virtual GmsCdEntp GmsCdEntp 
        {
            get
            {
                return this._gmsCdEntp;
                
            }
            set
            {
                this._gmsCdEntp = value;
                this.CdEntpGmsEntreprise = this._gmsCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_GMS_ID_PK",Order=2)]
        public Nullable<Int64> GmsCdEntpIdPk {get;set;}
        
        private GmsCdInterface _gmsCdInterface;
        public virtual GmsCdInterface GmsCdInterface 
        {
            get
            {
                return this._gmsCdInterface;
                
            }
            set
            {
                this._gmsCdInterface = value;
                this.CdInterfaceGmsType = this._gmsCdInterface.Type;
            }
        }
        
        [Column("CD_INTERFACE_GMS_ID_PK",Order=3)]
        public Nullable<Int64> GmsCdInterfaceIdPk {get;set;}
        
        private GmsCdFournisseur _gmsCdFournisseur;
        public virtual GmsCdFournisseur GmsCdFournisseur 
        {
            get
            {
                return this._gmsCdFournisseur;
                
            }
            set
            {
                this._gmsCdFournisseur = value;
                this.CdFournisseurGmsNom = this._gmsCdFournisseur.Nom;
            }
        }
        
        [Column("CD_FOURNISSEUR_GMS_ID_PK",Order=4)]
        public Nullable<Int64> GmsCdFournisseurIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=5)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=6)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Position")]
        [Column("CD_POS_PAN_GMS__POSIT",Order=7)]
        [Required()]
        [MaxLength(4)] 
        public String CdPosPanGmsPosit { get; set; }
        
        [Description("Type")]
        [Column("CD_PANNEAU_GMS__TYPE",Order=8)]
        [MaxLength(60)] 
        public String CdPanneauGmsType { get; set; }
        
        [Description("Type de liaison GMS")]
        [Column("CD_INTERFACE_GMS__TYPE",Order=9)]
        [MaxLength(60)] 
        public String CdInterfaceGmsType { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_GMS__ENTREPRISE",Order=10)]
        [MaxLength(60)] 
        public String CdEntpGmsEntreprise { get; set; }
        
        [Description("Fournisseur")]
        [Column("CD_FOURNISSEUR_GMS__NOM",Order=11)]
        [MaxLength(60)] 
        public String CdFournisseurGmsNom { get; set; }
        
        [Description("Mise en service")]
        [Column("DATE_MS",Order=12)]
        [Required()]
        public DateTime DateMs { get; set; }
        
        [Description("Hauteur panneau (m)")]
        [Column("HAUTEUR",Order=13)]
        public Nullable<Double> Hauteur { get; set; }
        
        [Description("Largeur (m)")]
        [Column("LARGEUR",Order=14)]
        public Nullable<Double> Largeur { get; set; }
        
        [Description("Mention")]
        [Column("MENTION",Order=15)]
        [MaxLength(255)] 
        public String Mention { get; set; }
        
        [Description("Réserve %")]
        [Column("RESERVE",Order=16)]
        public Nullable<Int64> Reserve { get; set; }
        
    }
}
