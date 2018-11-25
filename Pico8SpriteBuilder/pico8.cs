using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pico8SpriteBuilder
{
    internal class pico8
    {
        public static Color[] pallete = new Color[]
        {
            Color.FromArgb(0,0,0),//black
            Color.FromArgb(29,43,83),//dark blue
            Color.FromArgb(126,37,83),//dark purple
            Color.FromArgb(0,135,81),//dark green
            Color.FromArgb(171,82,54),//dark brown
            Color.FromArgb(95,87,79),//dark gray 
            Color.FromArgb(194,195,199),//light gray
            Color.FromArgb(255,241,232),//white
            Color.FromArgb(255,0,77),//magenta
            Color.FromArgb(255,163,0),//orange
            Color.FromArgb(255,236,39),//yellow
            Color.FromArgb(0,228,54),//light green
            Color.FromArgb(41,173,255),//cyan
            Color.FromArgb(131,118,156),//mauve
            Color.FromArgb(255,119,168),//pink
            Color.FromArgb(255,204,170),//cream
        };
        /// <summary>
        /// generates data file in hex format for each pixel of sprite data
        /// </summary>
        /// <param name="filename"></param>
        internal static void GenerateSpriteData(string filename, RichTextBox rt)
        {
            rt.Clear();
            int[,] pixels = ConvertPicoImageToPixelArray(filename);
            //need to process 128 pixels at a time 
            for (int r = 0; r < 128; r++)
            {
                string row = "";
                for (int c = 0; c < 128; c++)
                {
                    row += pixels[c,r].ToString("x").ToLower();
                }
                rt.AppendText(row + "\n");
            }

        }
        /// <summary>
        /// 128x128 images only
        /// </summary>
        /// <param name="imageFile"></param>
        /// <returns></returns>
        private static int[,] ConvertPicoImageToPixelArray(string imageFile)
        {
            Bitmap i = new Bitmap(Image.FromFile(imageFile));

            int[,] pixels = new int[128, 128];

            for (int x = 0; x < 128; x++)
            {
                for (int y = 0; y < 128; y++)
                {
                    pixels[x, y] = GetPalleteColorFrom(i.GetPixel(x, y));
                }
            }
            return pixels;
        }


        /// <summary>
        /// returns a 2 bitplane colour from the given primary colour
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        private static int GetPalleteColorFrom(Color color)
        {
            for (int i = 0; i < pallete.Length; i++)
            {
                if (SameColor(pallete[i], color))
                    return i;
            }
            return 0;
        }

        private static bool SameColor(Color color1, Color color2)
        {
            return Math.Abs(color1.R - color2.R) < 5 && Math.Abs(color1.G - color2.G) < 5 && Math.Abs(color1.B - color2.B) < 5;
        }
    }
}