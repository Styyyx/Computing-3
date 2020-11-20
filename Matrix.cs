using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing3
{
    class Matrix
    {
        public static List<List<float>> RREF(List<List<float>> m)
        {
            m = SortMatrix(m);
            int rows = m.Count(), cols = m[0].Count();

            // To Upper Triangular Matrix
            for (int leadRow = 0; leadRow < rows; leadRow++)
            {
                int leadCol = 0;
                float leadCoeff = m[leadRow][leadCol];
                while (leadCoeff == 0)
                {
                    // If whole matrix is zeroes, return as is
                    if (leadCol == cols - 1) { return m; }
                    leadCol++;
                    leadCoeff = m[leadRow][leadCol];
                }

                //Divide row by leadCoeff
                for (int col = leadCol; col < cols; col++)
                {
                    m[leadRow][col] = m[leadRow][col] / leadCoeff;
                }

                //Subtract leadRow to all succeeding rows
                for (int row = leadRow + 1; row < rows; row++)
                {
                    float scalar = m[row][leadCol];
                    if (scalar == 0) { continue; }
                    else
                    {
                        for (int col = leadCol; col < cols; col++)
                        {
                            m[row][col] = m[row][col] - (m[leadRow][col] * scalar);
                        }
                    }
                }
            }

            m = SortMatrix(m);

            //To RREF
            for (int trailRow = rows - 1; trailRow > 0; trailRow--)
            {
                int leadCol = 0;
                float leadCoeff = m[trailRow][leadCol];
                while (leadCoeff == 0)
                {
                    if (leadCol == cols - 1) { break; }
                    leadCol++;
                    leadCoeff = m[trailRow][leadCol];
                }
                if (leadCoeff == 1)
                {
                    for (int row = trailRow - 1; row >= 0; row--)
                    {
                        float scalar = m[row][leadCol];
                        for (int col = leadCol; col < cols; col++)
                        {
                            m[row][col] = m[row][col] - (m[trailRow][col] * scalar);
                        }
                    }
                }
            }
            return SortMatrix(m);
        }

        /// <summary>
        /// Bubble Sort. Puts the row with the most leading zeroes to the bottom.
        /// </summary>
        /// <param name="m">The matrix to be sorted</param>
        /// <returns>Sorted Matrix</returns>
        static public List<List<float>> SortMatrix(List<List<float>> m)
        {
            int rowSize = m.Count(), colSize = m[0].Count();
            for (int i = 0; i < rowSize - 1; i++)
            {
                for (int j = 0; j < rowSize - i - 1; j++)
                {
                    for (int k = 0; k < colSize; k++)
                    {
                        if (m[j][k] == 0 && m[j + 1][k] != 0)
                        {
                            for (int col = 0; col < colSize; col++)
                            {
                                float temp = m[j][col];
                                m[j][col] = m[j + 1][col];
                                m[j + 1][col] = temp;
                            }
                            break;
                        }
                        else if (m[j][k] == 0 && m[j + 1][k] == 0) { continue; }
                        else { break; }
                    }
                }
            }
            return m;
        }
    }
}
