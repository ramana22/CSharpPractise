using System;
using System.Threading;

class ArithmeticOperators
{

    public void assignValues()
    {
        Console.WriteLine("Additions is :"+add(2,4));
        Console.WriteLine("Substraction is :"+ sub(5,3));
        Console.WriteLine("Multiplication is :"+mul(4,7));
        Console.WriteLine("Division is :"+div(6,4));
        Console.WriteLine("reaminder is :"+mod(17,7));
    }




    public int add(int a, int b)
    {
        return a + b;
    }
    public int sub(int a, int b)
    {
        return a - b;
    }
    public int mul(int a, int b)
    {
        return a * b;
    }
    public float div(float a, float b)
    {
        return (a / b);
    }
    public int mod(int a, int b)
    {
        return a % b;
    }
}


class ConditionalStatements
{
    //if-else statements
   bool a = true;
    bool b = false;
    if(!(a && b))

    public void if_else()
    {

        while (true)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            if (name == "Ramana" || name == "ramana" || name == "RAMANA")
            {
                Console.WriteLine("Your name is  {0}",name);
                break;
            }
            else
            {
                Console.WriteLine("Your name is not Ramana");
                Thread.Sleep(2000);
                Console.WriteLine("Enter the valid name");
            }




        }
    }




}

    class ArithmeticConditional
{
        static void Main()
        {
        ArithmeticOperators obj = new ArithmeticOperators();
        obj.assignValues();
        ConditionalStatements obj2 = new ConditionalStatements();
        obj2.if_else();


        }
    }
