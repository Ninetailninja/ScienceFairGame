using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScienceFairGame
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush brush;
        TicTacToe game = new TicTacToe();
       

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Black);
        }

        private void createBoard()
        {
            g.FillRectangle(brush, 160, 50, 10, 400);
            g.FillRectangle(brush, 330, 50, 10, 400);
            g.FillRectangle(brush, 25, 160, 450, 10);
            g.FillRectangle(brush, 25, 325, 450, 10);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            createBoard();
            game.setPiece(0, 0, 'O', g, brush);
            game.setPiece(0, 1, 'O', g, brush);
            game.setPiece(0, 2, 'O', g, brush);
            game.setPiece(1, 0, 'O', g, brush);
            game.setPiece(1, 1, 'O', g, brush);
            game.setPiece(1, 2, 'O', g, brush);
            game.setPiece(2, 0, 'O', g, brush);
            game.setPiece(2, 1, 'O', g, brush);
            game.setPiece(2, 2, 'O', g, brush);
        }
    }
}
