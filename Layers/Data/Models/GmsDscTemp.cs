using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_TEMP_GMS",Schema="GMS")]
    public partial class GmsDscTemp : ModelBase
    {
        private GmsCdPosMat _gmsCdPosMat;
        public virtual GmsCdPosMat GmsCdPosMat 
        {
            get
            {
                return this._gmsCdPosMat;
                
            }
            set
            {
                this._gmsCdPosMat = value;
                this.CdPosMatGmsPosit = this._gmsCdPosMat.Posit;
            }
        }
        
        [Required()]
        [Column("CD_POS_MAT_GMS_ID_PK",Order=0)]
        public Int64 GmsCdPosMatIdPk {get;set;}
        
        private GmsCdProtec _gmsCdProtec;
        public virtual GmsCdProtec GmsCdProtec 
        {
            get
            {
                return this._gmsCdProtec;
                
            }
            set
            {
                this._gmsCdProtec = value;
                this.CdProtecGmsProtec = this._gmsCdProtec.Protec;
            }
        }
        
        [Column("CD_PROTEC_GMS_ID_PK",Order=1)]
        public Nullable<Int64> GmsCdProtecIdPk {get;set;}
        
        private GmsCdAcces _gmsCdAcces;
        public virtual GmsCdAcces GmsCdAcces 
        {
            get
            {
                return this._gmsCdAcces;
                
            }
            set
            {
                this._gmsCdAcces = value;
                this.CdAccesGmsType = this._gmsCdAcces.Type;
            }
        }
        
        [Column("CD_ACCES_GMS_ID_PK",Order=2)]
        public Nullable<Int64> GmsCdAccesIdPk {get;set;}
        
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
        
        private GmsCdFam _gmsCdFam;
        public virtual GmsCdFam GmsCdFam 
        {
            get
            {
                return this._gmsCdFam;
                
            }
            set
            {
                this._gmsCdFam = value;
                this.CdFamGmsFamille = this._gmsCdFam.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_GMS_ID_PK",Order=5)]
        public Int64 GmsCdFamIdPk {get;set;}
        
        private GmsCdType _gmsCdType;
        public virtual GmsCdType GmsCdType 
        {
            get
            {
                return this._gmsCdType;
                
            }
            set
            {
                this._gmsCdType = value;
                this.CdTypeGmsType = this._gmsCdType.Type;
            }
        }
        
        [Column("CD_TYPE_GMS_ID_PK",Order=6)]
        public Nullable<Int64> GmsCdTypeIdPk {get;set;}
        
        private GmsCdPoutre _gmsCdPoutre;
        public virtual GmsCdPoutre GmsCdPoutre 
        {
            get
            {
                return this._gmsCdPoutre;
                
            }
            set
            {
                this._gmsCdPoutre = value;
                this.CdPoutreGmsType = this._gmsCdPoutre.Type;
            }
        }
        
        [Column("CD_POUTRE_GMS_ID_PK",Order=7)]
        public Nullable<Int64> GmsCdPoutreIdPk {get;set;}
        
        private GmsCdPoteau _gmsCdPoteau;
        public virtual GmsCdPoteau GmsCdPoteau 
        {
            get
            {
                return this._gmsCdPoteau;
                
            }
            set
            {
                this._gmsCdPoteau = value;
                this.CdPoteauGmsType = this._gmsCdPoteau.Type;
            }
        }
        
        [Column("CD_POTEAU_GMS_ID_PK",Order=8)]
        public Nullable<Int64> GmsCdPoteauIdPk {get;set;}
        
        private GmsCdAncrage _gmsCdAncrage;
        public virtual GmsCdAncrage GmsCdAncrage 
        {
            get
            {
                return this._gmsCdAncrage;
                
            }
            set
            {
                this._gmsCdAncrage = value;
                this.CdAncrageGmsType = this._gmsCdAncrage.Type;
            }
        }
        
        [Column("CD_ANCRAGE_GMS_ID_PK",Order=9)]
        public Nullable<Int64> GmsCdAncrageIdPk {get;set;}
        
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
        
        [Column("CD_ENTP_GMS_ID_PK",Order=10)]
        public Nullable<Int64> GmsCdEntpIdPk {get;set;}
        
        private GmsCamp _gmsCamp;
        public virtual GmsCamp GmsCamp 
        {
            get
            {
                return this._gmsCamp;
                
            }
            set
            {
                this._gmsCamp = value;
                this.CampGmsIdCamp = this._gmsCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_GMS_ID_PK",Order=11)]
        public Int64 GmsCampIdPk {get;set;}
        
        private GmsDsc _gmsDsc;
        public virtual GmsDsc GmsDsc 
        {
            get
            {
                return this._gmsDsc;
                
            }
            set
            {
                this._gmsDsc = value;
                this.DscGmsNumGms = this._gmsDsc.NumGms;
            }
        }
        
        [Column("DSC_GMS_ID_PK",Order=12)]
        public Nullable<Int64> GmsDscIdPk {get;set;}
        
        public virtual ICollection<GmsInspTmp> GmsInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=13)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=14)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("NUM_GMS",Order=15)]
        [Required()]
        [MaxLength(17)] 
        public String NumGms { get; set; }
        
        [Description("Fournisseur")]
        [Column("CD_FOURNISSEUR_GMS__NOM",Order=16)]
        [MaxLength(60)] 
        public String CdFournisseurGmsNom { get; set; }
        
        [Description("Position")]
        [Column("CD_POS_MAT_GMS__POSIT",Order=17)]
        [Required()]
        [MaxLength(4)] 
        public String CdPosMatGmsPosit { get; set; }
        
        [Description("Type de liaison GMS")]
        [Column("CD_INTERFACE_GMS__TYPE",Order=18)]
        [MaxLength(60)] 
        public String CdInterfaceGmsType { get; set; }
        
        [Description("No GMS2")]
        [Column("DSC_GMS__NUM_GMS",Order=19)]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_GMS__ENTREPRISE",Order=20)]
        [MaxLength(60)] 
        public String CdEntpGmsEntreprise { get; set; }
        
        [Description("Famille")]
        [Column("CD_FAM_GMS__FAMILLE",Order=21)]
        [Required()]
        [MaxLength(20)] 
        public String CdFamGmsFamille { get; set; }
        
        [Description("Type Accès visite")]
        [Column("CD_ACCES_GMS__TYPE",Order=22)]
        [MaxLength(60)] 
        public String CdAccesGmsType { get; set; }
        
        [Description("Type Ouvrage")]
        [Column("CD_TYPE_GMS__TYPE",Order=23)]
        [MaxLength(60)] 
        public String CdTypeGmsType { get; set; }
        
        [Description("Type protection")]
        [Column("CD_PROTEC_GMS__PROTEC",Order=24)]
        [MaxLength(60)] 
        public String CdProtecGmsProtec { get; set; }
        
        [Description("Type ancrage")]
        [Column("CD_ANCRAGE_GMS__TYPE",Order=25)]
        [MaxLength(60)] 
        public String CdAncrageGmsType { get; set; }
        
        [Description("Type Poteau")]
        [Column("CD_POTEAU_GMS__TYPE",Order=26)]
        [MaxLength(60)] 
        public String CdPoteauGmsType { get; set; }
        
        [Description("Type Traverse")]
        [Column("CD_POUTRE_GMS__TYPE",Order=27)]
        [MaxLength(60)] 
        public String CdPoutreGmsType { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=28)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=29)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR")]
        [Column("ABS_DEB",Order=30)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=31)]
        [MaxLength(17)] 
        public String NumExploit { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM_USAGE",Order=32)]
        [MaxLength(255)] 
        public String NomUsage { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=33)]
        [Required()]
        public DateTime DateMs { get; set; }
        
        [Description("Gabarit sous structure (m)")]
        [Column("HAUT",Order=34)]
        public Nullable<Double> Haut { get; set; }
        
        [Description("Gabarit sous panneau (m)")]
        [Column("TIRAIR",Order=35)]
        public Nullable<Double> Tirair { get; set; }
        
        [Description("Résistance au vent (km/h)")]
        [Column("VENT",Order=36)]
        public Nullable<Int64> Vent { get; set; }
        
        [Description("dimension Massif Ancrage (cm)")]
        [Column("ANCRAGE",Order=37)]
        [MaxLength(60)] 
        public String Ancrage { get; set; }
        
        [Description("Portée (m)")]
        [Column("LARG",Order=38)]
        public Nullable<Double> Larg { get; set; }
        
        [Description("Nbr traverse")]
        [Column("TRAVERSE",Order=39)]
        public Nullable<Int64> Traverse { get; set; }
        
        [Description("Nbr élément de traverse")]
        [Column("ELEMENT",Order=40)]
        public Nullable<Int64> Element { get; set; }
        
        [Description("Nbr poteaux")]
        [Column("NB_POTEAUX",Order=41)]
        public Nullable<Int64> NbPoteaux { get; set; }
        
        [Description("Eclairage")]
        [Column("ECLAIRAGE",Order=42)]
        public Nullable<int> EclairageValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Eclairage 
        {
            get
            {
                if (EclairageValueInt.HasValue) return Convert.ToBoolean(EclairageValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.EclairageValueInt = Convert.ToInt32(value.Value);}
                else {this.EclairageValueInt =null;}
            }
        }
        
        [Description("Accès condamné")]
        [Column("CONDAMNE",Order=43)]
        public Nullable<int> CondamneValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Condamne 
        {
            get
            {
                if (CondamneValueInt.HasValue) return Convert.ToBoolean(CondamneValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.CondamneValueInt = Convert.ToInt32(value.Value);}
                else {this.CondamneValueInt =null;}
            }
        }
        
        [Description("Note Ancrage")]
        [Column("NOTE1",Order=44)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Structure")]
        [Column("NOTE2",Order=45)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Fixation")]
        [Column("NOTE3",Order=46)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Panneau")]
        [Column("NOTE4",Order=47)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Accessibilité")]
        [Column("NOTE5",Order=48)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=49)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=50)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=51)]
        public Nullable<int> SecuriteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Securite 
        {
            get
            {
                if (SecuriteValueInt.HasValue) return Convert.ToBoolean(SecuriteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SecuriteValueInt = Convert.ToInt32(value.Value);}
                else {this.SecuriteValueInt =null;}
            }
        }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=52)]
        public Nullable<int> PrioritaireValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Prioritaire 
        {
            get
            {
                if (PrioritaireValueInt.HasValue) return Convert.ToBoolean(PrioritaireValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PrioritaireValueInt = Convert.ToInt32(value.Value);}
                else {this.PrioritaireValueInt =null;}
            }
        }
        
        [Description("Prochaine Inspection")]
        [Column("PROSURV_ANNEE",Order=53)]
        public Nullable<Int64> ProsurvAnnee { get; set; }
        
        [Description("Dernière Inspection")]
        [Column("DERN_INSP",Order=54)]
        public Nullable<DateTime> DernInsp { get; set; }
        
        [Description("Dernière Visite")]
        [Column("DERN_VST",Order=55)]
        public Nullable<DateTime> DernVst { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=56)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
        [Description("Archive")]
        [Column("ARCHIVE",Order=57)]
        [MaxLength(255)] 
        public String Archive { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=58)]
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=59)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=60)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=61)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=62)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=63)]
        public Nullable<int> TerrainValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Terrain 
        {
            get
            {
                if (TerrainValueInt.HasValue) return Convert.ToBoolean(TerrainValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.TerrainValueInt = Convert.ToInt32(value.Value);}
                else {this.TerrainValueInt =null;}
            }
        }
        
    }
}
