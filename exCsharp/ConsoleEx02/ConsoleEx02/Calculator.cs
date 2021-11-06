using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleEx02
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void TLabel_Click(object sender, EventArgs e)
        {
            // TLabel을 클릭했을 때 해당 메시지로 출력
            TLabel.Text = "안녕 C#";

            // 변수선언
            int num1 = 8;
            string operat1 = "+";
            bool isCorrect = false;

            int num2 = 4;

            int sum = num1 + num2;
            TLabel.Text = sum.ToString();
        }

        private void SumNum_Click(object sender, EventArgs e)
        {
            // convert.Toint32 --> number1텍스트박스를 형변환해서 넣어준다
            int num1 = Convert.ToInt32(number1.Text);
            int num2 = Convert.ToInt32(number2.Text);

            // int sum = num1 + num2;
            int sum = Add(num1, num2);
            // 대부분의 데이터 타입은 String으로 바뀔 일이 많다
            resultnum.Text = Convert.ToString(sum);
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

    }

    // 클래스에 속한 함수를 메서드라고 한다

}
