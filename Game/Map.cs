using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Game
{
    /// <summary>
    /// Collection of graphics to render.
    /// </summary>
    internal class Map
    {
        private Tile[] options =
        {
            new Tile("floor.jpg"),
            new Tile("wall.jpg")
        };

        public List<Tile> Tiles { get; set; } = new List<Tile>();
        public string Name { get; set; }

        public Map(int[] grid, string name)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                this.Tiles.Add(options[grid[i]]);
            }
            this.Name = name;
        }

        
    }

}
