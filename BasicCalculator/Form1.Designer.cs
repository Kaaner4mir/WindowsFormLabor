namespace BasicCalculator
{
    partial class Form1
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
            lblNumber1 = new Label();
            btnAdd = new Button();
            txtNumber1 = new TextBox();
            lblNumber2 = new Label();
            txtNumber2 = new TextBox();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnBase = new Button();
            btnRoot = new Button();
            btnClear = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNumber1.Location = new Point(12, 77);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(105, 25);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Number 1";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Tahoma", 12F);
            btnAdd.Location = new Point(122, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 56);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtNumber1.Location = new Point(123, 71);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(168, 36);
            txtNumber1.TabIndex = 2;
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNumber2.Location = new Point(12, 149);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(105, 25);
            lblNumber2.TabIndex = 3;
            lblNumber2.Text = "Number 2";
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtNumber2.Location = new Point(123, 143);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(168, 36);
            txtNumber2.TabIndex = 4;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Tahoma", 12F);
            btnSubtract.Location = new Point(207, 197);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(84, 56);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Tahoma", 12F);
            btnMultiply.Location = new Point(122, 259);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(79, 56);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Tahoma", 12F);
            btnDivide.Location = new Point(207, 259);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(84, 56);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnBase
            // 
            btnBase.Font = new Font("Tahoma", 12F);
            btnBase.Location = new Point(122, 321);
            btnBase.Name = "btnBase";
            btnBase.Size = new Size(79, 56);
            btnBase.TabIndex = 8;
            btnBase.Text = "Base";
            btnBase.UseVisualStyleBackColor = true;
            btnBase.Click += btnBase_Click;
            // 
            // btnRoot
            // 
            btnRoot.Font = new Font("Tahoma", 12F);
            btnRoot.Location = new Point(207, 321);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(84, 56);
            btnRoot.TabIndex = 9;
            btnRoot.Text = "Root";
            btnRoot.UseVisualStyleBackColor = true;
            btnRoot.Click += btnRoot_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 12F);
            btnClear.Location = new Point(12, 197);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 180);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtResult.Location = new Point(12, 12);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(279, 36);
            txtResult.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(311, 395);
            Controls.Add(txtResult);
            Controls.Add(btnClear);
            Controls.Add(btnRoot);
            Controls.Add(btnBase);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(txtNumber2);
            Controls.Add(lblNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(btnAdd);
            Controls.Add(lblNumber1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Button btnAdd;
        private TextBox txtNumber1;
        private Label lblNumber2;
        private TextBox txtNumber2;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnBase;
        private Button btnRoot;
        private Button btnClear;
        private TextBox txtResult;
    }
}
