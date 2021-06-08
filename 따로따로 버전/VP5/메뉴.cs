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

        private void button1_Click(object sender, EventArgs e) //버튼을 누를시 영화선택 폼을 띄운다.
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

        private void btnUserSelct_Click(object sender, EventArgs e) //버튼을 누를시 로그인 했던 아이디를 환영한다는 문구 출력
        {
            lblUser.Text = "환영합니다 " + username + " 님";
        }
    }
}
