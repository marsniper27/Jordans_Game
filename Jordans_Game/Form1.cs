using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jordans_Game
{
    public partial class Form1 : Form
    {
        List<Piece> pieces = new List<Piece>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPanel.Hide();
            TextBox txt = new TextBox();
            txt.Text = "Game Panel";
            GamePanel.Controls.Add(txt);
            GamePanel.Show();
            Image Archer = Image.FromFile(@"C:\Users\kyle.marshall\Source\Repos\Jordans_Game\Jordans_Game\P1Archer.png");

            //ceate pieces
            Piece P1A = new Piece(Archer,110,30);
            pieces.Add(P1A);
            
            BoardPanel.Show();
        }

        int _boardX = 10, _boardY = 10;
        int _boardWidth = 480, _boardHeight = 480;//must be multiple of 6
        Brush _borderColor = Brushes.Black;
        Brush[] _boardColor = { Brushes.White, Brushes.Black };
        void DrawChessBoard(Graphics g)
        {
            //draw squares
            int spacingX = _boardWidth / 6;
            int spacingY = _boardHeight / 6;
            for (int col = 0; col < 6; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    g.FillRectangle(_boardColor[(col + row) % 2], _boardX + col * spacingX, _boardY + row * spacingY, spacingX, spacingY);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                //draw lines
                g.DrawLine(new Pen(_borderColor), _boardX, _boardY + i * spacingY, _boardX + _boardWidth, _boardY + i * spacingY);
                g.DrawLine(new Pen(_borderColor), _boardX + i * spacingX, _boardY, _boardX + i * spacingX, _boardY + _boardHeight);
            }
            //draw border
            g.DrawRectangle(new Pen(_borderColor, 1), new Rectangle(_boardX, _boardY, _boardWidth, _boardHeight));
            //next you would draw pieces with an array of where they are
            //assuming you have a ChessPiece class you could do something like this
            
            foreach(Piece piece in pieces)
            {
                g.DrawImage(piece.img, piece.x, piece.y);
            }
            
        }

        //Form1 Paint method calls DrawChessBoard
        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawChessBoard(e.Graphics);
        }
    }
}
