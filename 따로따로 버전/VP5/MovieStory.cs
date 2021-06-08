using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP5
{
    class MovieStory //영화 정보 데이터 저장 클래스
    {
        public string Actor(int i) //영화 배우 정보
        {
            List<string> movieactor = new List<string>();
            movieactor.Add(""); //널값
            movieactor.Add("빈 디젤");
            movieactor.Add("송강호");
            movieactor.Add("카마도 탄지로");
            movieactor.Add("엠마 스톤");
            movieactor.Add("밥 오덴커크");
            movieactor.Add("스티븐 연");
            string output = movieactor[i];
            return output;
        }

        public string MovieName(int i) //영화 제목 정보
        {
            List<string> moviename = new List<string>();
            moviename.Add(""); //널값
            moviename.Add("분노의 질주: 더 얼티메이트");
            moviename.Add("기생충");
            moviename.Add("귀멸의 칼날");
            moviename.Add("크루엘라");
            moviename.Add("노바디");
            moviename.Add("미나리");
            string output = moviename[i];
            return output;
        }

        public string Genre(int i) //영화 장르 정보
        {
            List<string> moviegenre = new List<string>();
            moviegenre.Add(""); //널값
            moviegenre.Add("액션, 블록버스터, 레이싱");
            moviegenre.Add("드라마, 범죄");
            moviegenre.Add("애니메이션, 액션, 판타지");
            moviegenre.Add("드라마, 판타지");
            moviegenre.Add("범죄, 액션");
            moviegenre.Add("드라마");
            string output = moviegenre[i];
            return output;
        }

        public string Director(int i) //영화 감독 정보
        {
            List<string> moviedirector = new List<string>();
            moviedirector.Add(""); //널값
            moviedirector.Add("저스틴 린");
            moviedirector.Add("봉준호");
            moviedirector.Add("소토자키 하루오");
            moviedirector.Add("크레이그 질레스피");
            moviedirector.Add("일리야 나이슐러");
            moviedirector.Add("정이삭");
            string output = moviedirector[i];
            return output;
        }

        public string Story(int i) //영화 내용 설명
        {
            List<string> moviestory = new List<string>();
            moviestory.Add(""); //널값
            moviestory.Add("도미닉(빈 디젤)은 자신과 가장 가까웠던 형제 제이콥(존 시나)이 사이퍼(샤를리즈 테론)와 연합해 전 세계를 위기로 빠트릴 위험천만한 계획을 세운다는 사실을 알게 되고, 이를 막기 위해 다시 한 번 패밀리들을 소환한다. 가장 가까운 자가 한순간, 가장 위험한 적이 된 상황 도미닉과 패밀리들은 이에 반격할 놀라운 컴백과 작전을 세우고 지상도, 상공도, 국경도 경계가 없는 불가능한 대결이 시작되는데…");
            moviestory.Add("전원백수로 살 길 막막하지만 사이는 좋은 기택(송강호) 가족. 장남 기우(최우식)에게 명문대생 친구가 연결시켜 준 고액 과외 자리는 모처럼 싹튼 고정수입의 희망이다. 온 가족의 도움과 기대 속에 박사장(이선균) 집으로 향하는 기우. 글로벌 IT기업 CEO인 박사장의 저택에 도착하자 젊고 아름다운 사모님 연교(조여정)가 기우를 맞이한다. 그러나 이렇게 시작된 두 가족의 만남 뒤로, 걷잡을 수 없는 사건이 기다리고 있었으니…");
            moviestory.Add("혈귀로 변해버린 여동생 ‘네즈코’를 인간으로 되돌릴 단서를 찾아 비밀조직 귀살대에 들어간 ‘탄지로.’ ‘젠이츠’, ‘이노스케’와 새로운 임무 수행을 위해 무한열차에 탑승 후 귀살대 최강 검사 염주 ‘렌고쿠’와 합류한다. 달리는 무한열차에서 승객들이 하나 둘 흔적 없이 사라지자 숨어있는 식인 혈귀의 존재를 직감하는 ‘렌고쿠’. 귀살대 ‘탄지로’ 일행과 최강 검사 염주 ‘렌고쿠’는 어둠 속을 달리는 무한열차에서 모두의 목숨을 구하기 위해 예측불가능한 능력을 가진 혈귀와 목숨을 건 혈전을 시작하는데…");
            moviestory.Add("처음부터 난 알았어. 내가 특별하단 걸 그게 불편한 인간들도 있겠지만 모두의 비위를 맞출 수는 없잖아? 그러다 보니 결국, 학교를 계속 다닐 수가 없었지 우여곡절 런던에 오게 된 나, 에스텔라는 재스퍼와 호레이스를 운명처럼 만났고 나의 뛰어난 패션 감각을 이용해 완벽한 변장과 빠른 손놀림으로 런던 거리를 싹쓸이 했어 도둑질이 지겹게 느껴질 때쯤, 꿈에 그리던 리버티 백화점에 낙하산(?)으로 들어가게 됐어 거리를 떠돌았지만 패션을 향한 나의 열정만큼은 언제나 진심이었거든 근데 이게 뭐야, 옷에는 손도 못 대보고 하루 종일 바닥 청소라니 인내심에 한계를 느끼고 있을 때, 런던 패션계를 꽉 쥐고 있는 남작 부인이 나타났어 천재는 천재를 알아보는 법! 난 남작 부인의 브랜드 디자이너로 들어가게 되었지 꿈을 이룰 것 같았던 순간도 잠시, 세상에 남작 부인이 ‘그런 사람’이었을 줄이야… 그래서 난 내가 누군지 보여주기로 했어 잘가, 에스텔라 난 이제 크루엘라야!");
            moviestory.Add("비범한 과거를 숨긴 채 남들과 다를 바 없는 평범한 일상을 사는 한 가정의 가장 ‘허치’ 매일 출근을 하고, 분리수거를 하고 일과 가정 모두 나름 최선을 다하지만 아들한테는 무시당하고 아내와의 관계도 소원하다. 그러던 어느 날, 집안에 강도가 들고 허치는 한 번의 반항도 하지 못하고 당한다. 더 큰 위험으로부터 가족을 지키기 위한 선택이었는데 모두 무능력하다고 ‘허치’를 비난하고, 결국 그동안 참고 억눌렀던 분노가 폭발하고 만다.");
            moviestory.Add("\"미나리는 어디서든 잘 자라\" 낯선 미국, 아칸소로 떠나온 한국 가족. 가족들에게 뭔가 해내는 걸 보여주고 싶은 아빠 '제이콥'(스티븐 연)은 자신만의 농장을 가꾸기 시작하고 엄마 '모니카'(한예리)도 다시 일자리를 찾는다. 아직 어린 아이들을 위해 ‘모니카’의 엄마 ‘순자’(윤여정)가 함께 살기로 하고 가방 가득 고춧가루, 멸치, 한약 그리고 미나리씨를 담은 할머니가 도착한다. 의젓한 큰딸 '앤'(노엘 케이트 조)과 장난꾸러기 막내아들 '데이빗'(앨런 김)은 여느 그랜마같지 않은 할머니가 영- 못마땅한데… 함께 있다면, 새로 시작할 수 있다는 희망으로 하루하루 뿌리 내리며 살아가는 어느 가족의 아주 특별한 여정이 시작된다!");
            string output = moviestory[i];
            return output;
        }
    }
}
