using System;

namespace ArrayPractise
{
    class ArrayDemo
    {
        public void arrayMethod()
        {
            string name = "Ramana Gajula";
            Console.WriteLine(name.Length);
            Console.WriteLine(name[10]);
            string[] arrayList = new string[3];
            arrayList[0] = "zero index";
            
            arrayList[2] = "Third index";
            Console.WriteLine(arrayList);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine( "ENter the array size");
            int num = int.Parse(Console.ReadLine());
            String[] arrayList2 = new string[num];
            Console.WriteLine("Enter elements to an array");
                for(int i=0; i<num; i++)
            {
                Console.WriteLine("Enter {0} Element",i );
                arrayList2[i] = Console.ReadLine();
            }

            Console.WriteLine("The elements of an array are");
            for(int i=0;i<num; i++)
            {
                Console.WriteLine(arrayList2[i]);
            }

        }
    }

    class ArrayPractise
    {
        static void Main()
        {
            ArrayDemo obj = new ArrayDemo();
            obj.arrayMethod();
            string[] str1 = { "str1", "Str2", "str3", "str4" };
            int n = 459;
            Console.WriteLine("the given number is {0}", n);
            Console.WriteLine("the given number is {0,8}", n);
            Console.WriteLine("the given number is {0,8:c}", n);
            Console.WriteLine("the given number is {0,8:c4}", n);
            Console.WriteLine("the given number is {0,8:c0}", n);


        }
    }
}
