using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * [vs단축키]
- ctrl+k+c : 해당 위치 주석 처리
- ctrl+k+u : 해당 위치 주석 해제
 
 */
namespace ConsoleEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print기능, Line은 개행
            Console.WriteLine("Hello World!");
            // 키를 받기 전 까지 대기
            Console.ReadKey();
            // a.Length는 해당 a인자의 개수
            Console.WriteLine(args.Length);



        }
    }
}
