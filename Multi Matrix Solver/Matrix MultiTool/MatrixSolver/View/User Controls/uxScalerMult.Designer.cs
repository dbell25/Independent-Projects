namespace MatrixSolver.View.User_Controls
{
    partial class uxScalerMultControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uxScaler_RowCount = new System.Windows.Forms.NumericUpDown();
            this.ux_Scaler_ColCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.uxScaler_RowsLabel = new System.Windows.Forms.Label();
            this.uxScaler_ColumnsLabel = new System.Windows.Forms.Label();
            this.uxScaler_Label = new System.Windows.Forms.Label();
            this.uxScaler_Matrix = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxScaler_RowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Scaler_ColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxScaler_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scaler Multiplication";
            // 
            // uxScaler_RowCount
            // 
            this.uxScaler_RowCount.Location = new System.Drawing.Point(22, 45);
            this.uxScaler_RowCount.Name = "uxScaler_RowCount";
            this.uxScaler_RowCount.Size = new System.Drawing.Size(88, 28);
            this.uxScaler_RowCount.TabIndex = 1;
            this.uxScaler_RowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxScaler_RowCount.ValueChanged += new System.EventHandler(this.uxScaler_RowCount_ValueChanged);
            // 
            // ux_Scaler_ColCount
            // 
            this.ux_Scaler_ColCount.Location = new System.Drawing.Point(22, 79);
            this.ux_Scaler_ColCount.Name = "ux_Scaler_ColCount";
            this.ux_Scaler_ColCount.Size = new System.Drawing.Size(88, 28);
            this.ux_Scaler_ColCount.TabIndex = 2;
            this.ux_Scaler_ColCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ux_Scaler_ColCount.ValueChanged += new System.EventHandler(this.ux_Scaler_ColCount_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(22, 113);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(88, 28);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxScaler_RowsLabel
            // 
            this.uxScaler_RowsLabel.AutoSize = true;
            this.uxScaler_RowsLabel.Location = new System.Drawing.Point(116, 47);
            this.uxScaler_RowsLabel.Name = "uxScaler_RowsLabel";
            this.uxScaler_RowsLabel.Size = new System.Drawing.Size(51, 21);
            this.uxScaler_RowsLabel.TabIndex = 4;
            this.uxScaler_RowsLabel.Text = "Rows";
            // 
            // uxScaler_ColumnsLabel
            // 
            this.uxScaler_ColumnsLabel.AutoSize = true;
            this.uxScaler_ColumnsLabel.Location = new System.Drawing.Point(116, 81);
            this.uxScaler_ColumnsLabel.Name = "uxScaler_ColumnsLabel";
            this.uxScaler_ColumnsLabel.Size = new System.Drawing.Size(76, 21);
            this.uxScaler_ColumnsLabel.TabIndex = 5;
            this.uxScaler_ColumnsLabel.Text = "Columns";
            // 
            // uxScaler_Label
            // 
            this.uxScaler_Label.AutoSize = true;
            this.uxScaler_Label.Location = new System.Drawing.Point(116, 115);
            this.uxScaler_Label.Name = "uxScaler_Label";
            this.uxScaler_Label.Size = new System.Drawing.Size(58, 21);
            this.uxScaler_Label.TabIndex = 6;
            this.uxScaler_Label.Text = "Scaler";
            // 
            // uxScaler_Matrix
            // 
            this.uxScaler_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxScaler_Matrix.Location = new System.Drawing.Point(203, 3);
            this.uxScaler_Matrix.Name = "uxScaler_Matrix";
            this.uxScaler_Matrix.Size = new System.Drawing.Size(294, 244);
            this.uxScaler_Matrix.TabIndex = 7;
            // 
            // uxScaler_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uxScaler_Matrix);
            this.Controls.Add(this.uxScaler_Label);
            this.Controls.Add(this.uxScaler_ColumnsLabel);
            this.Controls.Add(this.uxScaler_RowsLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.ux_Scaler_ColCount);
            this.Controls.Add(this.uxScaler_RowCount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "uxScaler_Title";
            this.Size = new System.Drawing.Size(500, 250);
            ((System.ComponentModel.ISupportInitialize)(this.uxScaler_RowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Scaler_ColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxScaler_Matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uxScaler_RowCount;
        private System.Windows.Forms.NumericUpDown ux_Scaler_ColCount;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label uxScaler_RowsLabel;
        private System.Windows.Forms.Label uxScaler_ColumnsLabel;
        private System.Windows.Forms.Label uxScaler_Label;
        private System.Windows.Forms.DataGridView uxScaler_Matrix;
    }
}
