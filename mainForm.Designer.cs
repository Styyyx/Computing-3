namespace Gauss_Jordan_Elimination_Calculator
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
            this.lblErrorValue = new System.Windows.Forms.Label();
            this.lblErrorRow = new System.Windows.Forms.Label();
            this.lblErrorColumn = new System.Windows.Forms.Label();
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
            this.lblTitle.Location = new System.Drawing.Point(64, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "GAUSS-JORDAN ELIMINATION CALCULATOR";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(168, 86);
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
            this.lblRows.Location = new System.Drawing.Point(231, 196);
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
            this.lblColumns.Location = new System.Drawing.Point(310, 196);
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
            this.lblMatrixDimensions.Location = new System.Drawing.Point(218, 152);
            this.lblMatrixDimensions.Name = "lblMatrixDimensions";
            this.lblMatrixDimensions.Size = new System.Drawing.Size(153, 16);
            this.lblMatrixDimensions.TabIndex = 5;
            this.lblMatrixDimensions.Text = "Enter matrix dimensions:";
            this.lblMatrixDimensions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(304, 217);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(70, 22);
            this.txtColumns.TabIndex = 2;
            this.txtColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumns_KeyPress);
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(214, 217);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(70, 22);
            this.txtRows.TabIndex = 1;
            this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRows_KeyPress);
            // 
            // lblErrorValue
            // 
            this.lblErrorValue.AutoSize = true;
            this.lblErrorValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorValue.ForeColor = System.Drawing.Color.Red;
            this.lblErrorValue.Location = new System.Drawing.Point(218, 242);
            this.lblErrorValue.Name = "lblErrorValue";
            this.lblErrorValue.Size = new System.Drawing.Size(156, 16);
            this.lblErrorValue.TabIndex = 5;
            this.lblErrorValue.Text = "Enter a value more than 1";
            this.lblErrorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorValue.Visible = false;
            // 
            // lblErrorRow
            // 
            this.lblErrorRow.AutoSize = true;
            this.lblErrorRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRow.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRow.Location = new System.Drawing.Point(246, 242);
            this.lblErrorRow.Name = "lblErrorRow";
            this.lblErrorRow.Size = new System.Drawing.Size(96, 16);
            this.lblErrorRow.TabIndex = 6;
            this.lblErrorRow.Text = "Enter row value";
            this.lblErrorRow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorRow.Visible = false;
            // 
            // lblErrorColumn
            // 
            this.lblErrorColumn.AutoSize = true;
            this.lblErrorColumn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorColumn.ForeColor = System.Drawing.Color.Red;
            this.lblErrorColumn.Location = new System.Drawing.Point(246, 242);
            this.lblErrorColumn.Name = "lblErrorColumn";
            this.lblErrorColumn.Size = new System.Drawing.Size(118, 16);
            this.lblErrorColumn.TabIndex = 6;
            this.lblErrorColumn.Text = "Enter column value";
            this.lblErrorColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorColumn.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lblErrorColumn);
            this.Controls.Add(this.lblErrorRow);
            this.Controls.Add(this.lblErrorValue);
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
        private System.Windows.Forms.Label lblErrorValue;
        private System.Windows.Forms.Label lblErrorRow;
        private System.Windows.Forms.Label lblErrorColumn;
    }
}

