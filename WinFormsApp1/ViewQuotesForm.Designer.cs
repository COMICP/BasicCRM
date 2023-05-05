namespace WinFormsApp1
{
    partial class ViewQuotesForm
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
            ListOutput = new Label();
            label1 = new Label();
            Show = new Button();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            HomeButton.Location = new Point(42, 339);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(155, 74);
            HomeButton.TabIndex = 16;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ListOutput
            // 
            ListOutput.AutoSize = true;
            ListOutput.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListOutput.Location = new Point(219, 38);
            ListOutput.Name = "ListOutput";
            ListOutput.Size = new Size(0, 28);
            ListOutput.TabIndex = 17;
            ListOutput.Click += ListOutput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 18;
            label1.Text = "Quotes:";
            // 
            // Show
            // 
            Show.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Show.Location = new Point(42, 259);
            Show.Name = "Show";
            Show.Size = new Size(155, 74);
            Show.TabIndex = 19;
            Show.Text = "Show Quotes";
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // ViewQuotesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Show);
            Controls.Add(label1);
            Controls.Add(ListOutput);
            Controls.Add(HomeButton);
            Name = "ViewQuotesForm";
            Text = "ViewQuotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private Label ListOutput;
        private Label label1;
        private Button Show;
    }
}