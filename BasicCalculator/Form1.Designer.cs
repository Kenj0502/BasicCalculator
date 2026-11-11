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
            label1.Location = new Point(81, 24);
            label1.Name = "label1";
            label1.Size = new Size(223, 38);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.BorderStyle = BorderStyle.FixedSingle;
            txtNum1.Cursor = Cursors.IBeam;
            txtNum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(46, 83);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(291, 39);
            txtNum1.TabIndex = 1;
            txtNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbOperator
            // 
            cmbOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperator.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperator.Location = new Point(163, 137);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(60, 36);
            cmbOperator.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.BorderStyle = BorderStyle.FixedSingle;
            txtNum2.Cursor = Cursors.IBeam;
            txtNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(46, 188);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(291, 39);
            txtNum2.TabIndex = 3;
            txtNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.Black;
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblAnswer);
            pnlTotal.Controls.Add(label2);
            pnlTotal.Location = new Point(46, 246);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(291, 125);
            pnlTotal.TabIndex = 4;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer.ForeColor = Color.Lime;
            lblAnswer.Location = new Point(12, 45);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(38, 42);
            lblAnswer.TabIndex = 1;
            lblAnswer.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(10, 8);
            label2.Name = "label2";
            label2.Size = new Size(70, 28);
            label2.TabIndex = 0;
            label2.Text = "Total: ";
            // 
            // btnCompute
            // 
            btnCompute.BackColor = SystemColors.Control;
            btnCompute.Cursor = Cursors.Hand;
            btnCompute.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnCompute.FlatAppearance.BorderSize = 0;
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(126, 386);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(129, 41);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(380, 440);
            Controls.Add(btnCompute);
            Controls.Add(pnlTotal);
            Controls.Add(txtNum2);
            Controls.Add(cmbOperator);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
