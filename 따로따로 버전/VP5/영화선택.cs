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

namespace VP5
{
    public partial class 영화선택 : Form
    {
        List<Class> frList = new List<Class>();
        OpenFileDialog ofd;
        string filename = " ";
        bool fst = true;
        List<string> moviename = new List<string> { " ", "분노의 질주: 더 얼티메이트", "기생충", "귀멸의 칼날", "크루엘라", "노바디", "미나리" };
        List<string> movedirector = new List<string> { " ", "저스틴 린", "봉준호", "소토자키 하루오", "크레이그 질레스피", "일리야 나이슐러", "정이삭" };
        List<string> moveactor = new List<string> { " ", "빈 디젤", "송강호", "카마도 탄지로", "엠마 스톤", "밥 오덴커크", "스티븐 연" };
        int i = 0;
        int adultmoney = 10000;
        int teenmoney = 7000;
        int dpmoney = 4000;
        public 영화선택()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            //라디오 버튼 초기화
            tbAdult.Enabled = false; //연령 선택 그룹박스 비활성화
            tbTeen.Enabled = false; //영화 입력창 비활성
            tbDp.Enabled = false; //인원 입력창 비활성
            pbPoster.Image = Properties.Resources.cgv; //프로그램 초기화면 설정
            lblMovieName.Text = "초기화면";
            lblExp.Text = "영화를 선택해 주세요.";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //클릭시 파일명 얻기
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                Int32.TryParse(filename, out i); //파일 이름을 출력해서 해당하는 정보들 출력
                if (filename != "cgv")
                {
                    lblMovieName.Text = moviename[i];
                    lblDir.Text = movedirector[i];
                    lblActor.Text = moveactor[i];
                    MovieStory ms = new MovieStory();
                    string result = ms.Story(i);
                    lblExp.Text = result;
                    tbAdult.Enabled = true;
                    tbTeen.Enabled = true;
                    tbDp.Enabled = true;

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

        private void btnSelct_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pbPoster.Image = image;
                if (fst)
                    fst = false;
            }
        }

        private void btnMovieSelct_Click(object sender, EventArgs e)
        {
            //string total_adult;
            /*
            영화예매내역 memo = new 영화예매내역();
            string info = lblMovieName.Text;
            int adult = int.Parse(tbAdult.Text);
            int teen = int.Parse(tbAdult.Text);
            int dp = int.Parse(tbAdult.Text);
            string totalman = info + "어른" + adult + "명" + "청소년" + teen + "명" + "장애인(우대)" + dp + "명";
            memo.movieinfo = totalman;
            int totalmoney = 10000 * adult + 7000 * teen + 4000 * dp;
            memo.moviemoney = totalmoney;
            */
            Class memo = new Class();
            GetMemoData(memo);
            frList.Add(memo);
            lbmemo.Items.Add(moviename[i]);//영화이름 저장
            //텍스트박스 초기화
            tbAdult.Clear();
            tbTeen.Clear();
            tbDp.Clear();

        }
        private void GetMemoData(Class fr)
        {
            fr.adult = int.Parse(tbAdult.Text);
            fr.teen = int.Parse(tbTeen.Text);
            fr.dp = int.Parse(tbDp.Text);
        }

        private void lbmemo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = lbmemo.SelectedIndex;
            //인원 정보를 들고옴
            MessageBox.Show("어른" + frList[index].adult.ToString() + "명\n" +
               "청소년" + frList[index].teen.ToString() + "명\n" +
               "장애인" + frList[index].dp.ToString() + "명\n" +
               "총 가격" + ((adultmoney * frList[index].adult) + (teenmoney * frList[index].teen) + (dpmoney * frList[index].dp)) + "원", ("예매내역"));
        }

        private void 영화선택_Load(object sender, EventArgs e)
        {

        }
    }
}
