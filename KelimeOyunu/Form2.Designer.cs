namespace KelimeOyunu
{
    partial class Form2
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
            button1 = new Button();
            LastWordLbl = new Label();
            CurrentLetterLbl = new Label();
            wordTxb = new TextBox();
            ErrorTextLbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 176);
            button1.Name = "button1";
            button1.Size = new Size(294, 30);
            button1.TabIndex = 0;
            button1.Text = "Kelime Türet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LastWordLbl
            // 
            LastWordLbl.AutoSize = true;
            LastWordLbl.ForeColor = Color.Olive;
            LastWordLbl.Location = new Point(20, 27);
            LastWordLbl.Name = "LastWordLbl";
            LastWordLbl.Size = new Size(38, 15);
            LastWordLbl.TabIndex = 1;
            LastWordLbl.Text = "Araba";
            // 
            // CurrentLetterLbl
            // 
            CurrentLetterLbl.AutoSize = true;
            CurrentLetterLbl.ForeColor = Color.Red;
            CurrentLetterLbl.Location = new Point(20, 57);
            CurrentLetterLbl.Name = "CurrentLetterLbl";
            CurrentLetterLbl.Size = new Size(13, 15);
            CurrentLetterLbl.TabIndex = 2;
            CurrentLetterLbl.Text = "a";
            // 
            // wordTxb
            // 
            wordTxb.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            wordTxb.Location = new Point(12, 138);
            wordTxb.Multiline = true;
            wordTxb.Name = "wordTxb";
            wordTxb.Size = new Size(294, 32);
            wordTxb.TabIndex = 3;
            // 
            // ErrorTextLbl
            // 
            ErrorTextLbl.AutoSize = true;
            ErrorTextLbl.ForeColor = Color.Red;
            ErrorTextLbl.Location = new Point(20, 120);
            ErrorTextLbl.Name = "ErrorTextLbl";
            ErrorTextLbl.Size = new Size(0, 15);
            ErrorTextLbl.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 224);
            Controls.Add(ErrorTextLbl);
            Controls.Add(wordTxb);
            Controls.Add(CurrentLetterLbl);
            Controls.Add(LastWordLbl);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Kelimenin Son Harfi";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label LastWordLbl;
        private Label CurrentLetterLbl;
        private TextBox wordTxb;
        private Label ErrorTextLbl;
    }
}