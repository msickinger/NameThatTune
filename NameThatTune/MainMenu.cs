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
    public partial class frmMainMenu : Form
    {
        //reference to parent form frm1
        frm1 parent;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        //constructor with parent form
        public frmMainMenu(frm1 parent)
        {
            InitializeComponent();
            //setting the parent form
            this.parent = parent;
            parent.Hide();
            parent.Visible = false;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
