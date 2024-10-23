namespace ПЗ1
{
    partial class TestPatternYN
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
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.question.Location = new System.Drawing.Point(76, 88);
            this.question.MaximumSize = new System.Drawing.Size(650, 200);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(650, 200);
            this.question.TabIndex = 2;
            this.question.Text = "Questions";
            this.question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(464, 360);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 40);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Вперёд";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevButton.Location = new System.Drawing.Point(238, 360);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(100, 40);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "Назад";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // option1
            // 
            this.option1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.option1.Location = new System.Drawing.Point(326, 315);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(53, 24);
            this.option1.TabIndex = 6;
            this.option1.TabStop = true;
            this.option1.Text = "Да";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // option2
            // 
            this.option2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.option2.Location = new System.Drawing.Point(429, 315);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(63, 24);
            this.option2.TabIndex = 7;
            this.option2.TabStop = true;
            this.option2.Text = "Нет";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(344, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 42);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(20, 20);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(64, 25);
            this.counter.TabIndex = 9;
            this.counter.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 104);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestPatternYN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.question);
            this.Name = "TestPatternYN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestPattern1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestPatternYN_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button button1;
    }
}