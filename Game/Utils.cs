using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal static class Utils
    {

        public static Image GetImage(string s)
        {
            string assetsPath = "../../../assets/";

            return Image.FromFile(assetsPath + s);

        }


    }
}
