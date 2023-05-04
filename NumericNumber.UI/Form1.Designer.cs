namespace NumericNumber.UI
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
            TxtInput = new TextBox();
            TxtOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LblError = new Label();
            BtnExit = new Button();
            SuspendLayout();
            // 
            // TxtInput
            // 
            TxtInput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtInput.Location = new Point(100, 58);
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(385, 33);
            TxtInput.TabIndex = 0;
            TxtInput.TextChanged += TxtInput_TextChanged;
            // 
            // TxtOutput
            // 
            TxtOutput.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtOutput.Location = new Point(100, 154);
            TxtOutput.Name = "TxtOutput";
            TxtOutput.Size = new Size(385, 33);
            TxtOutput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 40);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Input:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 136);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Output:";
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblError.ForeColor = Color.Red;
            LblError.Location = new Point(99, 100);
            LblError.Name = "LblError";
            LblError.Size = new Size(0, 25);
            LblError.TabIndex = 4;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(100, 215);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(144, 59);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 336);
            Controls.Add(BtnExit);
            Controls.Add(LblError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtOutput);
            Controls.Add(TxtInput);
            Name = "Form1";
            Text = "Roman Numeral";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtInput;
        private TextBox TxtOutput;
        private Label label1;
        private Label label2;
        private Label LblError;
        private Button BtnExit;
    }
}