﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2017 DUONG DIEU PHAP
Project homepage: http://imageglass.org

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using ImageMagick;
using System.Drawing;
using System.IO;

namespace ImageGlass.Theme
{
    public class ThemeIconCollection
    {
        public ThemeIcon About { get; set; }
        public ThemeIcon ActualSize { get; set; }
        public ThemeIcon AdjustWindowSize { get; set; }
        public ThemeIcon CheckedBackground { get; set; }
        public ThemeIcon Convert { get; set; }
        public ThemeIcon FullScreen { get; set; }
        public ThemeIcon GoToImage { get; set; }
        public ThemeIcon LockRatio { get; set; }
        public ThemeIcon Menu { get; set; }
        public ThemeIcon OpenFile { get; set; }
        public ThemeIcon Plugins { get; set; }
        public ThemeIcon Print { get; set; }
        public ThemeIcon Refresh { get; set; }
        public ThemeIcon RotateLeft { get; set; }
        public ThemeIcon RotateRight { get; set; }
        public ThemeIcon ScaleToHeight { get; set; }
        public ThemeIcon ScaleToWidth { get; set; }
        public ThemeIcon Settings { get; set; }
        public ThemeIcon Sharing { get; set; }
        public ThemeIcon Slideshow { get; set; }
        public ThemeIcon ThumbnailBar { get; set; }
        public ThemeIcon ViewNextImage { get; set; }
        public ThemeIcon ViewPreviousImage { get; set; }
        public ThemeIcon ZoomIn { get; set; }
        public ThemeIcon ZoomOut { get; set; }

        /// <summary>
        /// Icon collection for the theme
        /// </summary>
        public ThemeIconCollection()
        {
            About = new ThemeIcon();
            ActualSize = new ThemeIcon();
            AdjustWindowSize = new ThemeIcon();
            CheckedBackground = new ThemeIcon();
            Convert = new ThemeIcon();
            FullScreen = new ThemeIcon();
            GoToImage = new ThemeIcon();
            LockRatio = new ThemeIcon();
            Menu = new ThemeIcon();
            OpenFile = new ThemeIcon();
            Plugins = new ThemeIcon();
            Print = new ThemeIcon();
            Refresh = new ThemeIcon();
            RotateLeft = new ThemeIcon();
            RotateRight = new ThemeIcon();
            ScaleToHeight = new ThemeIcon();
            ScaleToWidth = new ThemeIcon();
            Settings = new ThemeIcon();
            Sharing = new ThemeIcon();
            Slideshow = new ThemeIcon();
            ThumbnailBar = new ThemeIcon();
            ViewNextImage = new ThemeIcon();
            ViewPreviousImage = new ThemeIcon();
            ZoomIn = new ThemeIcon();
            ZoomOut = new ThemeIcon();
        }
    }


    
    public class ThemeIcon
    {
        public Bitmap Image { get; set; }
        public string Filename { get; set; }

        /// <summary>
        /// Icon image
        /// </summary>
        public ThemeIcon()
        {
            Image = null;
            Filename = string.Empty;
        }

        /// <summary>
        /// Icon image
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <param name="width">Set width for Scalable Format</param>
        /// <param name="height">Set height for Scalable Format</param>
        public ThemeIcon(string filename, int @width = 0, int @height = 0)
        {
            Image = null;
            Filename = filename;

            //Load image
            LoadIcon(width, height);
        }

        /// <summary>
        /// Load image
        /// </summary>
        /// <param name="width">Set width for Scalable Format</param>
        /// <param name="height">Set height for Scalable Format</param>
        public void LoadIcon(int @width = 0, int @height = 0)
        {
            var settings = new MagickReadSettings();
            var ext = Path.GetExtension(Filename).ToLower();

            if (ext.CompareTo(".svg") == 0)
            {
                settings.BackgroundColor = MagickColors.Transparent;
            }

            if (width > 0 && height > 0)
            {
                settings.Width = width;
                settings.Height = height;
            }

            using (var magicImg = new MagickImage(Filename, settings))
            {
                Image = magicImg.ToBitmap();
            }
        }
        
    }
}
