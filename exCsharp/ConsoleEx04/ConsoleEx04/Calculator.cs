using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleEx04
{
    // enum 열거형 데이터 타입 정의
    //public enum Season { Spring, Summer, Fall, Winter }

    public enum Operators { Add, Sub, Mul, Div }

    public partial class Calculator : Form
    {
        public int Result = 0;
        // 새로운 숫자의 입력의 시작
        public bool isNewNum = true;

        public Operators Opt = Operators.Add;
        public Calculator()
        {
            InitializeComponent();

            // 변수에 값을 저장하는 형태는 같다
            //int number1 = 1;
            //string tset = "hello";
            //Season currentSeason = Season.Spring;
        }

      

        // 함수의 프로토타입, 선언, 정의
        //steamedrice Cook(rice, water) {  }
        public int Add(int number1, int number2)
        {
            // int라는 결과물을 내지 않으면 이 함수는 정의 자체가 실패가 된다
            int sum = number1 + number2;
            // 결과물을 만들어내는 키워드 return
            return sum;
        }

        public float Add2(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        // 모든 버튼은 하나의 핸들러를 공유(호출)한다
        // sender에서 받은 인자가 그대로 넘어온다
        // object형은 모든 자료형을 저장할 수 있다
        private void NumButton1_Click(object sender, EventArgs e)
        {
            // sender는 object타입이다
            // 명시적으로 button이라는 클래스타입으로 바꿔줄 수 있다
            Button numBtn = (Button)sender;
            SetNum(numBtn.Text);
        }

        // 리턴값 필요없음 void
        public void SetNum(string n)
        {
            // 변수 = 0

            // 숫자 입력
            // 더하기 버튼 - 숫자 완성, 변수와 숫자 합, 결과를 변수에 다시 저장
            // 반복

            // 첫 시작일 때
            if (isNewNum)
            {
                // 화면에 n을 쏘고 새로운 값이 아님을 표시(false)
                NumScreen.Text = n;
                isNewNum = false;
            }
            // 만약 화면이 0이라면
            else if (NumScreen.Text == "0")
            {
                // n으로 바꿔라
                NumScreen.Text = n;
            }
            // 화면이 첫시작도 아니고 0도 아니라면
            else
            {
                // 화면에 있는 값과 1을 더해서 쏴라
                NumScreen.Text += n;
            }

        }

        private void NumAdd_Click(object sender, EventArgs e)
        {

            if(isNewNum == false)
            {
                // string 데이터 타입을 int형으로 바꾼다
                int n = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Add(Result, n);
                else if(Opt == Operators.Sub)
                    Result = Sub(Result, n);

                // result의 숫자를 string형태로 바꾼다
                NumScreen.Text = Result.ToString();
                // 이제는 새로운 숫자를 입력받아라
                isNewNum = true;
            }
            Button optBtn = (Button)sender;
            if(optBtn.Text == "+")
                Opt = Operators.Add;
            else if (optBtn.Text == "-")
                Opt = Operators.Sub;

        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }


        // 변수 = 0
        // 연산자 = +

        // 숫자 입력
        // 연산자 버튼 클릭 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장
        // 숫자 입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장

    }

}
