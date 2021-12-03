using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TestCase
    {

        private static int idCounter;

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public Priority Priority { get; set; }

        public string Summary { get; set; }

        public string Precondition { get; set; }

        public Status Status { get; set; }

        private List<Step> Steps { get; set; } = new List<Step>();

    public TestCase ()
        {
            Id = idCounter++;
            CreationDate = DateTime.Now;
        }

        public void Show()
        {

            


            Console.WriteLine("Show Test Case:");
            Console.WriteLine($"Id:{Id} " +
                $"\nCreation Date: {CreationDate} " +
                $"\nPriority:{Priority} " +
                $"\nSummary:{Summary} " +
                $"\nPrecondition:{Precondition} " +
                $"\nStatus:{Status}" +
                $"\nSteps:");
            for(int i  = 0; i<Steps.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine($"\tStep {j}\n" +
                    $"\tActiom:{Steps[i].Action}\n" +
                    $"\tResult:{Steps[i].Result}");
                
            }
        }



        public void Fill()
        {

            this.CreationDate = DateTime.Now;
            while (true)
            {

                Console.WriteLine("Enter priority( 1 - Low, 2 - Medium, 3 - High):");
                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    if (value == 1)
                    {
                        this.Priority = Priority.Low;
                        break;
                    }
                    else if (value == 2)
                    {
                        this.Priority = Priority.Medium;
                        break;
                    }
                    else if (value == 3)
                    {
                        this.Priority = Priority.High;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect priority");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect priority");
                }
            }

            while (true)
            {

                Console.WriteLine("Enter summary:");
                string tempSum = Console.ReadLine();
                if (tempSum != "")
                {
                    this.Summary = tempSum;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect summary");
                }
            }

            while (true)
            {

                Console.WriteLine("Enter precondition:");
                string tempPrec = Console.ReadLine();
                if (tempPrec != "")
                {
                    this.Precondition = tempPrec;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect precondition");
                }
            }


            while (true)
            {

                Console.WriteLine("Enter status( 1 - New, 2 - In Progress, 3 - Failed, 4 - Done):");
                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    if (value == 1)
                    {
                        this.Status = Status.New;
                        break;
                    }
                    else if (value == 2)
                    {
                        this.Status = Status.InProgress;
                        break;
                    }
                    else if (value == 3)
                    {
                        this.Status = Status.InProgress;
                        break;
                    }
                    else if (value == 4)
                    {
                        this.Status = Status.Done;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect status");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect status");
                }
            }

            Console.WriteLine("Create steps in case:");
            while (true)
            {
                Console.WriteLine("Add step?(1 - Yes, 2 - No):");
                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    if (value == 1)
                    {
                        Step step = new Step();
                        step.Fill();
                        Steps.Add(step);
                        Step.numberCounter--;
                    }
                    if (value == 2) { break; }
                }else{ 
                    Console.WriteLine("Incorrect step number"); 
                }
                

            }

         










        }




    }
}
