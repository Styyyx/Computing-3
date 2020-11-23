using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Computing3
{
    public partial class outputForm : Form
    {
        int rowSize, colSize;
        List<List<float>> matrix;

        private void outputForm_Load(object sender, EventArgs e)
        {
            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    double val = Math.Round(matrix[row][col], 3);
                    TextBox tbox = new TextBox();
                    tbox.Text = val.ToString();
                    tbox.ReadOnly = true;
                    tbox.BorderStyle = 0;
                    tbox.BackColor = this.BackColor;
                    tbox.TabStop = false;
                    tbox.Location = new Point(5 + (55 * col), 5 + (25 * row));
                    tbox.Size = new Size(50, 20);
                    tbox.Font = new Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tbox.Name = $"tbox{row}{col}";
                    this.Controls.Add(tbox);
                }
            }

            for (int row = 0; row < rowSize; row++)
            {
                TextBox eqtbox = new TextBox();
                eqtbox.Text = $"x{row+1} = {matrix[row][colSize-1]}";
                eqtbox.Font = new Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eqtbox.Location = new Point(15 + (55 * colSize), 5 + (25 * row));
                eqtbox.ReadOnly = true;
                eqtbox.BorderStyle = 0;
                eqtbox.BackColor = this.BackColor;
                eqtbox.TabStop = false;
                eqtbox.Name = $"eqtbox{row}";
                eqtbox.Size = new Size(100, 20);
                this.Controls.Add(eqtbox);
            }
            this.CenterToParent();
            this.Text = "Result";
        }

        public outputForm(List<List<float>> m)
        {
            InitializeComponent();
            this.rowSize = m.Count();
            this.colSize = m[0].Count();
            this.matrix = m;
        }
    }
}
