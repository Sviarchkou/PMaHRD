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
        string path = "Адаптация";
        string pathTest1 = "Тест ПДТ-174";
        string pathTest2 = "Тест №2 - Делегирование";
        string pathTest3 = "Тест №1";
        
        Color mouseEnter = System.Drawing.ColorTranslator.FromHtml("#fcf295");
        Color defaultFirstTestButtonColor = Color.FromArgb(255, 210, 190);
        Color defaultSecondTestButtonColor = Color.FromArgb(255, 210, 190);
        Color defaultThirdTestButtonColor = Color.FromArgb(255, 210, 190);

        public MainMenu(string path)
        {
            this.path = path;
            InitializeComponent();
            //string[] str;

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            List<DirectoryInfo> directories = new List<DirectoryInfo>(directoryInfo.GetDirectories());

            this.wellcomeLabel.Text = "Тесты на тему \"" + directoryInfo.Name + "\"";
            this.firstTestButton.Text = pathTest1 = directories[0].Name;
            this.secondTestButton.Text = pathTest2 = directories[1].Name;
            this.thirdTestButton.Text = pathTest3 = directories[2].Name;


            /*
            this.wellcomeLabel.Text = "Тесты на тему \"" + (str = path.Split('\\'))[str.Length - 1] + "\"";
            this.firstTestButton.Text = pathTest1.Split('\\')[str.Length - 1];
            this.secondTestButton.Text = pathTest2.Split('\\')[str.Length - 1];
            this.thirdTestButton.Text = pathTest3.Split('\\')[str.Length - 1];
            */


        }


        private void firstTestButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            List<DirectoryInfo> directories = new List<DirectoryInfo>(directoryInfo.GetDirectories());
            if (File.Exists(path + "\\" + directories[0].Name + "\\options.json.txt"))
            {
                MultyOptionalTestPattern test = new MultyOptionalTestPattern(new MultyOptionalTests(path + "/" + pathTest1));
                test.Show();
                test.mainMenu = this;
                test.buttonNumber = 1;
                //this.Hide();             
            }
            else
            {
                TestPatternYN test = new TestPatternYN(new TestsYN(path + "/" + pathTest1));
                test.Show();
                test.mainMenu = this;
                test.buttonNumber = 1;
                //this.Hide();
            }
        }
        
        private void secondTestButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            List<DirectoryInfo> directories = new List<DirectoryInfo>(directoryInfo.GetDirectories());
            if (File.Exists(path + "\\" + directories[1].Name + "\\options.json.txt"))
            {
                MultyOptionalTestPattern test = new MultyOptionalTestPattern(new MultyOptionalTests(path + "/" + pathTest2));
                test.Show();
                test.mainMenu = this;
                test.buttonNumber = 2;
                //this.Hide();             
            }
            else
            {
                TestPatternYN test = new TestPatternYN(new TestsYN(path + "/" + pathTest2));
                test.Show();
                test.mainMenu = this;
                test.buttonNumber = 2;
                //this.Hide();
            }

        }

        private void thirdTestButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            List<DirectoryInfo> directories = new List<DirectoryInfo>(directoryInfo.GetDirectories());
            if (File.Exists(path + "\\" + directories[2].Name + "\\options.json.txt"))
            {
                MultyOptionalTestPattern test = new MultyOptionalTestPattern(new MultyOptionalTests(path + "/" + pathTest3));
                test.Show();
                test.mainMenu = this;
                test.buttonNumber = 3;
                //this.Hide();             
            }
            else
            {

                TestPatternYN test = new TestPatternYN(new TestsYN(path + "/" + pathTest3));
                test.Show();
                test.mainMenu = this;
                test.buttonNumber = 3;
               // this.Hide();
            }

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
