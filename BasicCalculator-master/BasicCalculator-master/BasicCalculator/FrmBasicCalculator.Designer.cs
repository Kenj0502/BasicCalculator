namespace BasicCalculator
{
    partial class FrmBasicCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNum1 = new TextBox();
            cmbOperator = new ComboBox();
            txtNum2 = new TextBox();
            pnlTotal = new Panel();
            lblAnswer = new Label();
            label2 = new Label();
            btnCompute = new Button();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.BorderStyle = BorderStyle.FixedSingle;
            txtNum1.Cursor = Cursors.IBeam;
            txtNum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(32, 50);
            txtNum1.Margin = new Padding(2);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(204, 29);
            txtNum1.TabIndex = 1;
            txtNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbOperator
            // 
            cmbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperator.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(114, 83);
            cmbOperator.Margin = new Padding(2);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(43, 25);
            cmbOperator.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.BorderStyle = BorderStyle.FixedSingle;
            txtNum2.Cursor = Cursors.IBeam;
            txtNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(32, 113);
            txtNum2.Margin = new Padding(2);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(204, 29);
            txtNum2.TabIndex = 3;
            txtNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.Black;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblAnswer);
            pnlTotal.Controls.Add(label2);
            pnlTotal.Location = new Point(32, 148);
            pnlTotal.Margin = new Padding(2);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(204, 76);
            pnlTotal.TabIndex = 4;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer.ForeColor = Color.Lime;
            lblAnswer.Location = new Point(8, 27);
            lblAnswer.Margin = new Padding(2, 0, 2, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(25, 28);
            lblAnswer.TabIndex = 1;
            lblAnswer.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(7, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 0;
            label2.Text = "Total: ";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = SystemColors.Control;
            btnCompute.Cursor = Cursors.Hand;
            btnCompute.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnCompute.FlatAppearance.BorderSize = 0;
            btnCompute.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(84, 231);
            btnCompute.Margin = new Padding(2);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(90, 34);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(266, 273);
            Controls.Add(btnCompute);
            Controls.Add(pnlTotal);
            Controls.Add(txtNum2);
            Controls.Add(cmbOperator);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FrmBasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBasicCalculator";
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private ComboBox cmbOperator;
        private TextBox txtNum2;
        private Panel pnlTotal;
        private Label label2;
        private Label lblAnswer;
        private Button btnCompute;
    }
}
