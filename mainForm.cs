using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computing3
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            txtRows.Click += new System.EventHandler(setForm.tboxClick);
            txtColumns.Click += new System.EventHandler(setForm.tboxClick);
        }

        private void ValidateTBox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCreate.PerformClick();
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tboxClick(object sender, EventArgs e)
        {
            var tbox = (TextBox)sender;
            tbox.SelectAll();
            tbox.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string rows = txtRows.Text, cols = txtColumns.Text;
            if (rows != "" && cols != "")
            {
                var setForm = new setForm(int.Parse(rows), int.Parse(cols));
                this.Hide();
                setForm.ShowDialog();
                this.Show();
            }
            else
            {
                // Find a way to refresh task when clicked while still fading out
                ShowError();
            }
        }

        private async void ShowError()
        {
            labInvalidInput.Visible = true;
            await Task.Run(async () =>
            {
                for (int i = 0; i < 255; i += 5)
                {
                    labInvalidInput.ForeColor = Color.FromArgb(255, i, i);
                    await Task.Delay(10);
                }
            });
            labInvalidInput.Visible = false;
        }
    }
}
