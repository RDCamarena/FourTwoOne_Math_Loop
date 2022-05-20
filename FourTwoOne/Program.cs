using System;
using System.Numerics;

namespace FourTwoOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Greet the user and ask for a integer 
            Console.WriteLine("----------- Welcome, please enter a number. ----------- ");
            bool run = true;


            while (run)
            {
                // Records the input into the input var
                string input = Console.ReadLine();

                // Guard in case player wants to exit after the loop finish
                if (input == "exit")
                {
                    run = false;
                    break;
                }
                // Checks if input is empty 
                if (input != "")
                {
                    Loop(input);
                }
                // Writes to enter a number if input was empty 
                else
                {
                    Console.WriteLine("Please enter a number");
                }


            }


        }

        static public async void Loop(string i)
        {

            // Set variables to be able to run the math loop
            BigInteger numInput = BigInteger.Parse(i);
            BigInteger mutableNum = numInput;
            BigInteger steps = 0;
            BigInteger highNum = mutableNum;
            BigInteger prevNum = 0;

            bool stat = true;

            do
            {

                // Checks if number is 1 
                if (mutableNum != 1)
                {
                    // Records the highest number
                    if (highNum < prevNum)
                    {
                        highNum = prevNum;
                    };
                    // Checks for the number if its even or odd, then it calculates result
                    if (mutableNum % 2 == 0)
                    {
                        mutableNum = mutableNum / 2;
                        prevNum = mutableNum;
                        steps++;

                        Console.WriteLine(mutableNum);

                    }
                    else
                    {
                        mutableNum = mutableNum * 3 + 1;
                        prevNum = mutableNum;
                        steps++;

                        Console.WriteLine(mutableNum);


                    }

                }
                // Once 1 is found its assume the it will be in a constant loop so we end that loop scenario 
                else
                {
                    Console.WriteLine("Loop found, it took " + steps + " steps to get there");
                    Console.WriteLine("The highest number was " + highNum);
                    stat = false;
                    Console.WriteLine("Please enter another number or enter exit");

                }

                // Added to delay the write of the number, can change to make it faster or slower
                await Task.Delay(200);



            } while (stat);


        }

    }
}