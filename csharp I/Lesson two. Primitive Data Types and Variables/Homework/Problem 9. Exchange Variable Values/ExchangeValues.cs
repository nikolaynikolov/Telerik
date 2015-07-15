using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some
//programming logic.
//Print the variable values before and after the exchange.


class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        
        //Printing the variable values before the exchange:
        Console.WriteLine("Before exchange 'a' is {0}, 'b' is {1}.", a, b);

        //Here is some logic to change the values of the variables
        int c = b;
        b = a;
        a = c;

        //Printing the variable values after the exchange:
        Console.WriteLine("After exchange 'a' is {0}, 'b' is {1}.", a, b);
    }
}