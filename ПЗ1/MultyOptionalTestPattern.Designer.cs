namespace ПЗ1
{
    partial class MultyOptionalTestPattern
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
            this.question = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.question.Location = new System.Drawing.Point(80, 54);
            this.question.MaximumSize = new System.Drawing.Size(650, 130);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(650, 130);
            this.question.TabIndex = 3;
            this.question.Text = "Questions";
            this.question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.prevButton.Location = new System.Drawing.Point(12, 12);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(100, 30);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "Назад";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nextButton.Location = new System.Drawing.Point(690, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 30);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(360, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 45);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // counter
            // 
            this.counter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(379, 17);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(64, 25);
            this.counter.TabIndex = 10;
            this.counter.Text = "label1";
            // 
            // MultyOptionalTestPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.question);
            this.MaximumSize = new System.Drawing.Size(820, 1000);
            this.Name = "MultyOptionalTestPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultyOptionalTestPattern";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MultyOptionalTestPattern_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label counter;
    }
}