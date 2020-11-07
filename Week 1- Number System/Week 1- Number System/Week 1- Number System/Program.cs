using System;

namespace Week_1__Number_System
{
    class Program
    {
        // our class takes the decimal number as an input
        static void octalconvertor(int n)
        {
            int[] qarray = new int[50]; //1. initialize array to hold the octal representation(remainders)

            int i = 0; // initialize i to count the position where the remainder for the first division will be stored

            while (n != 0)   // 2. Begin the while statement, to continue until we reach a quotient of 0
            {


                qarray[i] = n % 8;   // for the first position in the array, we store the first quotient by division by 8
                n = n / 8;           // we update n as the quotient, after n was divided by 8
                i++;                // update the position in the array where the next remainder will be stored
            }

            // using this array, we print out the quotient array that was stored here.
            // we start at one before the last element, since it will be 0.
            //we print the array in reverse, until we reach the 1st element.
            for (int j = i - 1; j >= 0; j--)   // the octal representation will be the reverse of the sequence of remainders

                Console.Write(qarray[j]); //this prints the array.
        }

        public static void Main()
        {
            int n = 100;
            Console.Write("The octal representation of the base 10 number, " + n);
            Console.Write(" is: ");
            
            octalconvertor(n);
        }
    }
}
