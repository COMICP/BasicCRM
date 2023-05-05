namespace WinFormsApp1
{
    partial class Home
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
            AddQuoteButton = new Button();
            QuitProgram = new Button();
            ViewQuotes = new Button();
            SearchButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddQuoteButton
            // 
            AddQuoteButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AddQuoteButton.Location = new Point(34, 29);
            AddQuoteButton.Name = "AddQuoteButton";
            AddQuoteButton.Size = new Size(234, 70);
            AddQuoteButton.TabIndex = 0;
            AddQuoteButton.Text = "Add New Quote";
            AddQuoteButton.UseVisualStyleBackColor = true;
            AddQuoteButton.Click += AddQuoteButton_Click;
            // 
            // QuitProgram
            // 
            QuitProgram.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            QuitProgram.Location = new Point(34, 355);
            QuitProgram.Name = "QuitProgram";
            QuitProgram.Size = new Size(234, 70);
            QuitProgram.TabIndex = 1;
            QuitProgram.Text = "Exit";
            QuitProgram.UseVisualStyleBackColor = true;
            QuitProgram.Click += QuitProgram_Click;
            // 
            // ViewQuotes
            // 
            ViewQuotes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ViewQuotes.Location = new Point(34, 105);
            ViewQuotes.Name = "ViewQuotes";
            ViewQuotes.Size = new Size(234, 70);
            ViewQuotes.TabIndex = 2;
            ViewQuotes.Text = "View Quotes";
            ViewQuotes.UseVisualStyleBackColor = true;
            ViewQuotes.Click += ViewQuotes_Click;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(34, 181);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(234, 70);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search Quotes";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 196);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 4;
            label1.Text = "Imagine a cool image here";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(SearchButton);
            Controls.Add(ViewQuotes);
            Controls.Add(QuitProgram);
            Controls.Add(AddQuoteButton);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddQuoteButton;
        private Button QuitProgram;
        private Button ViewQuotes;
        private Button SearchButton;
        private Label label1;
    }
}