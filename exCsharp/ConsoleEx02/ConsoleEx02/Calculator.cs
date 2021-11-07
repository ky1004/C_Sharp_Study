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

        public bool HasValue()
        {
            return true;
        }

        private void TLabel_Click(object sender, EventArgs e)
        {
            // TLabel을 클릭했을 때 해당 메시지로 출력
            //TLabel.Text = "안녕 C#";

            // 변수선언
            //int num1 = 8;
            //string operat1 = "+";
            //bool isCorrect = false;

            //int num2 = 4;

            //int sum = num1 + num2;
            //TLabel.Text = sum.ToString();
        }

        private void SumNum_Click(object sender, EventArgs e)
        {

            int num1 = 0;
            int num2 = 0;

            // number1의 텍스트가 빈문자열이면 실행
            // String.IsNullOrWhiteSpace()을 사용하면 Null값이거나 Whitespace일 경우까지 예외조건을 걸어줄 수 있다
            if (String.IsNullOrWhiteSpace(number1.Text))
            {
                MessageBox.Show("첫번째 숫자를 넣어주세요.");
                number1.Focus();
                return;
            }


            // int형으로 바꿈, 리턴이 bool형
            // 하나는 string, 다른 하나는 out int
            // 숫자로 바꿀 매개변수를 두번째에 넣는다
            if(int.TryParse(number1.Text, out num1) == false)
            {
                MessageBox.Show("첫번째에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                // SelectAll : number1의 상태가 스크롤선택 상태
                // Focus : number1에 커서가 놓여있는 상태
                number1.SelectAll();
                number1.Focus();
                return;
            }


            // String.IsNullOrWhiteSpace(number2.Text)를 쓰지 않았기 때문에 공백 입력 시 에러가 나온다
            if (number2.Text == "")
            {
                MessageBox.Show("두번째 숫자를 넣어주세요.");
                return;
            }

            if (int.TryParse(number2.Text, out num2) == false)
            {
                MessageBox.Show("두번째에 문자가 들어왔습니다. 숫자를 입력해주세요.");
                return;
            }


            // convert.Toint32 --> number1텍스트박스를 형변환해서 넣어준다
            //num1 = Convert.ToInt32(number1.Text);
            //num2 = Convert.ToInt32(number2.Text);

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

        // 클래스에 속한 함수를 메서드라고 한다

        // 같은 이름의 function이 있을 수는 있지만 같은 매개변수를 가진 function은 있을 수 없다
        // 같은 이름의 함수는 있을 수 있으며, 매개변수가 다름 (오버로딩)
        //public void Flush(Number1);
        //public void Flush(Number2);
        //public void Flush(Number1,Number2);
        //public void Flush();




    }


}
