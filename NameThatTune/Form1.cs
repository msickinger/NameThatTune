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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();

            //create main menu on initialization
            frmMainMenu obj = new frmMainMenu(this);
            obj.Show();

            //delay calling hide so frm1 doesn't
            //reappear on startup
            timer1.Enabled = true;
        }

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //hide the dummy form: frm1 and disable the timer
            Hide();
            timer1.Enabled=false;
        }
    }
}
