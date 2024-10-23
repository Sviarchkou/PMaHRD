using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ПЗ1
{
    public partial class MainMenu : Form
    {
        string path = "Отбор персонала";
        string pathTest1 = "Тест ПДТ-174";
        string pathTest2 = "Тест №2 - Делегирование";
        string pathTest3 = "Тест №3 - Делегирование";

        Color mouseEnter = System.Drawing.ColorTranslator.FromHtml("#fcf295");
        Color defaultFirstTestButtonColor = SystemColors.Control;
        Color defaultSecondTestButtonColor = SystemColors.Control;
        Color defaultThirdTestButtonColor = SystemColors.Control;

        public MainMenu()
        {
            InitializeComponent();
            string[] str;
            this.wellcomeLabel.Text = "Тесты на тему \"" + (str = path.Split('\\'))[str.Length - 1] + "\"";
            this.firstTestButton.Text = (str = pathTest1.Split('\\'))[str.Length - 1];
            this.secondTestButton.Text = (str = pathTest2.Split('\\'))[str.Length - 1];
            this.thirdTestButton.Text = (str = pathTest3.Split('\\'))[str.Length - 1];
        }


        private void firstTestButton_Click(object sender, EventArgs e)
        {
            TestPatternYN test = new TestPatternYN(new TestsYN(path + "/" + pathTest1));
            test.Show();
            test.mainMenu = this;
            test.buttonNumber = 1;
            this.Hide();
        }
        
        private void secondTestButton_Click(object sender, EventArgs e)
        {
            MultyOptionalTestPattern test = new MultyOptionalTestPattern(new MultyOptionalTests(path + "/" + pathTest2));
            test.Show();
            test.mainMenu = this;
            test.buttonNumber = 2;
            this.Hide();
        }

        private void thirdTestButton_Click(object sender, EventArgs e)
        {
            MultyOptionalTestPattern test = new MultyOptionalTestPattern(new MultyOptionalTests(path + "/" + pathTest3));
            test.Show();
            test.mainMenu = this;
            test.buttonNumber = 3;
            this.Hide();
        }

        public void afterTestActivation(int n)
        {
            this.Show();
            switch (n)
            {
                case 1:
                    defaultFirstTestButtonColor = System.Drawing.ColorTranslator.FromHtml("#9effa0");
                    firstTestButton.BackColor = defaultFirstTestButtonColor;
                    break;
                case 2:
                    defaultSecondTestButtonColor = System.Drawing.ColorTranslator.FromHtml("#9effa0");
                    secondTestButton.BackColor = defaultSecondTestButtonColor;
                    break;
                case 3:
                    defaultThirdTestButtonColor = System.Drawing.ColorTranslator.FromHtml("#9effa0");
                    thirdTestButton.BackColor = defaultThirdTestButtonColor;
                    break;
            }
        }

        /////////////////////////////////////////////////////

        private void firstTestButton_MouseEnter(object sender, EventArgs e)
        {
            this.firstTestButton.BackColor = mouseEnter;
        }

        private void firstTestButton_MouseLeave(object sender, EventArgs e)
        {
            this.firstTestButton.BackColor = defaultFirstTestButtonColor;
        }

        private void secondTestButton_MouseEnter(object sender, EventArgs e)
        {
            this.secondTestButton.BackColor = mouseEnter;
        }

        private void secondTestButton_MouseLeave(object sender, EventArgs e)
        {
            this.secondTestButton.BackColor = defaultSecondTestButtonColor;
        }

        private void thirdTestButton_MouseEnter(object sender, EventArgs e)
        {
            this.thirdTestButton.BackColor = mouseEnter;
        }

        private void thirdTestButton_MouseLeave(object sender, EventArgs e)
        {
            this.thirdTestButton.BackColor = defaultThirdTestButtonColor;
        }

    }
}
