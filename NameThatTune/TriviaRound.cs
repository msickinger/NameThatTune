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
        Image9, 
        Image10,
        None
    }

    public partial class TriviaRound : Form
    {
        frmPlayerSetup parent;
        Player player1, player2;
        Question[] Q_Bank_1 = new Question[5];
        bool flagBox1 = false;
        bool flagBox2 = false;
        bool flagBox3 = false; 
        bool flagBox4 = false;
        
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
            lblTurn.Text = "Name That Tune: Trivia Round!";
            lblQuestion.Text = "Rules: Each Player will get the chance to answer five questions. Each question is worth $1000" + 
                ", and if either opponent gets them all right, they will recievea a $50";
            btnNextQuestion.Text = "OK";
            R1_Questions();

        }
        private void Btn_Choice1_Click(object sender, EventArgs e)
        {
            flagBox1 = true;
        }
        private void Btn_Choice2_Click(object sender, EventArgs e)
        {
            flagBox2 = true;
        }
        private void Btn_Choice3_Click(object sender, EventArgs e)
        {
            flagBox3 = true;
        }
        private void Btn_Choice4_Click(object sender, EventArgs e)
        {
            flagBox4 = true;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            btnNextQuestion.Text = "Next Question.";

            if (state == ImageSelect.None)
            {
                // Image Setup
                pictureBox1.Image = Properties.Resources.image_1;
                state = ImageSelect.Image1;

                // Question Setup
                string answer = Q_Bank_1[0].answer;
                lblTurn.Text = $"{player1.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[0].prompt;
                Btn_Choice1.Text = Q_Bank_1[0].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[0].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[0].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[0].answerBank[3];

                if (flagBox4 == true)
                {
                    player1.Cash += 1000;
                    flagBox4 = false;
                }
            }
            else if (state == ImageSelect.Image1)
            {
                pictureBox1.Image = Properties.Resources.image_2;
                state = ImageSelect.Image2;

                lblTurn.Text = $"{player1.Name}'s Turn";

                string answer = Q_Bank_1[1].answer;
                lblTurn.Text = $"{player1.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[1].prompt;
                Btn_Choice1.Text = Q_Bank_1[1].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[1].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[1].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[1].answerBank[3];

                if (flagBox3 == true)
                {
                    player1.Cash += 1000;
                    flagBox3 = false;
                }
            }
            else if (state == ImageSelect.Image2)
            {
                pictureBox1.Image = Properties.Resources.image_3;
                state = ImageSelect.Image3;

                lblTurn.Text = $"{player1.Name}'s Turn";

                string answer = Q_Bank_1[2].answer;
                lblTurn.Text = $"{player1.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[2].prompt;
                Btn_Choice1.Text = Q_Bank_1[2].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[2].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[2].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[2].answerBank[3];

                if (flagBox1 == true)
                {
                    player1.Cash += 1000;
                    flagBox1 = false;
                }
            }
            else if (state == ImageSelect.Image3)
            {
                pictureBox1.Image = Properties.Resources.image_4;
                state = ImageSelect.Image4;

                lblTurn.Text = $"{player1.Name}'s Turn";

                string answer = Q_Bank_1[3].answer;
                lblTurn.Text = $"{player1.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[3].prompt;
                Btn_Choice1.Text = Q_Bank_1[3].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[3].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[3].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[3].answerBank[3];

                if (flagBox2 == true)
                {
                    player1.Cash += 1000;
                    flagBox2 = false;
                }
            }
            else if (state == ImageSelect.Image4)
            {
                pictureBox1.Image = Properties.Resources.image_5;
                state = ImageSelect.Image5;

                lblTurn.Text = $"{player1.Name}'s Turn";

                string answer = Q_Bank_1[4].answer;
                lblTurn.Text = $"{player1.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[4].prompt;
                Btn_Choice1.Text = Q_Bank_1[4].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[4].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[4].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[4].answerBank[3];

                if (flagBox3 == true)
                {
                    player1.Cash += 1000;
                    flagBox3 = false;
                }
            }
            else if (state == ImageSelect.Image5)
            {
                // Image Setup
                pictureBox1.Image = Properties.Resources.image_6;
                state = ImageSelect.Image6;

                // Question Setup
                string answer = Q_Bank_1[0].answer;
                lblTurn.Text = $"{player2.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[0].prompt;
                Btn_Choice1.Text = Q_Bank_1[0].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[0].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[0].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[0].answerBank[3];
                // Answer Check
                if (flagBox4 == true)
                {
                    player2.Cash += 1000;
                    flagBox4 = false;
                }
            }
            else if (state == ImageSelect.Image6)
            {
                pictureBox1.Image = Properties.Resources.image_7;
                state = ImageSelect.Image7;

                string answer = Q_Bank_1[1].answer;
                lblTurn.Text = $"{player2.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[1].prompt;
                Btn_Choice1.Text = Q_Bank_1[1].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[1].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[1].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[1].answerBank[3];

                if (flagBox3 == true)
                {
                    player2.Cash += 1000;
                    flagBox3 = false;
                }
            }
            else if (state == ImageSelect.Image7)
            {
                pictureBox1.Image = Properties.Resources.image_8;
                state = ImageSelect.Image8;

                string answer = Q_Bank_1[2].answer;
                lblTurn.Text = $"{player2.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[2].prompt;
                Btn_Choice1.Text = Q_Bank_1[2].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[2].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[2].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[2].answerBank[3];

                if (flagBox1 == true)
                {
                    player2.Cash += 1000;
                    flagBox1 = false;
                }
            }
            else if (state == ImageSelect.Image8)
            {
                pictureBox1.Image = Properties.Resources.image_9;
                state = ImageSelect.Image9;

                string answer = Q_Bank_1[3].answer;
                lblTurn.Text = $"{player2.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[3].prompt;
                Btn_Choice1.Text = Q_Bank_1[3].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[3].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[3].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[3].answerBank[3];

                if (flagBox2 == true)
                {
                    player2.Cash += 1000;
                    flagBox2 = false;
                }
            }
            else if (state == ImageSelect.Image9)
            {
                pictureBox1.Image = Properties.Resources.image_10;
                state = ImageSelect.Image10;

                string answer = Q_Bank_1[4].answer;
                lblTurn.Text = $"{player2.Name}'s Turn";
                lblQuestion.Text = Q_Bank_1[4].prompt;
                Btn_Choice1.Text = Q_Bank_1[4].answerBank[0];
                Btn_Choice2.Text = Q_Bank_1[4].answerBank[1];
                Btn_Choice3.Text = Q_Bank_1[4].answerBank[2];
                Btn_Choice4.Text = Q_Bank_1[4].answerBank[3];

                if (flagBox3 == true)
                {
                    player2.Cash += 1000;
                    flagBox3 = false;
                }
            }
            else
            {
                // Tally Game Function
                TallyGame(player1, player2);
                //Play again?
                Btn_Choice1.Text = "Play Again?";
                Btn_Choice2.Text = "Quit Game";
                btnNextQuestion.Text = "Submit";

                if (flagBox1 == true)
                {
                    // Play again selected, resetting ImageSelect state should recycle game
                    state = ImageSelect.None;
                    flagBox1 = false; 
                }
                else
                {
                    // Quit Game - close all forms
                }
            }

            void TallyGame(Player p1, Player p2)
            {
                if (p1.Cash == 5000)
                    p1.Cash = 10000;
                if (p2.Cash == 5000)
                    p2.Cash = 10000;

                // Open new commentbox that breaks down the scores and winner
                // 

            }
        }
    }
}
