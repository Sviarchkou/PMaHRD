using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПЗ1
{
    public partial class MultyOptionalTestPattern : Form
    {
        public MainMenu mainMenu;
        public int buttonNumber { get; set; } 

        int score = 0;
        List<string> questions;
        List<List<Option>> options = new List<List<Option>>();
        List<Result> result;
        int currentIndex = 0;
        int[] scores;
        int[] selectedOption;
        Point startPoint = new Point(50, 150);
        Control[] controls;

        public MultyOptionalTestPattern(MultyOptionalTests test)
        {
            InitializeComponent();
            this.Text = test.name;
            questions = test.questions;
            options = test.options;
            result = test.result;
            scores = new int[questions.Count];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = -1;
            }
            selectedOption = new int[questions.Count];
            changeQuestion();
            this.counter.Text = (currentIndex + 1) + "/" + questions.Count;
        }

        private void changeQuestion()
        {

            if (currentIndex == questions.Count)
            {
                question.Size = question.MaximumSize = new Size(question.Width, 300);
                question.Location = new Point(55, 15);
                question.Text = "Тест пройден \nБалл: " + getScore() + "\n" + getResult();

                controls = this.Controls.Find("radioButton", true);
                for (int i = 0; i < controls.Length; i++)
                {
                    controls[i].Visible = false;
                }
                nextButton.Visible = false;
                prevButton.Visible = false;
                counter.Visible = false;
                exitButton.Visible = true;

                return;
            }

            if (currentIndex == 0) prevButton.Enabled = false;
            else prevButton.Enabled = true;

            question.Text = questions[currentIndex];

            if (controls != null)
            {
                foreach (Control c in controls)
                {
                    this.Controls.Remove(c);
                }
                controls = null;
            }

            Point buffer = new Point(0, 55);
            Point point = startPoint;
            foreach (Option opt in options[currentIndex])
            {

                RadioButton radioButton = createNewRadioButton(point);
                point.Offset(buffer.X, buffer.Y);
                if (this.Height < point.Y + 50)
                {
                    this.Size = new Size(this.Width, point.Y + 50);
                }

                radioButton.Text = opt.strOption;
                this.Controls.Add(radioButton);
            }

            controls = this.Controls.Find("radioButton", true);

            if (scores[currentIndex] != -1)
                ((RadioButton)controls[selectedOption[currentIndex]]).Checked = true;
            else
                nextButton.Enabled = false;
            foreach  (Control c in controls)
            {
                ((RadioButton)c).AutoCheck = true;
            }
        }


        private void addPointsToScore()
        {
            for (int i = 0; i < controls.Length; i++)
            {
                if (((RadioButton)controls[i]).Checked)
                {
                    scores[currentIndex] = options[currentIndex][i].value;
                    selectedOption[currentIndex] = i;
                    break;
                }
            }

        }

        private int getScore()
        {
            foreach (int c in scores)
            {
                score += c;
            }
            return score;
        }

        private string getResult()
        {
            foreach (Result r in result)
            {
                if (r.score >= score)
                {
                    return r.strResult;
                }
            }
            return result.Last().strResult;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
        }
        
        private RadioButton createNewRadioButton(Point location)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            radioButton.Location = location;
            radioButton.MinimumSize = new System.Drawing.Size(500, 50);
            radioButton.Size = new System.Drawing.Size(500, 50);
            radioButton.TabIndex = 0;
            radioButton.TabStop = true;
            radioButton.Name = "radioButton";
            radioButton.AutoCheck = false;
            radioButton.UseVisualStyleBackColor = true;
            radioButton.Anchor = AnchorStyles.Left;
            radioButton.CheckedChanged += radioButton_CheckedChanged;
            return radioButton;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            addPointsToScore();
            currentIndex++;
            changeQuestion();
            this.counter.Text = (currentIndex + 1) + "/" + questions.Count;
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentIndex--;
            changeQuestion();
            nextButton.Enabled = true;
            this.counter.Text = (currentIndex +1) + "/" + questions.Count;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

            try
            {
                if (buttonNumber != 0)
                {
                    mainMenu.afterTestActivation(buttonNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private void MultyOptionalTestPattern_FormClosed(object sender, FormClosedEventArgs e)
        {
            try {
                mainMenu.Show();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
