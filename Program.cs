using System;
using static System.Console;
using static System.Convert;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace Square_Of_Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Write an app that prompts the user to enter the size of the side of a square, 
              then displays a hollow square of that size made of asterisks. 
              Your app should work for squares of all side lengths between 1 and 20. 
              If the user enters a number less than 1 or greater than 20, 
              your app should display a square of size 1 or 20, respectively.
           */
            int  SideSize = 0;
            char Star = '*';
            char Space = ' ';
            int  counter = 1;

            WriteLine("Enter the Side size of the square");
            SideSize = ToInt32(ReadLine());

            // Important Condition .

            SideSize = SideSize < 1 ? SideSize = 1 : SideSize;

            SideSize = SideSize > 20 ? SideSize = 20 : SideSize;

            while (counter <= SideSize)
            {
                if (counter == 1 || counter == SideSize)
                {
                    int index_1 = 1;

                    while (index_1 <= SideSize)
                    {
                        Write(Star);
                        index_1++;
                    }
                }

                else
                {
                    int index_2 = 1;

                    while (index_2 <= SideSize)
                    {
                        if (index_2 == 1 || index_2 == SideSize)
                            Write(Star);

                        else
                            Write(Space);

                        index_2++;
                    }
                }
                WriteLine();
                counter++;
            }
            ReadLine();
        }
    }
}
