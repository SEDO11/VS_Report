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
        List<Class> frList = new List<Class>(); //listbox에 순서대로 저장할 리스트 변수 설정
        MovieStory ms = new MovieStory(); //영화 정보 들어있는 클래스 가져오기
        OpenFileDialog ofd;
        string filename = " "; //이미지 파일 이름 값 받을 변수 설정
        bool fst = true; //버튼 행동 값 받을 논리 변수 설정
        int i = 0; //영화 순서
        int adultmoney = 10000; //어른 영화표 가격
        int teenmoney = 7000; //청소년 영화표 가격
        int dpmoney = 4000; //장애인 우대 영화표 가격
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

        private void btnCheck_Click(object sender, EventArgs e) //클릭시 해당 영화 정보를 가져온다.
        {
            if (!fst) //버튼으로 이미지를 선택 한 경우
            {
                filename = Path.GetFileNameWithoutExtension(ofd.FileName);
                Int32.TryParse(filename, out i); //파일 이름을 출력해서 해당하는 정보들 출력

                if (filename != "cgv") //이미지 파일 명이 cgv가 아닐 때 해당 영화들의 정보를 출력
                {
                    string story = ms.Story(i); //클래스에서 영화 줄거리 설명 가져오기
                    string actor = ms.Actor(i); //클래스에서 영화 배우 가져오기
                    string director = ms.Director(i); //클래스에서 영화 감독 가져오기
                    string genre = ms.Genre(i); //클래스에서 영화 장르 가져오기
                    string moviename = ms.MovieName(i); //클래스에서 영화 이름 가져오기
                    lblMovieName.Text = moviename; //클래스에서 가져온 영화이름 출력
                    lblGenre.Text = genre; // 영화 장르 출력
                    lblDir.Text = director; //영화 감독 출력
                    lblActor.Text = actor; //영화 배우 출력
                    lblExp.Text = story; //영화 줄거리 출력
                    tbAdult.Enabled = true; //인원 입력창 open
                    tbTeen.Enabled = true; //인원 입력창 open
                    tbDp.Enabled = true; //인원 입력창 open
                }

                else //초기상태
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
            if (ofd.ShowDialog() == DialogResult.OK) //영화 선택 버튼을 누르면 이미지를 선택한다.
            {
                Image image = Image.FromFile(ofd.FileName);
                pbPoster.Image = image;
                if (fst)
                    fst = false;
            }
        }

        private void btnMovieSelct_Click(object sender, EventArgs e)
        {
                Class memo = new Class(); //입력받을 프로퍼티 클래스 사용
                GetMemoData(memo); 
                frList.Add(memo);
                string moviename = lblMovieName.Text;
                lbmemo.Items.Add(moviename);//영화이름 저장
                //텍스트박스 초기화
                tbAdult.Clear(); 
                tbTeen.Clear();
                tbDp.Clear();
        }

        private void GetMemoData(Class fr) //textbox에 있던 값들을 저장
        {
                fr.adult = int.Parse(tbAdult.Text);
                fr.teen = int.Parse(tbTeen.Text);
                fr.dp = int.Parse(tbDp.Text);
        }

        private void lbmemo_SelectedIndexChanged_1(object sender, EventArgs e) //listbox를 누르면 예매내역 정보를 자세하게 출력
        {
            int index = lbmemo.SelectedIndex;
            MessageBox.Show("어른 " + frList[index].adult.ToString() + " 명\n" +
               "청소년 " + frList[index].teen.ToString() + " 명\n" +
               "장애인(우대) " + frList[index].dp.ToString() + " 명\n" +
               "총 가격 " + ((adultmoney * frList[index].adult) + (teenmoney * frList[index].teen) + (dpmoney * frList[index].dp)) + " 원", ("예매내역"));
        }

        private void 영화선택_Load(object sender, EventArgs e)
        {
        }
    }
}
