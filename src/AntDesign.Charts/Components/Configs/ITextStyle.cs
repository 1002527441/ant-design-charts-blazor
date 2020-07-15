﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AntDesign.Charts
{
    public interface ITextStyle: IGraphicStyle
    {
        public int? fontSize { get; set; }
        public string fontFamily { get; set; }
        public int? fontWeight { get; set; }
        public int? lineHeight { get; set; }
        public string textAlign { get; set; }// OneOf<'center','left','right'> 
        public string textBaseline { get; set; }//OneOf<'middle','top','bottom'>
        // [field: string]: any;
    }

    public class TextStyle : ITextStyle
    {
        public int? fontSize { get;set; }
        public string fontFamily { get;set; }
        public int? fontWeight { get;set; }
        public int? lineHeight { get;set; }
        public string textAlign { get;set; }
        public string textBaseline { get;set; }
        public string fill { get;set; }
        public int? fillOpacity { get;set; }
        public string stroke { get;set; }
        public int? lineWidth { get;set; }
        public int[] lineDash { get;set; }
        public int? lineOpacity { get;set; }
        public int? opacity { get;set; }
        public string shadowColor { get;set; }
        public int? shadowBlur { get;set; }
        public int? shadowOffsetX { get;set; }
        public int? shadowOffsetY { get;set; }
        public string cursor { get;set; }
    }
}