using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ScienceFairGame
{
    class TicTacToe
    {
        Char[][] boardPieces;
        int rows;
        int columns;

        public TicTacToe()
        {
            rows = 3;
            columns = 3;

            boardPieces = new Char[rows][];

            boardPieces[0] = new Char[columns];
            boardPieces[1] = new Char[columns];
            boardPieces[2] = new Char[columns];
        }

        public void setPiece(int row, int col, char piece, Graphics g, Brush brush)
        {
            boardPieces[row][col] = piece;

            paintPiece(row, col, piece, g, brush);
        }

        private void paintPiece(int row, int col, char piece, Graphics g, Brush brush)
        {
            Brush innerCircle = new SolidBrush(Form1.DefaultBackColor);
            Point[] leftXPoints = new Point[5];
            Point[] rightXPoints = new Point[5];
            int xChange = 160;
            int yChange = 160;

            #region firstRow
            if (row == 0 && col == 0)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40, 30);
                    leftXPoints[1] = new Point(50, 15);
                    leftXPoints[2] = new Point(140, 140);
                    leftXPoints[3] = new Point(130, 155);
                    leftXPoints[4] = new Point(40, 30);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140, 30);
                    rightXPoints[1] = new Point(130, 15);
                    rightXPoints[2] = new Point(40, 140);
                    rightXPoints[3] = new Point(50, 155);
                    rightXPoints[4] = new Point(140, 30);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30, 30, 115, 115);
                    g.FillEllipse(innerCircle, 45, 45, 85, 85);
                }
            }
            if (row == 0 && col == 1)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40 + xChange, 30);
                    leftXPoints[1] = new Point(50 + xChange, 15);
                    leftXPoints[2] = new Point(140 + xChange, 140);
                    leftXPoints[3] = new Point(130 + xChange, 155);
                    leftXPoints[4] = new Point(40 + xChange, 30);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140 + xChange, 30);
                    rightXPoints[1] = new Point(130 + xChange, 15);
                    rightXPoints[2] = new Point(40 + xChange, 140);
                    rightXPoints[3] = new Point(50 + xChange, 155);
                    rightXPoints[4] = new Point(140 + xChange, 30);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30 + xChange, 30, 115, 115);
                    g.FillEllipse(innerCircle, 45 + xChange, 45, 85, 85);
                }
            }
            if (row == 0 && col == 2)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40 + xChange + xChange, 30);
                    leftXPoints[1] = new Point(50 + xChange + xChange, 15);
                    leftXPoints[2] = new Point(140 + xChange + xChange, 140);
                    leftXPoints[3] = new Point(130 + xChange + xChange, 155);
                    leftXPoints[4] = new Point(40 + xChange + xChange, 30);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140 + xChange + xChange, 30);
                    rightXPoints[1] = new Point(130 + xChange + xChange, 15);
                    rightXPoints[2] = new Point(40 + xChange + xChange, 140);
                    rightXPoints[3] = new Point(50 + xChange + xChange, 155);
                    rightXPoints[4] = new Point(140 + xChange + xChange, 30);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30 + xChange + xChange, 30, 115, 115);
                    g.FillEllipse(innerCircle, 45 + xChange + xChange, 45, 85, 85);
                }
            }
            #endregion firstRow

            #region secondRow
            if (row == 1 && col == 0)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40, 30 + yChange);
                    leftXPoints[1] = new Point(50, 15 + yChange);
                    leftXPoints[2] = new Point(140, 140 + yChange);
                    leftXPoints[3] = new Point(130, 155 + yChange);
                    leftXPoints[4] = new Point(40, 30 + yChange);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140, 30 + yChange);
                    rightXPoints[1] = new Point(130, 15 + yChange);
                    rightXPoints[2] = new Point(40, 140 + yChange);
                    rightXPoints[3] = new Point(50, 155 + yChange);
                    rightXPoints[4] = new Point(140, 30 + yChange);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30, 30 + yChange, 115, 115);
                    g.FillEllipse(innerCircle, 45, 45 + yChange, 85, 85);
                }
            }
            if (row == 1 && col == 1)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40 + xChange, 30 + yChange);
                    leftXPoints[1] = new Point(50 + xChange, 15 + yChange);
                    leftXPoints[2] = new Point(140 + xChange, 140 + yChange);
                    leftXPoints[3] = new Point(130 + xChange, 155 + yChange);
                    leftXPoints[4] = new Point(40 + xChange, 30 + yChange);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140 + xChange, 30 + yChange);
                    rightXPoints[1] = new Point(130 + xChange, 15 + yChange);
                    rightXPoints[2] = new Point(40 + xChange, 140 + yChange);
                    rightXPoints[3] = new Point(50 + xChange, 155 + yChange);
                    rightXPoints[4] = new Point(140 + xChange, 30 + yChange);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30 + xChange, 30 + yChange, 115, 115);
                    g.FillEllipse(innerCircle, 45 + xChange, 45 + yChange, 85, 85);
                }
            }
            if (row == 1 && col == 2)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40 + xChange + xChange, 30 + yChange);
                    leftXPoints[1] = new Point(50 + xChange + xChange, 15 + yChange);
                    leftXPoints[2] = new Point(140 + xChange + xChange, 140 + yChange);
                    leftXPoints[3] = new Point(130 + xChange + xChange, 155 + yChange);
                    leftXPoints[4] = new Point(40 + xChange + xChange, 30 + yChange);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140 + xChange + xChange, 30 + yChange);
                    rightXPoints[1] = new Point(130 + xChange + xChange, 15 + yChange);
                    rightXPoints[2] = new Point(40 + xChange + xChange, 140 + yChange);
                    rightXPoints[3] = new Point(50 + xChange + xChange, 155 + yChange);
                    rightXPoints[4] = new Point(140 + xChange + xChange, 30 + yChange);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30 + xChange + xChange, 30 + yChange, 115, 115);
                    g.FillEllipse(innerCircle, 45 + xChange + xChange, 45 + yChange, 85, 85);
                }
            }
            #endregion secondRow

            #region thirdRow
            if (row == 2 && col == 0)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40, 30 + yChange + yChange);
                    leftXPoints[1] = new Point(50, 15 + yChange + yChange);
                    leftXPoints[2] = new Point(140, 140 + yChange + yChange);
                    leftXPoints[3] = new Point(130, 155 + yChange + yChange);
                    leftXPoints[4] = new Point(40, 30 + yChange + yChange);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140, 30 + yChange + yChange);
                    rightXPoints[1] = new Point(130, 15 + yChange + yChange);
                    rightXPoints[2] = new Point(40, 140 + yChange + yChange);
                    rightXPoints[3] = new Point(50, 155 + yChange + yChange);
                    rightXPoints[4] = new Point(140, 30 + yChange + yChange);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30, 30 + yChange + yChange, 115, 115);
                    g.FillEllipse(innerCircle, 45, 45 + yChange + yChange, 85, 85);
                }
            }
            if (row == 2 && col == 1)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40 + xChange, 30 + yChange + yChange);
                    leftXPoints[1] = new Point(50 + xChange, 15 + yChange + yChange);
                    leftXPoints[2] = new Point(140 + xChange, 140 + yChange + yChange);
                    leftXPoints[3] = new Point(130 + xChange, 155 + yChange + yChange);
                    leftXPoints[4] = new Point(40 + xChange, 30 + yChange + yChange);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140 + xChange, 30 + yChange + yChange);
                    rightXPoints[1] = new Point(130 + xChange, 15 + yChange + yChange);
                    rightXPoints[2] = new Point(40 + xChange, 140 + yChange + yChange);
                    rightXPoints[3] = new Point(50 + xChange, 155 + yChange + yChange);
                    rightXPoints[4] = new Point(140 + xChange, 30 + yChange + yChange);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30 + xChange, 30 + yChange + yChange, 115, 115);
                    g.FillEllipse(innerCircle, 45 + xChange, 45 + yChange + yChange, 85, 85);
                }
            }
            if (row == 2 && col == 2)
            {
                if (boardPieces[row][col] == 'X')
                {
                    leftXPoints[0] = new Point(40 + xChange + xChange, 30 + yChange + yChange);
                    leftXPoints[1] = new Point(50 + xChange + xChange, 15 + yChange + yChange);
                    leftXPoints[2] = new Point(140 + xChange + xChange, 140 + yChange + yChange);
                    leftXPoints[3] = new Point(130 + xChange + xChange, 155 + yChange + yChange);
                    leftXPoints[4] = new Point(40 + xChange + xChange, 30 + yChange + yChange);
                    g.FillPolygon(brush, leftXPoints);

                    rightXPoints[0] = new Point(140 + xChange + xChange, 30 + yChange + yChange);
                    rightXPoints[1] = new Point(130 + xChange + xChange, 15 + yChange + yChange);
                    rightXPoints[2] = new Point(40 + xChange + xChange, 140 + yChange + yChange);
                    rightXPoints[3] = new Point(50 + xChange + xChange, 155 + yChange + yChange);
                    rightXPoints[4] = new Point(140 + xChange + xChange, 30 + yChange + yChange);
                    g.FillPolygon(brush, rightXPoints);
                }
                else
                {
                    g.FillEllipse(brush, 30 + xChange + xChange, 30 + yChange + yChange, 115, 115);
                    g.FillEllipse(innerCircle, 45 + xChange + xChange, 45 + yChange + yChange, 85, 85);
                }
            }
            #endregion thirdRow

           
        }
    }
}
