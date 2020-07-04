
using System;
using System.Threading;



class Demo
{
	public string FirstName = "Ramana";
	public int add(int a, int b)
	{
		return a + b;
	}

	public void whileLoop()
    {
        Console.WriteLine("Enter one number");
		int num;
        while (true)
        {
            Console.WriteLine("Enter number between 1 and 20");
			num = int.Parse(Console.ReadLine());
			if(num>=1 && num <= 20)
            {
				break;
            }
            Console.WriteLine("Enter num b/w 1 and 20");
			Thread.Sleep(2000);
			
        }
        Console.WriteLine("Your Entered number is\t:"+ num);
    }
}


class Demo2{
public void integerPRactise(){
		// int data type
		Console.WriteLine("Max value of integer"+int.MaxValue);
		Console.WriteLine("Min value of integer"+int.MinValue);


		// unsigned int data type....
		uint a=1;
		Console.WriteLine(a);
		Console.WriteLine("Unsigned min value  :"+uint.MaxValue);
		Console.WriteLine("Unsigned min value  :"+uint.MinValue);
	
		//
		Console.WriteLine(Math.Pow(2,32));
	

		//byte data type which holds only +ve integers
		Console.WriteLine("Byte data type max value : "+byte.MaxValue);
		Console.WriteLine("Byte data type min value : "+byte.MinValue);

		// sbyte data type which holds +ve and negative values
		Console.WriteLine("sbyte data type max value : "+sbyte.MaxValue);
		Console.WriteLine("sbyte data type min value : "+sbyte.MinValue);
													 
		//long data type which holds 64 bits 		 :
		Console.WriteLine("long data type min value  :"+long.MinValue);
		Console.WriteLine("sbyte data type max value : "+long.MaxValue);

		//unsigned long data type holds only postive integers
		Console.WriteLine("sbyte data type min value : "+ulong.MinValue);
		Console.WriteLine("sbyte data type max value : "+ulong.MaxValue);

	}

public void stringPRactise(){
	string str1=" this is ramana Gajula";
	string str2=" From JITS KNR";

	Console.WriteLine(str1+" "+str2+" "+"Persuing my Btech in CSE C",str1,str2);
	Console.WriteLine("{0} {1} Persuing my Btech in CSE C ",str1,str2);
}






}
class InitialProgram
{
		static void Main()
		{

		// ==========================================
		// Demo object intitialization
		//===========================================
		Demo obj = new Demo();
		
		Console.WriteLine("Hello Program");
        Console.WriteLine("My namme is G.Ramana");
        // Console.WriteLine("Enter your name");
        //string name = Console.ReadLine();
        Console.WriteLine("Enter a  number");
		//int num = int.Parse(Console.ReadLine());
		float num = float.Parse(Console.ReadLine());
		Console.WriteLine("Your name is\t:"+num);
        Console.WriteLine(obj.FirstName);
        Console.WriteLine("The addition is\t:" + obj.add(20, 30));
		//obj.whileLoop();
		

		//===============================================
		//Demo2 object initialization
		//===============================================
		Console.WriteLine("object 2=========== ");
		Demo2 obj2=new Demo2();
		obj2.integerPRactise();
		obj2.stringPRactise();

		}
	}

