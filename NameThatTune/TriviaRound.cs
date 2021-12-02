using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameThatTune
{
    public enum ImageSelect
    {
        Image1,
        Image2,
        Image3,
        Image4,
        Image5,
        Image6,
        Image7,
        Image8,
        None
    }

    public partial class TriviaRound : Form
    {
        frmPlayerSetup parent;
        Player player1, player2;
        Question[] Q_Bank_1 = new Question[5];
        
        public void R1_Questions()
        {
            Q_Bank_1[0] = new Question();
            Q_Bank_1[0].prompt = "Which of these songs is NOT by the artist Beyonce?";
            Q_Bank_1[0].answerBank[0] = "Irreplaceable";
            Q_Bank_1[0].answerBank[1] = "Halo";
            Q_Bank_1[0].answerBank[2] = "Run The World";
            Q_Bank_1[0].answerBank[3] = "Truth Hurts";
            Q_Bank_1[0].answer = "Truth Hurts";

            Q_Bank_1[1] = new Question();
            Q_Bank_1[1].prompt = "Which of these songs features the artist Drake?";
            Q_Bank_1[1].answerBank[0] = "Choppa Style";
            Q_Bank_1[1].answerBank[1] = "A Milli";
            Q_Bank_1[1].answerBank[2] = "Right above it";
            Q_Bank_1[1].answerBank[3] = "Lambourghini Mercy";
            Q_Bank_1[1].answer = "Right Above it";

            Q_Bank_1[2] = new Question();
            Q_Bank_1[2].prompt = @"In the song 'Lose Yourself', Eminem said, 'knees weak....', what came next?";
            Q_Bank_1[2].answerBank[0] = "arms are heavy";
            Q_Bank_1[2].answerBank[1] = "mom's spaghetti";
            Q_Bank_1[2].answerBank[2] = "he looks calm and ready";
            Q_Bank_1[2].answerBank[3] = "palms are sweaty";
            Q_Bank_1[2].answer = "arms are heavy";

            Q_Bank_1[3] = new Question();
            Q_Bank_1[3].prompt = "What is considered to be Justin Beiber's first hit song?";
            Q_Bank_1[3].answerBank[0] = "Baby";
            Q_Bank_1[3].answerBank[1] = "One Time";
            Q_Bank_1[3].answerBank[2] = "Let Me Love You";
            Q_Bank_1[3].answerBank[3] = "Low";
            Q_Bank_1[3].answer = "One Time";

            Q_Bank_1[4] = new Question();
            Q_Bank_1[4].prompt = "What was the name of the musical group that Michael Jackson sang 'ABC' in when he was a child?";
            Q_Bank_1[4].answerBank[0] = "The Jackson's";
            Q_Bank_1[4].answerBank[1] = "Michael Jackson";
            Q_Bank_1[4].answerBank[2] = "Jackson 5";
            Q_Bank_1[4].answerBank[3] = "Mikey J";
            Q_Bank_1[4].answer = "Jackson 5";
        }

        private ImageSelect state = ImageSelect.None;
        public TriviaRound()
        {
            InitializeComponent();
        }
        public TriviaRound(frmPlayerSetup parent, Player p1, Player p2)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
            player1 = new Player(p1);
            player2 = new Player(p2);     // string prompt = questionBank.Q_Bank[0].prompt;

        }

        public void GetQuestions()
        {
            
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Question.Q_Bank;
        }

        private void TriviaRound_Load(object sender, EventArgs e)
        {
            //load with title and rules; will change to player turn and question when they continue
            lblTurn.Text = "Name That Tune: Trivia Game Round";
            lblQuestion.Text = "Rules: For each question, answer with the correct song title. Each question is $1000 more than the next and starting at $1000 ";
            //hide answer checkbox until question 1
            chkboxAnswers.Visible = false;
            R1_Questions();

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            chkboxAnswers.Visible = true;
            if (state == ImageSelect.None)
            {
                pictureBox1.Image = Properties.Resources.image_1;
                state = ImageSelect.Image1;
                lblTurn.Text = $"{player1.Name}'s Turn";
                lblQuestion.Text = this.Q_Bank_1[0].prompt;
            }
            else if (state == ImageSelect.Image1)
            {
                pictureBox1.Image = Properties.Resources.image_2;
                state = ImageSelect.Image2;

                lblTurn.Text = player2.Name + "'s Turn";
                //lblQuestion.Text = "Question 2: " + q2.prompt
                //answers
            }
            else if (state == ImageSelect.Image2)
            {
                pictureBox1.Image = Properties.Resources.image_3;
                state = ImageSelect.Image3;

                lblTurn.Text = player1.Name + "'s Turn";
                //lblQuestion.Text = "Question 3: " + q3.prompt
            }
            else if (state == ImageSelect.Image3)
            {
                pictureBox1.Image = Properties.Resources.image_4;
                state = ImageSelect.Image4;

                lblTurn.Text = player2.Name + "'s Turn";
                //lblQuestion.Text = "Question 4: " + q4.prompt
            }
            else if (state == ImageSelect.Image4)
            {
                pictureBox1.Image = Properties.Resources.image_5;
                state = ImageSelect.Image5;

                lblTurn.Text = player1.Name + "'s Turn";
                //lblQuestion.Text = "Question 5: " + q5.prompt
            }
            else if (state == ImageSelect.Image5)
            {
                pictureBox1.Image = Properties.Resources.image_6;
                state = ImageSelect.Image6;

                lblTurn.Text = player2.Name + "'s Turn";
                //lblQuestion.Text = "Question 6: " + q6.prompt
            }
            else if (state == ImageSelect.Image6)
            {
                pictureBox1.Image = Properties.Resources.image_7;
                state = ImageSelect.Image7;

                lblTurn.Text = player1.Name + "'s Turn";
                //lblQuestion.Text = "Question 7: " + q7.prompt
            }
            else if (state == ImageSelect.Image7)
            {
                pictureBox1.Image = Properties.Resources.image_8;
                state = ImageSelect.Image8;

                lblTurn.Text = player2.Name + "'s Turn";
                //lblQuestion.Text = "Question 8: " + q8.prompt
            }
        }
    }
}
