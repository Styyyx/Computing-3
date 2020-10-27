namespace Computing3
{
    partial class mainForm
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblMatrixDimensions = new System.Windows.Forms.Label();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.labInvalidInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(214, 271);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 33);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "CREATE MATRIX";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "GAUSS-JORDAN ELIMINATION CALCULATOR";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(163, 81);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(252, 36);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Solving Linear Independent System\r\nusing Row Echelon Form";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(231, 180);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(40, 16);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Rows";
            this.lblRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(310, 180);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(59, 16);
            this.lblColumns.TabIndex = 4;
            this.lblColumns.Text = "Columns";
            this.lblColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrixDimensions
            // 
            this.lblMatrixDimensions.AutoSize = true;
            this.lblMatrixDimensions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrixDimensions.Location = new System.Drawing.Point(221, 152);
            this.lblMatrixDimensions.Name = "lblMatrixDimensions";
            this.lblMatrixDimensions.Size = new System.Drawing.Size(153, 16);
            this.lblMatrixDimensions.TabIndex = 5;
            this.lblMatrixDimensions.Text = "Enter matrix dimensions:";
            this.lblMatrixDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(304, 201);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(70, 22);
            this.txtColumns.TabIndex = 2;
            this.txtColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTBox);
            // 
            // txtRows
            // 
            this.txtRows.BackColor = System.Drawing.SystemColors.Window;
            this.txtRows.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(214, 201);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(70, 22);
            this.txtRows.TabIndex = 1;
            this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateTBox);
            // 
            // labInvalidInput
            // 
            this.labInvalidInput.AutoSize = true;
            this.labInvalidInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInvalidInput.ForeColor = System.Drawing.SystemColors.Control;
            this.labInvalidInput.Location = new System.Drawing.Point(255, 236);
            this.labInvalidInput.Name = "labInvalidInput";
            this.labInvalidInput.Size = new System.Drawing.Size(75, 16);
            this.labInvalidInput.TabIndex = 6;
            this.labInvalidInput.Text = "Invalid Input";
            this.labInvalidInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labInvalidInput);
            this.Controls.Add(this.lblMatrixDimensions);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauss-Jordan Elimination Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblMatrixDimensions;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label labInvalidInput;
    }
}

