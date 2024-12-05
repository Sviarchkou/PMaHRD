using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ПЗ1
{
    public partial class TestPatternYN : Form
    {
        public MainMenu mainMenu { get; set; }
        public int buttonNumber { get; set; }
        public TestDescription testDesctription { get; set; }
        public TestDescriptionForm desciptionForm { get; set; }

        string path;
        int score = 0;
        List<string> questions;
        List<Result> result;
        int currentIndex = 0;

        public int[] scores { get; }

        public TestPatternYN(TestsYN test)
        {
            InitializeComponent();
            this.Text = test.name;
            this.path = test.path;
            questions = test.questions;
            result = test.result;
            scores = new int[questions.Count];
            if (test.testDescription != null)
            {
                testDesctription = test.testDescription;
            }

            question.Text = questions[currentIndex];
            counter.Text = (currentIndex + 1) + "/" + questions.Count;
            prevButton.Enabled = false;

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (option1.Checked) scores[currentIndex] = 1;
            else scores[currentIndex] = -1;

            if (questions.Count - 1 == currentIndex)
            {
                nextButton.Visible = false;
                prevButton.Visible= false;
                option1.Visible = false;
                option2.Visible = false;
                exitButton.Visible = true;
                counter.Visible = false;

                if (this.testDesctription != null)
                {
                    question.Text = "Тест завершён" + "\n\n" + getResult();
                    if (testDesctription != null)
                    {
                        exitButton.Text = "Смотреть описание";
                        exitButton.Left -= 60;
                        exitButton.Width += 120;
                    }
                    
                    

                }
                else
                    question.Text = "Тест завершён\nВаш результат: " + getScore() + "\n\n" + getResult();            
                return;
            }

            prevButton.Enabled = true;

            option1.Checked = false;
            option2.Checked = false;

            question.Text = questions[++currentIndex];
            counter.Text = (currentIndex + 1) + "/" + questions.Count;

            if (scores[currentIndex] == 1) 
                option1.Checked = true;
            else if (scores[currentIndex] == -1) 
                option2.Checked = true;
            else
                nextButton.Enabled = false;
            
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
           
            question.Text = questions[--currentIndex];
            counter.Text = (currentIndex + 1) + "/" + questions.Count;

            if (scores[currentIndex] == 1) option1.Checked = true;
            else option2.Checked = true;
            nextButton.Enabled = true;

            if (currentIndex == 0) prevButton.Enabled = false;
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getScore()
        {
            foreach (int c in scores)
            {
                if (c == 1)
                    score++;
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

        private void TestPatternYN_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (questions.Count - 1 != currentIndex)
            {
                return;
            }

            if (testDesctription != null)
            {
                try
                {
                    desciptionForm = new TestDescriptionForm(path, scores);
                    desciptionForm.mainMenu = mainMenu;
                    desciptionForm.buttonNumber = buttonNumber;
                    desciptionForm.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                return;
            }
            else
            {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(0, 32);
            if (i <= 16)
                option1.Checked = true;
            else
                option2.Checked = true;

            nextButton_Click(sender, e);
        }
    }


}
