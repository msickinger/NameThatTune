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

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (state == ImageSelect.None)
            {
                pictureBox1.Image = Properties.Resources.image_1;
                state = ImageSelect.Image1;
            }
            else if (state == ImageSelect.Image1)
            {
                pictureBox1.Image = Properties.Resources.image_2;
                state = ImageSelect.Image2;
            }
            else if (state == ImageSelect.Image2)
            {
                pictureBox1.Image = Properties.Resources.image_3;
                state = ImageSelect.Image3;
            }
            else if (state == ImageSelect.Image3)
            {
                pictureBox1.Image = Properties.Resources.image_4;
                state = ImageSelect.Image4;
            }
            else if (state == ImageSelect.Image4)
            {
                pictureBox1.Image = Properties.Resources.image_5;
                state = ImageSelect.Image5;
            }
            else if (state == ImageSelect.Image5)
            {
                pictureBox1.Image = Properties.Resources.image_6;
                state = ImageSelect.Image6;
            }
            else if (state == ImageSelect.Image6)
            {
                pictureBox1.Image = Properties.Resources.image_7;
                state = ImageSelect.Image7;
            }
            else if (state == ImageSelect.Image7)
            {
                pictureBox1.Image = Properties.Resources.image_8;
                state = ImageSelect.Image8;
            }
        }
    }
}
