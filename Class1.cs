using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Wheel of Fortune
{
    class Program
    {
        static void Main(string[] args)
    

        
        {
            Console.WriteLine("Welcome to Wheel of Fortune!!!!!!!!!!");
            string[] phrases = new string[3];
            phrases[0] = "sunshine";
            phrases[1] = "beachfront";
            phrases[2] = "coralreef";
             Random randGen = new Random();
            var index = randGen.Next(0, 2);
            string mysteryWord = phrases[index];
            char[] guess = new char[mysteryWord.Length];
            Random random = new Random();
            var list = new List<string> { " For $700", "For $600", " For $500", "For $400" ,"I'm sorry you are Bankrupt","For $800"," For $900","For $1000"};
            int inde = random.Next(list.Count);
          
            Console.WriteLine("Press enter to Spin");
            Console.ReadLine();
            Console.WriteLine(list[inde]);
            Console.Write("Please enter a letter guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*' ;
            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
               Console.WriteLine(guess);
                
             }
         

        }
    }
}