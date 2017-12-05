using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write 2 numbers");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());

            Console.Write("Select an option:\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Divide");

            int option = int.Parse(Console.ReadLine());


            EvaluateOption(option, number1, number2);

            Console.WriteLine(AddTwoNumbers(number1, number2));
        }
        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }
  
        public static void EvaluateOption(int option, float n1, float n2)
        {
            if (option == 1)
            {
                Console.WriteLine("Result of addition: " + AddTwoNumbers(n1,n2));
    }
}