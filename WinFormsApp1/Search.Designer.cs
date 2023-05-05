namespace WinFormsApp1
{
    partial class Search
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
            HomeButton = new Button();
            SearchIn = new Label();
            textBox1 = new TextBox();
            Output = new Label();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.Location = new Point(27, 351);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(155, 74);
            HomeButton.TabIndex = 20;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // SearchIn
            // 
            SearchIn.AutoSize = true;
            SearchIn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchIn.Location = new Point(27, 38);
            SearchIn.Name = "SearchIn";
            SearchIn.Size = new Size(58, 28);
            SearchIn.TabIndex = 19;
            SearchIn.Text = "Input";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(133, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 34);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Output.Location = new Point(345, 35);
            Output.Name = "Output";
            Output.Size = new Size(0, 28);
            Output.TabIndex = 22;
            Output.Click += Output_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(HomeButton);
            Controls.Add(SearchIn);
            Controls.Add(textBox1);
            Name = "Search";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private Label SearchIn;
        private TextBox textBox1;
        private Label Output;
    }
}