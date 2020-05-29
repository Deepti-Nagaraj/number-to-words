using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class number_to_word
    {
        static int input;
        static int temp;
        static int index = 0;
        static int[] buffer = new int[10];

        static void ones(int value)//to print numbers in ones
        {
            switch (value)
            {
                case 1: Console.Write(" one"); break;
                case 2: Console.Write(" Two"); break;
                case 3: Console.Write(" three"); break;
                case 4: Console.Write(" Four"); break;
                case 5: Console.Write(" Five"); break;
                case 6: Console.Write(" Six"); break;
                case 7: Console.Write(" Seven"); break;
                case 8: Console.Write(" Eight"); break;
                case 9: Console.Write(" Nine"); break;
                default: break;
            }
        }

        static void teens(int value)//to print numbers which are in teens
        {
            switch (value)
            {
                case 0: Console.Write("ten"); break;
                case 1: Console.Write(" eleven"); break;
                case 2: Console.Write(" Twelve"); break;
                case 3: Console.Write(" thirteen"); break;
                case 4: Console.Write(" Fourteen"); break;
                case 5: Console.Write(" Fifteen"); break;
                case 6: Console.Write(" Sixteen"); break;
                case 7: Console.Write(" Seventeen"); break;
                case 8: Console.Write(" Eighteen"); break;
                case 9: Console.Write(" Nineteen"); break;
            }
        }


        static void tens(int value)//to print tens values
        {
            switch (value)
            {
                case 2: Console.Write(" Twenty"); break;
                case 3: Console.Write(" thirty"); break;
                case 4: Console.Write(" Forty"); break;
                case 5: Console.Write(" Fifty"); break;
                case 6: Console.Write(" Sixty"); break;
                case 7: Console.Write(" Seventy"); break;
                case 8: Console.Write(" Eighty"); break;
                case 9: Console.Write(" Ninty"); break;
                default: break;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to convert it into words");
            input = Convert.ToInt32(Console.ReadLine());//input from the user
            do
            {
                buffer[index] = input % 10;
                input /= 10;
                index++;
            } while (input != 0);
            wordgeneration();
            Console.ReadLine();
        }

        private static void wordgeneration()
        {
            for (temp = index - 1; temp >= 0; temp--)
            {
                if (temp == 5)//check for the values in lakhs
                {
                    ones(buffer[temp]);
                    Console.Write("Lakhs");
                }
                else if (temp == 3)//check for the numbers in thousands
                {
                    if (buffer[temp + 1] == 1)
                    {
                        teens(buffer[temp]);
                        Console.Write("Thousand");
                    }
                    else
                    {
                        tens(buffer[temp + 1]);
                        ones(buffer[temp]);
                        if (!((buffer[temp + 1] == 0) && (buffer[temp] == 0)))
                        {
                            Console.Write("Thousand");
                        }
                    }
                }
                else if (temp == 2)//check for the numbers in hundreds
                {
                    if (buffer[temp] != 0)
                    {
                        ones(buffer[temp]);
                        Console.Write("Hundred");
                    }
                }
                else if (temp == 0)//chcek for the numbers in tens and ones
                {
                    if (buffer[temp + 1] == 1)
                        teens(buffer[temp]);
                    else
                    {
                        tens(buffer[temp + 1]);
                        ones(buffer[temp]);

                    }
                }

            }
        }
    }
}
