using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computing3
{
    public partial class mainForm : Form
    {
        private static CancellationTokenSource tknSrc = new CancellationTokenSource();

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
            if (txtRows.Text != "" && txtColumns.Text != "")
            {
                int rows = Int32.Parse(txtRows.Text), cols = Int32.Parse(txtColumns.Text);
                if (rows > 1 && (rows + 1 == cols))
                {
                    var setForm = new setForm(rows, cols);
                    this.Hide();
                    setForm.ShowDialog();
                    this.Show();
                }
                else { ShowError(labInvalidInput); }
            }
            else { ShowError(labInvalidInput); }
        }

        public static void ShowError(Label lbl)
        {
            tknSrc.Cancel();
            tknSrc = new CancellationTokenSource();
            Fade(lbl, tknSrc.Token);
        }

        private static async void Fade(Label lbl, CancellationToken token)
        {
            try
            {
                lbl.Visible = true;
                await Task.Run(async () =>
                {
                    for (int i = 0; i < 255; i += 5)
                    {
                        token.ThrowIfCancellationRequested();
                        lbl.ForeColor = Color.FromArgb(255, i, i);
                        await Task.Delay(20);

                    }
                });
                lbl.Visible = false;
            }
            catch { }
        }
    }
}
