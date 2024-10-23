using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ПЗ1
{
    public partial class TestDescriptionForm : Form
    {
        public MainMenu mainMenu { get; set; }
        public int buttonNumber { get; set; }

        TestDescription testDescription;
        int[] scores;
        List<int> progress;
        DescriptionController descriptionController;
        List<Control> descriptions;
        List<Control> progressBars;

        Point point = new Point(50, 30);
        public TestDescriptionForm(string path, int[] scores)
        {
            InitializeComponent();
            testDescription = new TestDescription(path);
            string[] str;
            this.Text = (str = path.Split('\\'))[str.Length - 1];
            this.scores = scores;
            descriptionController = new DescriptionController(testDescription, scores);
            progress = descriptionController.progress;
            
            Application.VisualStyleState = VisualStyleState.NoneEnabled;

            descriptions = new List<Control>();
            progressBars = new List<Control>();

            fillControls();
        }

        private void fillControls()
        {
            if (testDescription == null) throw new NullReferenceException("testDescription isn't initialized");

            int i = 0;
            foreach (Factor factor in testDescription.fastors)
            {
                Label label = createLabel(point);
                label.Text = factor.name;
                this.Controls.Add(label);

                ProgressBar progressBar = createProgressBar(new Point(point.X, point.Y + 30));
                progressBar.Value = progress[i];
                if (progressBar.Value < 30)
                {
                    progressBar.ForeColor = Color.Yellow;
                }
                else if (progressBar.Value < 70)
                {
                    progressBar.ForeColor = Color.Green;
                }
                else
                {
                    progressBar.ForeColor = Color.Blue;
                }
                this.Controls.Add(progressBar);
                progressBars.Add(progressBar);

                point.Y = point.Y + 80;
                i++;
            }

            i = 0;
            foreach (Factor factor in testDescription.fastors)
            {
                Label title = createTitle(point);
                title.Text = factor.name;
                this.Controls.Add(title);

                Label description = createDecription(new Point(point.X, point.Y + 30));
                description.Text = factor.description[0];
                if (factor.description.Count == 4)
                {
                    if (progress[i] < 30)
                    {
                        description.Text += "\n" + factor.description[1];
                    }
                    else if (progress[i] < 70)
                    {
                        description.Text += "\n" + factor.description[2];
                    }
                    else
                    {
                        description.Text += "\n" + factor.description[3];
                    }
                }
                this.Controls.Add(description);
                descriptions.Add(description);

                point.Y = point.Y + description.Height + 60;
                i++;
            }

        }

        private Label createLabel(Point location)
        {
            Label label = new Label();
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            label.Location = location;
            label.Name = "factor";
            label.Size = new System.Drawing.Size(180, 30);
            label.AutoSize = true;
            label.TabIndex = 1;
            label.Text = "factor name";
            label.Visible = true;
            label.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            return label;
        }

        private ProgressBar createProgressBar(Point location)
        {
            ProgressBar bar = new ProgressBar();
            bar.Location = location;
            bar.TabIndex = 2;
            bar.Name = "Bar";
            bar.Size = new System.Drawing.Size(400, 20);
            bar.Minimum = 0;
            bar.Step = 1;
            bar.Maximum = 100;
            bar.Visible = true;
            return bar;
        }
        
        private Label createTitle(Point location)
        {
            Label label = new Label();
            label.Location = location;
            label.Name = "factor";
            label.Size = new System.Drawing.Size(180, 30);
            label.AutoSize = true; 
            label.TabIndex = 3;
            label.Text = "factor name";
            label.Font = new System.Drawing.Font("Arial", 16F, FontStyle.Bold);
            label.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            label.Visible = true;
            return label;
        }

        private Label createDecription(Point location)
        {
            Label label = new Label();
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            label.Location = location;
            label.MaximumSize = new Size(500, Int32.MaxValue);
            label.Name = "factor";
            label.AutoSize = true;
            label.TabIndex = 4;
            label.Text = "factor decription";
            label.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            label.Visible = true;
            return label;
        }

        private void TestDescriptionForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
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

        private void TestDescriptionForm_SizeChanged(object sender, EventArgs e)
        {
            if (progressBars == null || descriptions == null) return;
            if (this.Width > 497)
            {
                foreach (Control progressBar in progressBars)
                { 
                    progressBar.Size = new Size(this.Width - 317, progressBar.Height);
                }
                foreach (Control description in descriptions)
                { 
                    description.MaximumSize = new Size(this.Width - 125, Int32.MaxValue);
                }
            }
        }
    }
}
