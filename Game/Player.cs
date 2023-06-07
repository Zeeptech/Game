using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal static class Player
    {
        public static Image Img { get; set; } = Utils.GetImage("unknown.png");
        public static string Name { get; set; } = "Hero";
        public static int Hp { get; set; } = 100;
        public static int Speed { get; set; } = 5;
        public static bool IsDead { get; set; } = false;
        public static int X { get; set; } = 400 - 32;
        public static int Y { get; set; } = 400 - 32;

        public static bool MoveLeft { get; set; } = false;
        public static bool MoveRight { get; set; } = false;
        public static bool MoveUp { get; set;} = false;
        public static bool MoveDown { get; set; } = false;

    }
}
