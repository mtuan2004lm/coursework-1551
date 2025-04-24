    namespace coursework_1551
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
            txtInput = new TextBox();
            txtShift = new TextBox();
            btnEncode = new Button();
            lstCodes = new ListBox();
            label1 = new Label();
            txtResult = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(91, 35);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(257, 23);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // txtShift
            // 
            txtShift.Location = new Point(91, 85);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(124, 23);
            txtShift.TabIndex = 1;
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(383, 84);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(75, 23);
            btnEncode.TabIndex = 2;
            btnEncode.Text = "Endcode";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // lstCodes
            // 
            lstCodes.FormattingEnabled = true;
            lstCodes.ItemHeight = 15;
            lstCodes.Location = new Point(22, 224);
            lstCodes.Name = "lstCodes";
            lstCodes.Size = new Size(422, 139);
            lstCodes.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Input";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(91, 140);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(180, 23);
            txtResult.TabIndex = 6;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 93);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "Shift";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 142);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(lstCodes);
            Controls.Add(btnEncode);
            Controls.Add(txtShift);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtShift;
        private Button btnEncode;
        private ListBox lstCodes;
        private Label label1;
        private TextBox txtResult;
        private Label label2;
        private Label label3;
    }
}
