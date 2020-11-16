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
    public partial class setForm : Form
    {
        private int rowSize, colSize;
        private List<List<TextBox>> MatrixTBox = new List<List<TextBox>> { };

        public setForm(int row, int col)
        {
            this.rowSize = row;
            this.colSize = col;
            
            InitializeComponent();
        }

        private void setForm_Load(object sender, EventArgs e)
        {
            GenerateMatrix();
        }

        private void setForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GenerateMatrix()
        {
            for (int row = 0; row < this.rowSize; row++)
            {
                List<TextBox> lst = new List<TextBox> { };
                for (int col = 0; col < this.colSize; col++)
                {
                    int posX = 5 + (55 * col), posY = 5 + (25 * row);
                    TextBox tbox = new TextBox();
                    tbox.Name = $"tbox{row}{col}";
                    tbox.Text = $"{row}{col}";
                    tbox.Size = new Size(50, 20);
                    tbox.Font = new Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tbox.Location = new Point(posX, posY);

                    this.panelButtons.Controls.Add(tbox);
                    lst.Add(tbox);
                }
                MatrixTBox.Add(lst);
            }
            panelButtons.Size = new Size(5 + (55 * this.colSize), 5 + (25 * this.rowSize));
            int sizeX = this.Size.Width, sizeY = this.Size.Height, panelX = panelButtons.Size.Width, panelY = panelButtons.Size.Height;
            panelButtons.Location = new Point((sizeX - panelX) / 2, (sizeY - panelY) / 2);
        }
    }
}
