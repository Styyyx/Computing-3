namespace Computing3
{
    partial class setForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSolve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSolve.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(377, 316);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(160, 33);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "SOLVE MATRIX";
            this.btnSolve.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter matrix elements:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Location = new System.Drawing.Point(275, 180);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(2, 2);
            this.panelButtons.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Solving Linear Independent System\r\nusing Row Echelon Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "GAUSS-JORDAN ELIMINATION CALCULATOR";
            // 
            // btnFill
            // 
            this.btnFill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFill.Location = new System.Drawing.Point(211, 316);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(160, 33);
            this.btnFill.TabIndex = 11;
            this.btnFill.Text = "FILL WITH ZERO";
            this.btnFill.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(45, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR MATRIX";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // setForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "setForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauss-Jordan Elimination Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.setForm_FormClosed);
            this.Load += new System.EventHandler(this.setForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClear;
    }
}