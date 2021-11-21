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
    }
}
