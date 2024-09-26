namespace ПЗ1
{
    partial class MainMenu
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
            this.wellcomeLabel = new System.Windows.Forms.Label();
            this.firstTestButton = new System.Windows.Forms.Button();
            this.secondTestButton = new System.Windows.Forms.Button();
            this.thirdTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wellcomeLabel
            // 
            this.wellcomeLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.wellcomeLabel.Location = new System.Drawing.Point(12, 57);
            this.wellcomeLabel.Name = "wellcomeLabel";
            this.wellcomeLabel.Size = new System.Drawing.Size(776, 40);
            this.wellcomeLabel.TabIndex = 0;
            this.wellcomeLabel.Text = "Тесты на тему \"Делегирование\"";
            this.wellcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstTestButton
            // 
            this.firstTestButton.BackColor = System.Drawing.SystemColors.Control;
            this.firstTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstTestButton.Location = new System.Drawing.Point(150, 150);
            this.firstTestButton.Name = "firstTestButton";
            this.firstTestButton.Size = new System.Drawing.Size(520, 60);
            this.firstTestButton.TabIndex = 1;
            this.firstTestButton.Text = "Тест №1 \"Умеете ли вы делегировать полномочия\"";
            this.firstTestButton.UseVisualStyleBackColor = false;
            this.firstTestButton.Click += new System.EventHandler(this.firstTestButton_Click);
            this.firstTestButton.MouseEnter += new System.EventHandler(this.firstTestButton_MouseEnter);
            this.firstTestButton.MouseLeave += new System.EventHandler(this.firstTestButton_MouseLeave);
            // 
            // secondTestButton
            // 
            this.secondTestButton.BackColor = System.Drawing.SystemColors.Control;
            this.secondTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondTestButton.Location = new System.Drawing.Point(150, 240);
            this.secondTestButton.Name = "secondTestButton";
            this.secondTestButton.Size = new System.Drawing.Size(520, 60);
            this.secondTestButton.TabIndex = 2;
            this.secondTestButton.Text = "Тест №2 \"Делегирование\"";
            this.secondTestButton.UseVisualStyleBackColor = false;
            this.secondTestButton.Click += new System.EventHandler(this.secondTestButton_Click);
            this.secondTestButton.MouseEnter += new System.EventHandler(this.secondTestButton_MouseEnter);
            this.secondTestButton.MouseLeave += new System.EventHandler(this.secondTestButton_MouseLeave);
            // 
            // thirdTestButton
            // 
            this.thirdTestButton.BackColor = System.Drawing.SystemColors.Control;
            this.thirdTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdTestButton.Location = new System.Drawing.Point(150, 330);
            this.thirdTestButton.Name = "thirdTestButton";
            this.thirdTestButton.Size = new System.Drawing.Size(520, 60);
            this.thirdTestButton.TabIndex = 3;
            this.thirdTestButton.Text = "Тест №3 \"Делегирование\"";
            this.thirdTestButton.UseVisualStyleBackColor = false;
            this.thirdTestButton.Click += new System.EventHandler(this.thirdTestButton_Click);
            this.thirdTestButton.MouseEnter += new System.EventHandler(this.thirdTestButton_MouseEnter);
            this.thirdTestButton.MouseLeave += new System.EventHandler(this.thirdTestButton_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thirdTestButton);
            this.Controls.Add(this.secondTestButton);
            this.Controls.Add(this.firstTestButton);
            this.Controls.Add(this.wellcomeLabel);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wellcomeLabel;
        private System.Windows.Forms.Button firstTestButton;
        private System.Windows.Forms.Button secondTestButton;
        private System.Windows.Forms.Button thirdTestButton;
    }
}