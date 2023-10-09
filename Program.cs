using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static string Compress(string arg)
        {
            arg = arg + " ";
            string FinalResult = string.Empty;
            try
            {
                string FirstLetter = arg.Substring(0, 1);
                int CharCount = 1;
                for(int i=1;i<arg.Length;i++)
                {
                    string SecondLetter = arg.Substring(i, 1);
                    if(FirstLetter == SecondLetter)
                    {
                        CharCount++;
                    }
                    else 
                    {                         
                        FinalResult = FinalResult + CharCount.ToString() 
                                      + FirstLetter;
                        FirstLetter = SecondLetter; 
                        CharCount = 1;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return FinalResult;
        }

        static int MaxProdOfThree()
        {
            int[] A = new int[] { -5, 5, -5, 4 };
            int result = 1;

            //Array.Sort(A);

            //foreach (int number in A)
            //{
            //    Console.WriteLine(number);
            //}

            //Array.Sort(A);
            //int ArrLength = A.Length;

            //for (int a = 1; a <= 3; a++)
            //{
            //    result *= (A[ArrLength - a]);
            //}

            result = A.Max();

            return result;
        }
        static void ThreeLetters()
        {
            int A = 1;
            int B = 4;

            string result = string.Empty;

            if (A > B)
            {
                for (int cntA = 1; cntA <= A; cntA++)
                {
                    if (cntA % 2 == 1)
                    {
                        for (int cntB = 1; cntB <= B; cntB++)
                        {
                            if (cntB % 2 == 0)
                            {
                                B = B - cntB;
                            }
                            else
                            {
                                result += "b";
                            }
                        }
                    }
                    result += "a";
                }
            }
            else if (A < B)
            {
                for (int cntB = 1; cntB <= B; cntB++)
                {
                    if (cntB % 2 == 1)
                    {
                        if (A == 0)
                        {
                            continue;
                        }
                        for (int cntA = 1; cntA <= A; cntA++)
                        {
                            if (cntA % 2 == 0)
                            {
                                A = A - cntA;
                            }
                            else
                            {
                                result += "a";
                            }
                        }
                    }
                    result += "b";
                }
            }
            else
            {
                for (int cntB = 1; cntB <= B; cntB++)
                {
                    if (cntB % 2 == 1)
                    {
                        for (int cntA = 1; cntA <= A; cntA++)
                        {
                            if (cntA % 2 == 0)
                            {
                                A = A - cntA;
                            }
                            else
                            {
                                result += "a";
                            }
                        }
                    }
                    result += "b";
                }
                result += "a";
            }

            Console.WriteLine(result);
        }

        static void CheckPermu()
        {
            int[] A = new int[] { 5, 2, 3, 1 };

            Array.Sort(A);

            bool isNotPermutation = false;

            for (int cnt = 0; cnt <= A.Length - 1; cnt++)
            {
                if (cnt == A.Length - 1)
                {
                    break;
                }
                if (A[cnt + 1] - A[cnt] != 1)
                {
                    isNotPermutation = true;
                    break;
                }
            }

            Console.WriteLine(!isNotPermutation);
        }

        static void succeedingHours()
        {
            int succeedingHours = 4;
            double EntranceFeeWithCost = 5;

            DateTime Start = Convert.ToDateTime("01/01/2023 10:00");
            DateTime End = Convert.ToDateTime("01/01/2023 13:21");

            double duration = (End.Minute - Start.Minute) / 60000;

            if (duration > 60)
            {
                duration -= 60;
                EntranceFeeWithCost += (Math.Floor(duration / 60) * succeedingHours);

                if (duration % 60 == 0)
                {
                    EntranceFeeWithCost += EntranceFeeWithCost;
                }
            }

            Console.WriteLine(EntranceFeeWithCost);
        }

        static bool isPerfectTriangle(int Number)
        {
            bool result = false;
            try
            {
                int counter = 0;
                int totalNumber = 0;
                while(Number > totalNumber)
                {
                    for (int cnt = 0; cnt <= counter; cnt++)
                    {
                        Console.Write("*");
                    }
                    counter++;
                    totalNumber += counter;
                    Console.WriteLine();
                }
                if(totalNumber == Number)
                {
                    result = true;
                }
                
            }catch(Exception ex)
            {

            }
            return result;
        }

        static void Main(string[] args)
        {
            /*            string InputString = "ABBC";
                        Console.WriteLine(Compress(InputString));
                        Console.ReadLine(); */

            //Console.WriteLine(MaxProdOfThree());

            Console.WriteLine(isPerfectTriangle(10));
            Console.ReadLine();
        }
    }
}
