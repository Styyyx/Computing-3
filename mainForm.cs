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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void txtRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if inputed row is a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtColumns_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if inputed column is a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(txtRows.Text);
            int columns = int.Parse(txtColumns.Text);

            // Check if rows and columns input are more than 1
            if ((rows > 1) && (columns > 1))
            {
                var setForm = new setForm();
                setForm.Show();
                this.Hide();
            }
        }
    }
}
