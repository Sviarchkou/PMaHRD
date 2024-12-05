using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПЗ1
{
    public partial class StartForm : Form
    {
        private const string TEST_1_FOLDER = "Делегирование";
        private const string TEST_2_FOLDER = "Отбор персонала";
        private const string TEST_3_FOLDER = "Адаптация сотрудников";
        private const string TEST_4_FOLDER = "Мотивация персонала";
        private const string TEST_5_FOLDER = "Системы компенсации и стимулирования персонала";
        private const string TEST_6_FOLDER = "Управление проблемными сотрудниками";
        private const string TEST_7_FOLDER = "Создание эффективной команды";
        private const string TEST_8_FOLDER = "Развитие персонала";

        private const string MAIN_FOLDER = "Тесты";

        private Form activeForm;
        private Button currentButton= new Button();
        private Color DEFAULT_BUTTON_COLOR = Color.FromArgb(51, 51, 76);
        private Random random = new Random();
        private int curIndex;

        public StartForm()
        {
            InitializeComponent();
        }

        private void changeTest(string path)
        {
            if (activeForm != null)
                activeForm.Close();

            MainMenu mainMenu = new MainMenu(path);
            activeForm = mainMenu;
            mainMenu.TopLevel = false;
            testPanel.Controls.Add(mainMenu);
            mainMenu.BringToFront();
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button1;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_1_FOLDER);
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button2;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_2_FOLDER); 
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button3;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_3_FOLDER); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button4;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_4_FOLDER);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button5;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_5_FOLDER);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button6;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_6_FOLDER);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button7;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_7_FOLDER);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentButton.BackColor = DEFAULT_BUTTON_COLOR;
            currentButton = button8;
            resetColor();
            changeTest(MAIN_FOLDER + "\\" + TEST_8_FOLDER);
        }


        private void resetColor()
        {
            int index = random.Next(ThemeColors.colors.Count);
            while (index == curIndex)
            {
                index = random.Next(ThemeColors.colors.Count);
            }
            currentButton.BackColor = ThemeColors.colors[index];
            panel3.BackColor = ThemeColors.colors[index];
            panel4.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.colors[index], -0.3);            
        }
    }


    public class ThemeColors
    {
        public static List<Color> colors = new List<Color> { 
            Color.FromArgb(235, 76, 66),
            Color.FromArgb(254, 40, 162),
            Color.FromArgb(83,68,238),
            Color.FromArgb(27,141,147),
            Color.FromArgb(52,100,12),
            Color.FromArgb(157,108,2),
            Color.FromArgb(139,194,10),
            Color.FromArgb(0,138,80),
            Color.FromArgb(247, 148, 60),
            Color.FromArgb(246, 74, 70),
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
