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
        bool playerTurn = true;
       

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

            label1.Text = game.checkWin();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            createBoard();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button1.Visible = false;
            game.setPiece(0, 0, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button2.Visible = false;

            game.setPiece(0, 1, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button3.Visible = false;

            game.setPiece(0, 2, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button4.Visible = false;

            game.setPiece(1, 0, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button5.Visible = false;

            game.setPiece(1, 1, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button6.Visible = false;

            game.setPiece(1, 2, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button7.Visible = false;

            game.setPiece(2, 0, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button8.Visible = false;

            game.setPiece(2, 1, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            button9.Visible = false;

            game.setPiece(2, 2, gamePiece, g, brush);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Refresh();
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;

            playerTurn = true;

            game.newGame();
        }
    }
}
