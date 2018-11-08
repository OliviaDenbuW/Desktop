using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spelAllmänbildning
{
    class BlackHistory
    {
        public string namePlayer { get; set; }

        static int counterCorrectAnswers = 0;
        static int counterWrongAnswers = 0;
        
        public BlackHistory()
        {
            Console.Write("What is your name? ");
            this.namePlayer = Console.ReadLine();
        }

        public void EqualButSeperate()
        {
            Console.Write("'Equal, but seperate' is a frase connected to what law in the USA? ");
            string answer = Console.ReadLine();

            if ((answer == "jim crow law".ToLower()) || (answer == "jim crow".ToLower()))
            {
                counterCorrectAnswers++;
                Console.WriteLine("Correct");
            }
            else
            {
                counterWrongAnswers++;
                Console.WriteLine("Wrong! The correct answer is the Jim Crow law");
            }


        }
        public void JimCrowLaw()
        {
            Console.Write("Was the Jim Crow law benefitting for black people? (yes/no) ");
            string answer = Console.ReadLine();

            if (answer == "no".ToLower())
            {
                Console.WriteLine("Correct! ");
                counterCorrectAnswers++;
            }
            else
            {
                Console.WriteLine("Wrong! The Jim Crow laws were state and local laws " +
                    "that enforced racial segregation.");
                counterWrongAnswers++;
            }
        }

        public void DifferencesBetweenBlackAndWhitePeople()
        {
            Console.WriteLine("How many white people are being kept in prison in USA? ");
            Console.WriteLine("A) 1/17");
            Console.WriteLine("B) 1/8");
            Console.WriteLine("C) 1/14");
            Console.WriteLine();
            Console.WriteLine("Answer: ");
            string answerWhitePeople = Console.ReadLine();

            switch (answerWhitePeople)
            {
                case "A":
                    {
                        Console.WriteLine("Correct");
                        break;
                    }
                case "B":
                    {
                        Console.WriteLine("Wrong! 1/17 is the correct answer");
                        break;
                    }
                case "C":
                    {
                        Console.WriteLine("Wrong! 1/17 is the correct answer");
                        break;
                    }
            }

            Console.WriteLine("Now, lets compare this with the number of black people being put behind bars" +
                "in USA...");

            Console.WriteLine("How many black people are being kept in prison in USA? ");
            Console.WriteLine("A) 1/10");
            Console.WriteLine("B) 1/5");
            Console.WriteLine("C) 1/3");
            Console.WriteLine();
            Console.WriteLine("Answer: ");
            string answerBlackPeople = Console.ReadLine();

            switch (answerBlackPeople)
            {
                case "A":
                    {
                        Console.WriteLine("Wrong! 1/3 is the correct answer");
                        break;
                    }
                case "B":
                    {
                        Console.WriteLine("Wrong! 1/3 is the correct answer");
                        break;
                    }
                case "C":
                    {
                        Console.WriteLine("Correct! 1/3 is the correct answer");
                        break;
                    }
            }

            Console.WriteLine();
            Console.WriteLine("Conclusion: Every 17th white person is being kept in prison, " +
                "while every THIRD black person is(!!!!!!!!!!!!!!!!!!)");
        }
    }
}
