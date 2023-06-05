using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Tile
    {
        public Image Img
        { get; set; }

        public int X
        { get; set; }

        public int Y
        { get; set; }

        public int Width
        { get; set; }

        public int Height
        { get; set; }

        public Tile(string img, int x, int y)
        {
            this.Img = Image.FromFile(img);
            this.X = x;
            this.Y = y;
            this.Width = 64;
            this.Height = 64;
        }

    }
}
