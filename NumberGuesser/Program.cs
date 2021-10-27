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
           // Set app vars
           string appName = "Number Guesser";
           string appVersion = "1.0.0";
           string appAuthor = "Brad Traversy";

           // Change text color
           Console.ForegroundColor = ConsoleColor.Green;

           // Write out app info
           Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

           // Reset text color
           Console.ResetColor();

           // Ask users name
           Console.WriteLine("What is your name??");

           // Get user input
           string inputName = Console.ReadLine();
           Console.WriteLine("Hello {0}, let's play a game...", inputName);
           
           // Set correct number
           int correctNumber = 7;

           // Init guess var
           int guess = 0;
           
           // Ask user for number
           Console.WriteLine("Guess a number between 1 and 10");

           // While guess is not correct
           while(guess != correctNumber){
               // Get users input
               string input = Console.ReadLine();

               // Make sure its a number
               if(!int.TryParse(input, out guess)){
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user Its not a number
                    Console.WriteLine("Enter an actual number");
    
                    // Reset text color
                    Console.ResetColor();
                    
                    // Keep going
                    continue;
               }

               // Cast to int and put in guess
               guess = Int32.Parse(input);

               // Match guess to correct number
               if(guess != correctNumber){
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Write out app info
                    Console.WriteLine("Wrong Number...Try Again");
    
                    // Reset text color
                    Console.ResetColor();
               }
               else{
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    // Write out app info
                    Console.WriteLine("Congratulation!!!");
    
                    // Reset text color
                    Console.ResetColor();
                    
               }
           }
        }
    }
}
