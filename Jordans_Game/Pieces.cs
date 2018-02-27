using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jordans_Game
{
    class Piece
    {
        public Image img {get;set; }
        public int x { get; set; }
        public int y{ get; set; }

        public Piece(Image Img, int X, int Y)
        {
            img = Img;
            x = X;
            y = Y;
        }
    }

}
