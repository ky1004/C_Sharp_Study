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
            // 만약 NumScreen의 텍스트가 0이라면 1로 변경
            if(NumScreen.Text == "0")
                NumScreen.Text = "1";
            else
                // 기존에 있는 숫자를 버리지 않고 실행
                NumScreen.Text += "1";
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            // 만약 NumScreen의 텍스트가 0이라면 2로 변경
            if (NumScreen.Text == "0")
                NumScreen.Text = "2";
            else
                // 기존에 있는 숫자를 버리지 않고 실행
                NumScreen.Text += "2";
        }

    }
}
