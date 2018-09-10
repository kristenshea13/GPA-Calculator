using System;

namespace GPA_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Calculate your total GPA for up to 25 classes.\n ");

            //these variables will be used in loop, but will be used 
            //outside loop for calculations so they were declared outside loop
             
            decimal creditTotal = 0;
            decimal gradeWeighted = 0;
            decimal gradeweightedTotal = 0;

            for (int i = 0; i < 25; i++)
            {
                Console.Write("Enter your grade in class {0} (between 0.0 and 4.0): ", i + 1);
                //wanted number to keep track what entry user is on.

                decimal grade = decimal.Parse(Console.ReadLine());

                Console.Write("How many credits is this class worth? ");

                decimal credits = decimal.Parse(Console.ReadLine());

                //weight grade in relation to credits, if they got a 4.0 in a 3 credit class, it will be equal to 12
                //this is so GPA calculations will come out right.
                gradeWeighted = grade * credits;
                //create variable to add up gradeWeighted variable for all grades/credits entered by user.
                gradeweightedTotal = gradeweightedTotal + gradeWeighted;

                //adds all credits entered
               creditTotal = creditTotal + credits;

                Console.Write("Enter another grade [y / n]? ");

                //convert answer to ToLower, so if they use caps it will still recognize answer.
                string anotherGrade = Console.ReadLine().ToLower();

                //if they enter "n", loop will stop, if they enter "y", loop will continue.
                //if they enter anything else, they will get an error message and loop will stop.
                if (anotherGrade == "n")
                    break;
                else if (anotherGrade == "y")
                    continue;
                else
                {
                    Console.WriteLine("Invalid entry.");
                    break;
                }
                
            }

            //calculate GPA using the gradeweightedTotal variable divided by the total credits
            decimal gradepointAverage = gradeweightedTotal / creditTotal;
            Console.WriteLine();
            Console.WriteLine("Your GPA is: {0}", gradepointAverage);

            Console.ReadLine();
        }
    }
}
