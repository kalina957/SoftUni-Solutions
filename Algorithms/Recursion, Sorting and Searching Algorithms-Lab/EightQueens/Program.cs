using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueens
{
    class EightQueens
    {
        private const int size = 4;
        private static bool[,] chessboard = new bool[ size,size];
        private static int solutionsFound = 0;

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void Main(string[] args)
        {
            PutQueens(0);
        }

        static void PutQueens(int row)
        {
            if (row==size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
                
            }
        }

        static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(col-row);
            attackedRightDiagonals.Add(col + row);
            chessboard[row, col] = true;
        }

        static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
            chessboard[row, col] = false;
        }

        static bool CanPlaceQueen(int row, int col)
        {
            bool positionOccupied = attackedRows.Contains(row) ||
                attackedColumns.Contains(col)
                || attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals.Contains(row + col);
            return !positionOccupied;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < attackedRows.Count; row++)
            {
                for (int col = 0; col < attackedColumns.Count; col++)
                {
                    if (chessboard[row,col]==true)
                    {
                        Console.Write("Q ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionsFound++;
        }
        
    }
}
