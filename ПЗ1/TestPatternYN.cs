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
        public MainMenu mainMenu;
        public int buttonNumber;

        int score = 0;
        List<string> questions;
        List<Result> result;
        int currentIndex = 0;
        int[] scores;

        public TestPatternYN(TestsYN test)
        {
            InitializeComponent();

            questions = test.questions;
            result = test.result;
            scores = new int[questions.Count];

            question.Text = questions[currentIndex];
            counter.Text = (currentIndex + 1) + "/" + questions.Count;
            prevButton.Enabled = false;

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (option1.Checked) scores[currentIndex] = 2;
            else scores[currentIndex] = -1;

            if (questions.Count - 1 == currentIndex)
            {
                question.Text = "Тест завершён\nВаш результат: " + getScore() + "\n\n" + getResult();
                nextButton.Enabled = false;
                prevButton.Enabled = false;
                option1.Enabled = false;
                option2.Enabled = false;
                exitButton.Visible = true;
                counter.Visible = false;
                return;
            }

            prevButton.Enabled = true;

            option1.Checked = false;
            option2.Checked = false;

            question.Text = questions[++currentIndex];
            counter.Text = (currentIndex + 1) + "/" + questions.Count;

            if (scores[currentIndex] == 2) 
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

            if (scores[currentIndex] == 2) option1.Checked = true;
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
            try
            {
                mainMenu.Show();
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

        private int getScore()
        {
            foreach (int c in scores)
            {
                if (c == 2)
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
            try
            {
                mainMenu.Show();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }


}
