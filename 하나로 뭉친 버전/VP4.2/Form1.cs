using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP4._2
{
    public partial class Form1 : Form
    {
        //나중에 예매 날짜, 시간을 넣어서 한 번 만들어 보기
        List<설명> frList = new List<설명>();
        OpenFileDialog ofd;
        string filename = " ";
        bool fst = true;
        List<string> moviename = new List<string> { "분노의 질주: 더 얼티메이트", "기생충", "귀멸의 칼날", "크루엘라", "노바디", "미나리" };
        List<string> movedirector = new List<string> { "저스틴 린", "봉준호", "소토자키 하루오", "크레이그 질레스피", "일리야 나이슐러", "정이삭"};
        List<string> moveactor = new List<string> { "빈 디젤", "송강호", "카마도 탄지로", "엠마 스톤", "밥 오덴커크", "스티븐 연"};
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            //라디오 버튼 초기화
            rdoMale.TabStop = false;
            rdoFmale.TabStop = false;
            gbCon.Enabled = false; //연령 선택 그룹박스 비활성화
            tbSeat.Enabled = false; //영화 입력창 비활성
            tbPeople.Enabled = false; //인원 입력창 비활성
            btnMemo.Enabled = false; //메모 입력버튼 비활성
            lbMemo.Enabled = false; // 메모 비활성
            btnCheck.Enabled = false; //포스터 확인 버튼 비활성
            btnSelct.Enabled = false; //포스터 선택 버튼 비활성
            pbPoster.Image = Properties.Resources.cgv; //프로그램 초기화면 설정
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbPoster_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pbPoster.Image = image;
                if (fst)
                    fst = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //픽쳐박스 클릭시 파일명 얻기
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                //MessageBox.Show(filename, "이미지 파일명");
                Int32.TryParse(filename, out i);
                if (filename != "cgv")
                {
                    lblMovieName.Text = moviename[i - 1];
                    lblDir.Text = movedirector[i - 1];
                    lblActor.Text = moveactor[i - 1];
                    MovieStory ms = new MovieStory();
                    string result = ms.Story(i);
                    lblExp.Text = result;
                    tbSeat.Enabled = true; //영화 입력창 비활성
                    tbPeople.Enabled = true; //인원 입력창 비활성
                    btnMemo.Enabled = true; //메모 입력버튼 비활성
                    lbMemo.Enabled = true; // 메모 비활성
                }

                else
                {
                    lblMovieName.Text = "초기화면";
                    lblDir.Text = " ";
                    lblActor.Text = " ";
                    lblExp.Text = "영화를 선택해 주세요.";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMemo_Click(object sender, EventArgs e)
        {
            설명 memo = new 설명();
            GetMemoData(memo);
            frList.Add(memo);
            lbMemo.Items.Add(moviename[i-1]);
            //텍스트박스 초기화
            tbSeat.Clear();
            tbPeople.Clear();
        }
        private void GetMemoData(설명 fr)
        {
            fr.Seat = tbSeat.Text;
            fr.people = int.Parse(tbPeople.Text);
        }

        private void lbMemo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbMemo.SelectedIndex;
            //인원 정보를 들고옴
            MessageBox.Show(frList[index].Seat.ToString(),("총 인원 "+ frList[index].people.ToString() + "명"));
        }

        private void gbCon_Enter(object sender, EventArgs e)
        {
            btnCheck.Enabled = true; //포스터 확인 버튼 비활성
            btnSelct.Enabled = true; //포스터 선택 버튼 비활성
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            gbCon.Enabled = true;
        }
    }
}
