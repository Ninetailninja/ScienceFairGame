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
    /*class for the Form the game is played on
     * 
     */
    public partial class Form1 : Form
    {
        Graphics g;
        Brush brush;
        TicTacToe game = new TicTacToe();
        TicTacToeAI AI = new TicTacToeAI();
        bool playerTurn = true;
        bool[,] filledSpots;

        /* Constructor for the Form
         * 
         */
        public Form1()
        {
            InitializeComponent();
            filledSpots = new bool[3, 3];
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Black);
        }

        /* draws the board for the Tic-Tac-Toe game
         */
        private void createBoard()
        {
            g.FillRectangle(brush, 160, 50, 10, 400);
            g.FillRectangle(brush, 330, 50, 10, 400);
            g.FillRectangle(brush, 25, 160, 450, 10);
            g.FillRectangle(brush, 25, 325, 450, 10);

            label1.Text = game.checkWin();

            filledSpots[0, 0] = false;
            filledSpots[0, 1] = false;
            filledSpots[0, 2] = false;
            filledSpots[1, 0] = false;
            filledSpots[1, 1] = false;
            filledSpots[1, 2] = false;
            filledSpots[2, 0] = false;
            filledSpots[2, 1] = false;
            filledSpots[2, 2] = false;
        }

        /* Paint event to draw on.
         */
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            createBoard();
            
        }
        /* The event that happens when a button is clicked.
         * Places a piece in the specified row and column.
         * Hides the button clicked.
         * Changes the Turn.
         */
        private void clickEvent(int row, int col, Button clicked)
        {
            clicked.Visible = false;
            char gamePiece;

            if (playerTurn == true)
            {
                gamePiece = 'X';
            }
            else
            {
                gamePiece = 'O';
            }
            game.setPiece(row, col, gamePiece, g, brush);
            
            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;

            filledSpots[row, col] = true;
           
        }

        /* Checks to see if the Piece the AI wants to place is valid.
         * If not sets a new value to the piece and checks again.
         */
        private void checkAIPiece(int AIPiece)
        {

            if (AIPiece == 0 && filledSpots[0, 0] == false)
            {
                button1.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[0, 0] = true;
            }
            else if (AIPiece == 0 && filledSpots[0, 0] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 1 && filledSpots[0, 1] == false)
            {
                button2.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[0, 1] = true;
            }
            else if (AIPiece == 1 && filledSpots[0, 1] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 2 && filledSpots[0, 2] == false)
            {
                button3.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[0, 2] = true;
            }
            else if (AIPiece == 2 && filledSpots[0, 2] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 3 && filledSpots[1, 0] == false)
            {
                button4.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[1, 0] = true;
            }
            else if (AIPiece == 3 && filledSpots[1, 0] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 4 && filledSpots[1, 1] == false)
            {
                button5.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[1, 1] = true;
            }
            else if (AIPiece == 4 && filledSpots[1, 1] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 5 && filledSpots[1, 2] == false)
            {
                button6.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[1, 2] = true;
            }
            else if (AIPiece == 5 && filledSpots[1, 2] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 6 && filledSpots[2, 0] == false)
            {
                button7.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[2, 0] = true;
            }
            else if (AIPiece == 6 && filledSpots[2, 0] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 7 && filledSpots[2, 1] == false)
            {
                button8.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[2, 1] = true;

            }
            else if (AIPiece == 7 && filledSpots[2, 1] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            if (AIPiece == 8 && filledSpots[2, 2] == false)
            {
                button9.Visible = false;
                AI.placePiece(g, brush, AIPiece);
                filledSpots[2, 2] = true;
            }
            else if (AIPiece == 8 && filledSpots[2, 2] == true)
            {
                AIPiece = AI.choosePiece();
                checkAIPiece(AIPiece);
            }
            
        }

        /* The AI takes its turn.
         * Changes the turn.
         */ 
        private void AIMove()
        {

            int AIPiece = AI.choosePiece();

            checkAIPiece(AIPiece);

            if (playerTurn == true)
            {
                playerTurn = false;
            }
            else
                playerTurn = true;
        }

        //Event when button1 is clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            clickEvent(0, 0, button1);
            AIMove();
        }
        //Event when button2 is clicked.
        private void button2_Click(object sender, EventArgs e)
        {
            clickEvent(0, 1, button2);
            AIMove();
        }
        //Event when button3 is clicked.
        private void button3_Click(object sender, EventArgs e)
        {
            clickEvent(0, 2, button3);
            AIMove();
        }
        //Event when button4 is clicked.
        private void button4_Click(object sender, EventArgs e)
        {
            clickEvent(1, 0, button4);
            AIMove();
        }
        //Event when button5 is clicked.
        private void button5_Click(object sender, EventArgs e)
        {
            clickEvent(1, 1, button5);
            AIMove();
        }
        //Event when button6 is clicked.
        private void button6_Click(object sender, EventArgs e)
        {
            clickEvent(1, 2, button6);
            AIMove();
        }
        //Event when button7 is clicked.
        private void button7_Click(object sender, EventArgs e)
        {
            clickEvent(2, 0, button7);
             AIMove();
        }
        //Event when button8 is clicked.
        private void button8_Click(object sender, EventArgs e)
        {
            clickEvent(2, 1, button8);
            AIMove();
        }
        //Event when button9 is clicked.
        private void button9_Click(object sender, EventArgs e)
        {
            clickEvent(2, 2, button9);
            AIMove();
        }
        //Starts a new game.
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
