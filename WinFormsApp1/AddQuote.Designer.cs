namespace WinFormsApp1
{
    partial class AddQuote
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            MaterialInput = new TextBox();
            HomeButton = new Button();
            SavedDisplay = new Label();
            Submit = new Button();
            Words = new Label();
            label6 = new Label();
            WidthInput = new TextBox();
            DepthInput = new TextBox();
            DrawrsInput = new TextBox();
            RushInput = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 132);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 12;
            label3.Text = "Depth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 82);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 10;
            label2.Text = "Width";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 36);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 8;
            label4.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(148, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 34);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 281);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 14;
            label1.Text = "Material";
            // 
            // MaterialInput
            // 
            MaterialInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MaterialInput.Location = new Point(148, 278);
            MaterialInput.Name = "MaterialInput";
            MaterialInput.Size = new Size(183, 34);
            MaterialInput.TabIndex = 13;
            MaterialInput.TextChanged += MaterialInput_TextChanged;
            // 
            // HomeButton
            // 
            HomeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.Location = new Point(42, 349);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(155, 74);
            HomeButton.TabIndex = 15;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // SavedDisplay
            // 
            SavedDisplay.AutoSize = true;
            SavedDisplay.Location = new Point(458, 36);
            SavedDisplay.Name = "SavedDisplay";
            SavedDisplay.Size = new Size(45, 15);
            SavedDisplay.TabIndex = 16;
            SavedDisplay.Text = "Display";
            SavedDisplay.Click += SavedDisplay_Click;
            // 
            // Submit
            // 
            Submit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.Location = new Point(205, 349);
            Submit.Name = "Submit";
            Submit.Size = new Size(126, 74);
            Submit.TabIndex = 17;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += button1_Click;
            // 
            // Words
            // 
            Words.AutoSize = true;
            Words.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Words.Location = new Point(42, 184);
            Words.Name = "Words";
            Words.Size = new Size(89, 28);
            Words.TabIndex = 19;
            Words.Text = "# Drawrs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 232);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 21;
            label6.Text = "Rush Time";
            // 
            // WidthInput
            // 
            WidthInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            WidthInput.Location = new Point(148, 82);
            WidthInput.Name = "WidthInput";
            WidthInput.Size = new Size(183, 34);
            WidthInput.TabIndex = 22;
            WidthInput.TextChanged += WidthInput_TextChanged;
            // 
            // DepthInput
            // 
            DepthInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DepthInput.Location = new Point(148, 132);
            DepthInput.Name = "DepthInput";
            DepthInput.Size = new Size(183, 34);
            DepthInput.TabIndex = 23;
            DepthInput.TextChanged += DepthInput_TextChanged;
            // 
            // DrawrsInput
            // 
            DrawrsInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            DrawrsInput.Location = new Point(148, 184);
            DrawrsInput.Name = "DrawrsInput";
            DrawrsInput.Size = new Size(183, 34);
            DrawrsInput.TabIndex = 24;
            DrawrsInput.TextChanged += DrawrsInput_TextChanged;
            // 
            // RushInput
            // 
            RushInput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RushInput.Location = new Point(148, 232);
            RushInput.Name = "RushInput";
            RushInput.Size = new Size(183, 34);
            RushInput.TabIndex = 25;
            RushInput.TextChanged += RushInput_TextChanged;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RushInput);
            Controls.Add(DrawrsInput);
            Controls.Add(DepthInput);
            Controls.Add(WidthInput);
            Controls.Add(label6);
            Controls.Add(Words);
            Controls.Add(Submit);
            Controls.Add(SavedDisplay);
            Controls.Add(HomeButton);
            Controls.Add(label1);
            Controls.Add(MaterialInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Name = "AddQuote";
            Text = "AddQuote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private TextBox MaterialInput;
        private Button HomeButton;
        private Label SavedDisplay;
        private Button Submit;
        private Label Words;
        private Label label6;
        private TextBox WidthInput;
        private TextBox DepthInput;
        private TextBox DrawrsInput;
        private TextBox RushInput;
    }
}