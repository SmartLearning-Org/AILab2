

namespace AILab2
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }



        private async void AnswerButton_Click(object sender, EventArgs e)
        {
            ProgressBar.Visible = true;
            AnswerLabel.Text = "";

            if (QuestionBox.Text == "")
            {
                MessageBox.Show("Du skal skrive et sp�rgsm�l", "Fejl");
                ProgressBar.Visible = false;
                return;
            }

            if (YesNoButton.Checked)
            {
            }
            else if (ShortAnswerButton.Checked)
            {
            }
            else if (LongAnswerButton.Checked)
            {

            }
            else
            {
                MessageBox.Show("Du skal v�lge en svartype", "Fejl");                
            }

            ProgressBar.Visible = false;
        }
    }
}