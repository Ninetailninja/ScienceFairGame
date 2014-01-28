using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ScienceFairGame
{
    /* Creates AI to play against Player.
     */
    class TicTacToeAI : TicTacToe
    {
        Random r = new Random();

        /* uses pieceSelector to choose a piece to place.
         * Temporarily using randomPiece.
         * returns the number representing the location of the piece to be placed.
         */
        public int choosePiece()
        {
            //call pieceSelector() to determine which piece shall be placed
            int sendPiece = randomPiece();
            return sendPiece;

        }

        /* Thought process to decide which piece to select.
         * returns number representing which piece to place.
         */
        private int pieceSelector()
        {
            //choose a piece to put on the board
            int piece = 0;


            return piece;
        }

        /* Chooses a random piece to place.
         * Returns the random number.
         */ 
        private int randomPiece()
        {
            int piece = 0;
            piece = r.Next(0, 9);

            return piece;
        }

        /* Places the piece at the specified location for the AI.
         * 
         */
        public void placePiece(Graphics g, Brush b, int pieceNumber)
        {
            //put the piece on the board
            if (pieceNumber == 0)
            {
                setPiece(0, 0, 'O', g, b);
                
                
            }
            else if (pieceNumber == 1)
            {
                setPiece(0, 1, 'O', g, b);
            }
            else if (pieceNumber == 2)
            {
                setPiece(0, 2, 'O', g, b);

            }
            else if (pieceNumber == 3)
            {
                setPiece(1, 0, 'O', g, b);
            }
            else if (pieceNumber == 4)
            {
                setPiece(1, 1, 'O', g, b);
            }
            else if (pieceNumber == 5)
            {
                setPiece(1, 2, 'O', g, b);
            }
            else if (pieceNumber == 6)
            {
                setPiece(2, 0, 'O', g, b);
            }
            else if (pieceNumber == 7)
            {
                setPiece(2, 1, 'O', g, b);
            }
            else if (pieceNumber == 8)
            {
                setPiece(2, 2, 'O', g, b);
            }

        }
    }
}
