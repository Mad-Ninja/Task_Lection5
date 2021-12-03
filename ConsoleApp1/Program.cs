using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Bug> bugs = new List<Bug>();
            List<Step> steps = new List<Step>();
            List<TestCase> testCases = new List<TestCase>();
            

            while (true)
            {
                

                Console.WriteLine("Choose an action:\n" +
                              "1 - Add bug\n" +
                              "2 - Remove bug\n" +
                              "3 - Display a bug\n" +
                              "4 - Add step\n" +
                              "5 - Display a step\n" +
                              "6 - Add Test Case\n" +
                              "7 - Remove Test Case\n" +
                              "8 - Display Test Case");
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    
                    switch (result)
                    {
                        case 1:
                            Bug bug = new Bug();
                            bug.Fill();
                            bugs.Add(bug);
                            
                            break;
                        case 2:
                            Console.WriteLine("Select the ID of the bug to remove");
                           
                            if (int.TryParse(Console.ReadLine(), out var remIdBug))
                            {
                                if (remIdBug >= 0 && remIdBug < bugs.Count)
                                {
                                    bugs.RemoveAt(remIdBug);
                                    Console.WriteLine("Bug removed successfully");
                                    break;
                                }
                                   
                            }
                            Console.WriteLine("Incorrect bug ID, try again");
                            break;



                        case 3:
                            while (true)
                            {
                                if (bugs.Count == 0)
                                {
                                    Console.WriteLine("No bugs");
                                    break;
                                }
                                Console.WriteLine("Select a bug ID");
                                if(int.TryParse(Console.ReadLine(), out var value))
                                {
                                    if(value>=0 && value < bugs.Count)
                                    {
                                        bugs[value].Show();
                                        break;
                                    }
                                }
                                Console.WriteLine("Incorrect bug ID");
                            }
                           
                            break;
                        case 4:
                            Step step = new Step();
                            step.Fill();
                            steps.Add(step);

                            break;
                        case 5:
                            while (true)
                            {
                                if (steps.Count == 0)
                                {
                                    Console.WriteLine("No steps");
                                    break;
                                }
                                Console.WriteLine("Select a step number");
                                if (int.TryParse(Console.ReadLine(), out var value1))

                                {
                                    value1 = --value1 ;
                                    if (value1 >= 0 && value1 < steps.Count)
                                    {
                                        steps[value1].Show();
                                        break;
                                    }
                                }
                                Console.WriteLine("Incorrect step number");
                 
                            }
                            break;
                        case 6:
                            TestCase testCase = new TestCase();
                            testCase.Fill();
                            testCases.Add(testCase);
                            break;

                        case 7:
                            Console.WriteLine("Select the ID of the TestCase to remove");

                            if (int.TryParse(Console.ReadLine(), out var remIdTC))
                            {
                                if (remIdTC >= 0 && remIdTC < testCases.Count)
                                {
                                    testCases.RemoveAt(remIdTC);
                                    Console.WriteLine("Test Case removed successfully");
                                    break;
                                }

                            }
                            Console.WriteLine("Incorrect TestCase ID, try again");
                            break;

                        case 8:
                            while (true)
                            {
                                if (testCases.Count == 0)
                                {
                                    Console.WriteLine("No test cases");
                                    break;
                                }
                                Console.WriteLine("Select a test case ID");
                                if (int.TryParse(Console.ReadLine(), out var value2))

                                {
                                    
                                    if (value2 >= 0 && value2 < testCases.Count)
                                    {
                                        testCases[value2].Show();
                                        break;
                                    }
                                }
                                Console.WriteLine("Incorrect test case ID");

                            }
                            break;

                        default:
                            Console.WriteLine("Incorrect entry. Try again.");
                            break;

                    }
                }
            }

        }
    }
}
