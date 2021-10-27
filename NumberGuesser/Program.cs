using System; // 이 프로젝트에서 필요한건 시스템 뿐
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

// 솔루션 탐색기 단축키는 Ctrl+Alt+L이다
// 주석 처리 지정 Ctrl+k+c
// 주석 처리 해제 Ctrl+k+u

// 프로그램 실행 ctrl + f5

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            string name = "hina";
            int age = 17;

            /* start */
            //Console.Write();
            Console.WriteLine("name "+ name);
            Console.WriteLine("name "+ age);
            Console.WriteLine("{0} is {1}", name, age);

        }
    }
}
