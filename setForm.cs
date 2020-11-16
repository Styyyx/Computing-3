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

        }

        private void GenerateMatrix(int rows, int cols)
        {
            
            for (int row = 0; row < rows; row++)
            {
                List<TextBox> lst = new List<TextBox> { };
                for (int col = 0; col < cols; col++)
                {
                    TextBox tbox = new TextBox();

                    lst.Add(tbox);
                }
                this.MatrixTBox.Add(lst);
            }
        }
    }
}
