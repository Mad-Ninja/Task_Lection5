using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    public class Bug
    {
        private static int idCounter;


        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public Priority Priority { get; set; }

        public string Summary { get; set; }

        public string Precondition { get; set; }

        public Status Status { get; set; }

        public int TestCaseId  { get; set; }

        public int StepNumber { get; set; }

        public string ActualResult { get; set; }

        public string ExpectedResult { get; set; }



       

        public Bug()
        {
            Id = idCounter++;
            CreationDate = DateTime.Now;
        }


        public void Show()
        {
            Console.WriteLine("Show Bug:");
            Console.WriteLine($"Id:{Id} " +
                $"\nCreation Date: {CreationDate} " +
                $"\nPriority:{Priority} " +
                $"\nSummary:{Summary} " +
                $"\nPrecondition:{Precondition} " +
                $"\nStatus:{Status}" +
                $"\nTest Case Id:{TestCaseId}" +
                $"\nStep Number:{StepNumber}" +
                $"\nActual Result:{ActualResult}" +
                $"\nExpected Result:{ExpectedResult}");
        }

        public void Fill()
        {
            
            this.CreationDate = DateTime.Now;
            while (true)
            {
                
                Console.WriteLine("Enter priority( 1 - Low, 2 - Medium, 3 - High):");
                if(int.TryParse(Console.ReadLine(), out var value)){
                    if(value == 1 )
                    {
                        this.Priority = Priority.Low;
                        break;
                    }else if(value == 2)
                    {
                        this.Priority = Priority.Medium;
                        break;
                    }
                    else if(value == 3)
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


            while (true)
            {
                
                Console.WriteLine("Enter TestCase Id:");
                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    this.TestCaseId = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect TestCase Id");
                }
            }

            while (true)
            {
                
                Console.WriteLine("Enter Step number :");
                if (int.TryParse(Console.ReadLine(), out var value))
                {
                    this.StepNumber = value;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Step number");
                }
            }

            while (true)
            {
                
                Console.WriteLine("Enter Actual Result:");
                string tempAcRes = Console.ReadLine();
                if (tempAcRes != "")
                {
                    this.ActualResult = tempAcRes;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Actual Result");
                }
            }

            while (true)
            {
                
                Console.WriteLine("Enter Expected Result:");
                string tempExRes = Console.ReadLine();
                if (tempExRes != "")
                {
                    this.ActualResult = tempExRes;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Expected Result");
                }
            }

            

            
            





        }

}
}
