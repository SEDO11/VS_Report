using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP5
{
    public partial class 메뉴 : Form
    {
        public string username { get; set; }

        public 메뉴()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            영화선택 msfrm = new 영화선택();
            msfrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
        }

        private void btnUserSelct_Click(object sender, EventArgs e)
        {
            lblUser.Text = "환영합니다 " + username + " 님";
        }

        // get { return this.Form2_value; } // Form2에서 얻은(get) 값을 다른폼(Form1)으로 전달 목적
        // set { this.Form2_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기

    }
}
