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
        //유저 아이디, 비밀번호
        string[] id = new string[] { "Oh", "Kim", "Hong" }; 
        string[] pw = new string[] { "1234", "5678", "1945" };
        int i = 1; // 로그인 시도 횟수 초기 변수 값
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //아이디, 비밀번호가 일치할 때 메뉴로 들어간다.
            if ((tbId.Text == id[0] && tbPw.Text == pw[0]) || (tbId.Text == id[1] && tbPw.Text == pw[1]) || (tbId.Text == id[2] && tbPw.Text == pw[2])) 
            {
                MessageBox.Show("확인되었습니다.", "확인", MessageBoxButtons.OK);
                메뉴 menufrm = new 메뉴();
                menufrm.username = tbId.Text;
                menufrm.ShowDialog();
            }

            //아이디, 비밀번호가 일치하지 않을 때
            else
            {
                if(i != 5) //로그인 시도 횟수가 5회 이하일때
                {
                    MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다. \n다시 입력해주세요.", "오류", MessageBoxButtons.OK);
                    i++;
                }
                else if(i == 5) //아이디 비밀번호를 다섯 번 이상 틀리면 강제 종료
                {
                    MessageBox.Show("아이디, 비밀번호를 5회 이상 틀렸습니다. \n시스템을 종료합니다.", "강제종료", MessageBoxButtons.OK);
                    Close(); 
                }
            }
        }

        private void tbPw_TextChanged(object sender, EventArgs e) //비밀번호를 입력하는  textbox를 클릭할 때
        {
            lblinfo.Text = "비밀번호를 입력하세요."; 
        }

        private void tbId_TextChanged(object sender, EventArgs e) //아이디를 입력하는  textbox를 클릭할 때
        {
            lblinfo.Text = "아이디를 입력하세요.";
        }
    }
}

