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
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Trim() != "" && txtOP.Text.Trim() != "" && txtNum2.Text.Trim() == "") // 함수화 시켜서 다른 연산자에도 적용하는 방법 생각.
            {
                txtNum2.Text = txtNum1.Text;
                txtNum1.Text = "";
                txtOP.Text = "";
            }

            if (lblnumber.Text.Length <= 10)
            {
                Button btn = sender as Button;

                txtNum1.Text += btn.Text;

                lblnumber.Text = txtNum1.Text;
            }
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text.Length > 0)
            {
                txtNum1.Text = txtNum1.Text.Substring(0, txtNum1.Text.Length - 1);

                lblnumber.Text = txtNum1.Text;
            }
        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            txtOP.Text = btn.Text;

            lblnumber.Text = lblnumber.Text + txtOP.Text;

        }

        private void ChangeOP() // Plus , Minus 변환
        {

            // Convert와 Parse, TryPase의 차이에 대한 것. https://2-nan.tistory.com/43
            int Temp;

            Temp = Convert.ToInt32(txtNum1.Text);
                Temp *= -1;
                txtNum1.Text = Temp.ToString();

        }

        private void MoveTxt2()
        {
            
            if (txtNum1.Text.Trim() != "0")
            {
                
            }
        }

    }
}
