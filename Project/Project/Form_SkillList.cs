using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form_SkillList : Form
    {
        public Form_SkillList()
        {
            // https://www.c-sharpcorner.com/UploadFile/9f4ff8/listview-in-C-Sharp/ 리스트뷰 여기 참고.
            InitializeComponent();
            lvISkillList.LargeImageList = ilImageList;
            lvISkillList.Items.Add("Item 1", 0);
        }
    }
}
