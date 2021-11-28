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

    public partial class frmPlayerSetup : Form
    {
        frmMainMenu parent;
        bool P1ready = false;
        bool P2ready = false;
        Player player1, player2;
       
        public frmPlayerSetup()
        {
            InitializeComponent();
        }

        public frmPlayerSetup(frmMainMenu parent)
        {
            InitializeComponent();
            //reference to main menu
            this.parent = parent;
            parent.Hide();
            
        }
        private void frmPlayerSetup_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayer1Ready_Click(object sender, EventArgs e)
        {
            btnPlayer1Ready.BackColor = Color.Green;
            player1 = new Player(txtPlayer1Name.Text, 0, null);
            P1ready = true;
            checkStartFirstGame();
            
        }

        private void btnPlayer2Ready_Click(object sender, EventArgs e)
        {
            btnPlayer2Ready.BackColor = Color.Green;
            player2 = new Player(txtPlayer2Name.Text, 0, null);
            P2ready = true;
            checkStartFirstGame();
        }
        //check if both players are ready to begin the game
        public void checkStartFirstGame()
        {
            if(P1ready ==true && P2ready ==true)
            {

                //load the picked minigame form; pass player data to next form
                TriviaRound obj = new TriviaRound(this, player1, player2);
                obj.Show();

            }
        }
    }
}
