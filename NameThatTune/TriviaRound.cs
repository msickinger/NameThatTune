using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Question q1 = new Question();
        //Question q2 = new Question();
        //Question q3 = new Question();
        //Question q4 = new Question();
        //Question q5 = new Question();

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
            player2 = new Player(p2);

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

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            chkboxAnswers.Visible = true;
            if (state == ImageSelect.None)
            {
                pictureBox1.Image = Properties.Resources.image_1;
                state = ImageSelect.Image1;

                //additional changes when image changes
                lblTurn.Text = player1.Name+ "'s Turn";
                //lblQuestion.Text = "Question 1: " + q1.prompt;
                //change text of checklistbox to list of answers
                //function to check if correct and add to player score
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
