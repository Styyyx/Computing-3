using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    TextBox tbox = new TextBox();
                    tbox.Text = matrix[row][col].ToString();
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
            this.Size = new Size(5 + (55 * rowSize), 5 + (25 * colSize));
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
