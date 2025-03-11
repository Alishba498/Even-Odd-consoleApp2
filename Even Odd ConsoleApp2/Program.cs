using System;

class EvenOdd
{
    static void Main()
    {
        int i;

        Console.WriteLine("Enter a number: ");
        i = int.Parse(Console.ReadLine());
        if(i%2==0)
        {
            Console.WriteLine(i + " Is a Even Number");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine(i + " Ia a Odd Number");
            Console.ReadLine();
        }
            int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine(num + " is Even");
        else
            Console.WriteLine(num + " is Odd");
    }
}

