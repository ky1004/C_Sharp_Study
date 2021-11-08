using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleEx03
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        // 새로운 숫자의 입력의 시작
        public bool isNewNum = true;
        public Calculator()
        {
            InitializeComponent();
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

        private void NumButton1_Click(object sender, EventArgs e)
        {
            SetNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");

        }

        private void NumButton3_Click(object sender, EventArgs e)
        {
            SetNum("3");

        }

        private void NumButton4_Click(object sender, EventArgs e)
        {
            SetNum("4");

        }

        private void NumButton5_Click(object sender, EventArgs e)
        {
            SetNum("5");

        }

        private void NumButton6_Click(object sender, EventArgs e)
        {
            SetNum("6");

        }

        private void NumButton7_Click(object sender, EventArgs e)
        {
            SetNum("7");

        }
        private void NumButton8_Click(object sender, EventArgs e)
        {
            SetNum("8");

        }
        private void NumButton9_Click(object sender, EventArgs e)
        {
            SetNum("9");

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
            // string 데이터 타입을 int형으로 바꾼다
            int n = int.Parse(NumScreen.Text);
            Result = Result + n;

            // result의 숫자를 string형태로 바꾼다
            NumScreen.Text = Result.ToString();
            // 이제는 새로운 숫자를 입력받아라
            isNewNum = true;
        }

    }
}
