using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Step
    {
        public static int numberCounter = 1;
        public int Number { get; set; }

        public string Action { get; set; }

        public string Result { get; set; }

        
        public Step()
        {
            Number = numberCounter++;

        }


        public void Show()
        {
            Console.WriteLine("Show Step:");
            Console.WriteLine($"Number:{Number} " +
                $"\nAction {Action} " +
                $"\nResult:{Result} ");
        }

        public void Fill()
        {
            while (true)
            {

                Console.WriteLine("Enter Action:");
                string tempAction = Console.ReadLine();
                if (tempAction != "")
                {
                    this.Action = tempAction;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Action");
                }
            }
            while (true)
            {

                Console.WriteLine("Enter Result:");
                string tempResult = Console.ReadLine();
                if (tempResult != "")
                {
                    this.Result = tempResult;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Result");
                }
            }
        }
    }
}
