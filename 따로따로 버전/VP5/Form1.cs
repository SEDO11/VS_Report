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
    public partial class Form1 : Form
    {
        //기본 아이디, 비밀번호
        string[] id = new string[] { "Oh", "Kim", "Hong" };
        string[] pw = new string[] { "1234", "5678", "1945" };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((tbId.Text == id[0] && tbPw.Text == pw[0]) || (tbId.Text == id[1] && tbPw.Text == pw[1]) || (tbId.Text == id[2] && tbPw.Text == pw[2])) //첫 번째 이용자
            {
                MessageBox.Show("확인되었습니다.", "확인", MessageBoxButtons.OK);
                메뉴 menufrm = new 메뉴();
                menufrm.username = tbId.Text;
                menufrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다. \n다시 입력해주세요.", "오류", MessageBoxButtons.OK);
            }
        }

        private void tbPw_TextChanged(object sender, EventArgs e)
        {
            lblinfo.Text = "비밀번호를 입력하세요.";
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            lblinfo.Text = "아이디를 입력하세요.";
        }


    }
}

