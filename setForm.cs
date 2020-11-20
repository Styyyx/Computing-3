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
        int rowSize, colSize;
        List<List<float>> matrix = new List<List<float>> { };
        List<List<TextBox>> matrixTbox = new List<List<TextBox>> {};
        bool back = false;

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
            if (!back)
            {
                Application.Exit();
            }
        }

        private void btnClear_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (TextBox tbox in panelTbox.Controls)
            {
                tbox.Text = "";
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            foreach (TextBox tbox in panelTbox.Controls)
            {
                if (tbox.Text == "")
                {
                    tbox.Text = "0";
                }
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (CheckTboxes())
            {
                foreach (List<TextBox> row in matrixTbox)
                {
                    List<float> lstFlt = new List<float> { };
                    foreach (TextBox col in row)
                    {
                        lstFlt.Add(float.Parse(col.Text));
                    }
                    matrix.Add(lstFlt);
                }
                outputForm f = new outputForm(Matrix.RREF(matrix));
                matrix = new List<List<float>> { };
                f.ShowDialog();
            }
            else
            {
                ShowError();
            }
        }

        private async void ShowError()
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 255; i += 5)
                {
                    labError.ForeColor = Color.FromArgb(255, i, i);
                    await Task.Delay(5);
                }
            });
        }

        static public void tboxClick(object sender, EventArgs e)
        {
            var tbox = (TextBox)sender;
            tbox.SelectAll();
            tbox.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Still stacking memory huhuhu :'(
            back = true;
            this.Close();
        }

        private bool CheckTboxes()
        {
            foreach (TextBox tbox in panelTbox.Controls)
            {
                if (tbox.Text == "") { return false; }
            }
            return true;
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
                    tbox.Size = new Size(50, 20);
                    tbox.Font = new Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tbox.Location = new Point(posX, posY);
                    tbox.Click += new System.EventHandler(tboxClick);

                    this.panelTbox.Controls.Add(tbox);
                    lst.Add(tbox);
                }
                matrixTbox.Add(lst);
            }
            panelTbox.Size = new Size(5 + (55 * this.colSize), 5 + (25 * this.rowSize));
            int sizeX = this.Size.Width, sizeY = this.Size.Height, panelX = panelTbox.Size.Width, panelY = panelTbox.Size.Height;
            panelTbox.Location = new Point((sizeX - panelX) / 2, (sizeY - panelY) / 2);
        }
    }
}
