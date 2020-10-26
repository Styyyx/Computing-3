using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing3
{
    class Matrix
    {
        #region Test Cases

        static float[,] Test1 = new float[,] {
            {0, 1, 1, -2, -3 },
            {1, 2, -1, 0, 2 },
            {2, 4, 1, -3, -2 },
            {1, -4, -7, -1, 19 }

            /* Answer
             * 
             * 1   0   0   0   1.923
             * 0   1   0   0  -0.923
             * 0   0   1   0  -1.923
             * 0   0   0   1   0.077
             *  
             */
        };


        static float[,] Test2 = new float[,]
        {
            {0, 0, 0, 0, 1 },
            {0, 0, 0, 1, 2 },
            {0, 0, 1, 2, 3 },
            {0, 1, 2, 3, 4 }
        };

        static float[,] Test3 = new float[,]
        {
            {0, 1, 0, 2, 0 },
            {1, 0, 2, 3, 0 },
            {0, 0 ,0 ,1, 2 },
            {0, 0, 2, 0 ,1 }
        };
        #endregion

        static float[,] RREF(float[,] m)
        {
            m = SortMatrix(m);
            int rows = m.GetLength(0), cols = m.GetLength(1);

            // To Upper Triangular Matrix
            for (int pivot = 0; pivot <= rows - 1; pivot++)
            {
                float pivotValue = m[pivot, pivot];

                // Check if pivotvalue is 0 to avoid division by 0
                if (pivotValue == 0)
                {
                    m = SortMatrix(m);
                    // Reassign pivot value
                    pivotValue = m[pivot, pivot];
                }

                // If pivot value still 0 after sort, change pivotcolumn until pivotvalue != 0
                int n = pivot;
                while (pivotValue == 0)
                {
                    n++;
                    if (n >= rows) { break; }
                    pivotValue = m[pivot, n];
                }

                // Make leading coefficient = 1
                for (int col = 0; col < cols; col++)
                {
                    m[pivot, col] = m[pivot, col] / pivotValue;
                }

                if (pivot == rows) { break; }
                // Iterate through all rows after pivot
                for (int row = pivot + 1; row < rows; row++)
                {
                    if (m[row, pivot] == 0) { break; }
                    float scalar = m[row, pivot];
                    for (int col = pivot; col < cols; col++)
                    {
                        m[row, col] = m[row, col] - (m[pivot, col] * scalar);
                    }
                }
            }

            //To RREF
            for (int pivot = (rows - 1); pivot > 0; pivot--)
            {
                for (int row = pivot - 1; row >= 0; row--)
                {
                    float scalar = m[row, pivot];
                    for (int col = cols - 1; col > 0; col--)
                    {
                        m[row, col] = m[row, col] - (m[pivot, col] * scalar);
                    }
                }
            }
            return m;
        }

        static float[,] SortMatrix(float[,] matrix)
        {
            int rowSize = matrix.GetLength(0), colSize = matrix.GetLength(1);
            for (int i = 0; i < rowSize - 1; i++)
            {
                for (int j = 0; j < rowSize - i - 1; j++)
                {
                    for (int k = 0; k < colSize; k++)
                    {
                        if (matrix[j, k] == 0 && matrix[j + 1, k] != 0)
                        {
                            // Swap rows [j] and [j+1]
                            for (int col = 0; col < colSize; col++)
                            {
                                float temp = matrix[j, col];
                                matrix[j, col] = matrix[j + 1, col];
                                matrix[j + 1, col] = temp;
                            }
                            break;
                        }
                        else if (matrix[j, k] == 0 && matrix[j + 1, k] == 0) { continue; }
                        else { break; }
                    }
                }
            }

            return matrix;
        }
    }
}
