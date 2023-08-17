using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Project
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form1>().Count() == 0)
                (new Form1()).Show();
        }

        private void btnStory_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Story>().Count() == 0)
                (new Form_Story()).Show();
        }

        private void btnWorld_Click(object sender, EventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form_Story>().Count() == 0)
                (new Form_SkillList()).Show();
        }
    }
}
