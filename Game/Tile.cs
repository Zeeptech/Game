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

        public int Width
        { get; set; }

        public int Height
        { get; set; }

        public Tile(string img)
        {
            this.Img = Utils.GetImage(img);
            this.Width = 64;
            this.Height = 64;
        }

    }
}
