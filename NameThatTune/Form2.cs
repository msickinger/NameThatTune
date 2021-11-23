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
            Player player1 = new Player(txtPlayer1Name.Text, 0, null);
            P1ready = true;
            checkStartFirstGame();
            
        }

        private void btnPlayer2Ready_Click(object sender, EventArgs e)
        {
            btnPlayer2Ready.BackColor = Color.Green;
            Player player2 = new Player(txtPlayer2Name.Text, 0, null);
            P2ready = true;
            checkStartFirstGame();
        }
        //check if both players are ready to begin the first (randomized minigame)
        public void checkStartFirstGame()
        {
            if(P1ready ==true && P2ready ==true)
            {
                //need to randomize list of first round minigames 
                //load the picked minigame form
                

            }
        }
    }
}
