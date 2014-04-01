using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbMapGeoStyleViewModel : ViewModelBase<MapinfoTbMapGeoStyle>
    {
        public MapinfoTbMapGeoStyleViewModel(MapinfoTbMapGeoStyle model) : base(model)
        {
        }
        public override void Read()
        {
            this.Map=this.Model.Map;
            this.Username=this.Model.Username;
            this.Representation=this.Model.Representation;
            this.Color=this.Model.Color;
            this.Width=this.Model.Width;
            this.Font=this.Model.Font;
            this.Ascii=this.Model.Ascii;
            this.Style=this.Model.Style;
            this.Interleaved=this.Model.Interleaved;
            this.Bordercolor=this.Model.Bordercolor;
            this.Borderstyle=this.Model.Borderstyle;
            this.Regionbackground=this.Model.Regionbackground;
        }
        public override void Write()
        {
            this.Model.Map=this.Map;
            this.Model.Username=this.Username;
            this.Model.Representation=this.Representation;
            this.Model.Color=this.Color;
            this.Model.Width=this.Width;
            this.Model.Font=this.Font;
            this.Model.Ascii=this.Ascii;
            this.Model.Style=this.Style;
            this.Model.Interleaved=this.Interleaved;
            this.Model.Bordercolor=this.Bordercolor;
            this.Model.Borderstyle=this.Borderstyle;
            this.Model.Regionbackground=this.Regionbackground;
        }
        private String _map;
        [DisplayName("Map")]
        public String Map
        {
            get
            {
                return this._map;
            }
            set
            {
                this._map = value;
                RaisePropertyChange("Map");
            }
        }
        private String _username;
        [DisplayName("UserName")]
        public String Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
                RaisePropertyChange("Username");
            }
        }
        private String _representation;
        [DisplayName("Représentation")]
        public String Representation
        {
            get
            {
                return this._representation;
            }
            set
            {
                this._representation = value;
                RaisePropertyChange("Representation");
            }
        }
        private Int64 _color;
        [DisplayName("Couleur")]
        public Int64 Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
                RaisePropertyChange("Color");
            }
        }
        
        private Int64 _width;
        [DisplayName("Largeur")]
        public Int64 Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
                RaisePropertyChange("Width");
            }
        }
        
        private String _font;
        [DisplayName("Police")]
        public String Font
        {
            get
            {
                return this._font;
            }
            set
            {
                this._font = value;
                RaisePropertyChange("Font");
            }
        }
        private Nullable<Int64> _ascii;
        [DisplayName("Code ASCII")]
        public Nullable<Int64> Ascii
        {
            get
            {
                return this._ascii;
            }
            set
            {
                this._ascii = value;
                RaisePropertyChange("Ascii");
            }
        }
        
        private Nullable<Int64> _style;
        [DisplayName("Style")]
        public Nullable<Int64> Style
        {
            get
            {
                return this._style;
            }
            set
            {
                this._style = value;
                RaisePropertyChange("Style");
            }
        }
        
        private Nullable<Int64> _interleaved;
        [DisplayName("Interleaved")]
        public Nullable<Int64> Interleaved
        {
            get
            {
                return this._interleaved;
            }
            set
            {
                this._interleaved = value;
                RaisePropertyChange("Interleaved");
            }
        }
        
        private Nullable<Int64> _bordercolor;
        [DisplayName("BorderColor")]
        public Nullable<Int64> Bordercolor
        {
            get
            {
                return this._bordercolor;
            }
            set
            {
                this._bordercolor = value;
                RaisePropertyChange("Bordercolor");
            }
        }
        
        private Nullable<Int64> _borderstyle;
        [DisplayName("BorderStyle")]
        public Nullable<Int64> Borderstyle
        {
            get
            {
                return this._borderstyle;
            }
            set
            {
                this._borderstyle = value;
                RaisePropertyChange("Borderstyle");
            }
        }
        
        private Nullable<Int64> _regionbackground;
        [DisplayName("RegionBackground")]
        public Nullable<Int64> Regionbackground
        {
            get
            {
                return this._regionbackground;
            }
            set
            {
                this._regionbackground = value;
                RaisePropertyChange("Regionbackground");
            }
        }
        
    }
}
