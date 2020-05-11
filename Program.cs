using System;

namespace Calculator_Program
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello Wellcome to the calculator");
            Console.WriteLine("press 1 for addition");
            Console.WriteLine("press 2 for subtraction");
            Console.WriteLine("press 3 for multiplication");
            Console.WriteLine("press 4 for division");
            Console.Write("Put the number for the action you want :");
            int num = Convert.ToInt32(Console.ReadLine());


            if (num == 1)
            {
                //We call the method  OperationAddition
                //This method do addition 2 numbers
                OperationAddition();
            }
            else if (num == 2)
            {

                OperationSubtraction();
            }
            else if (num == 3)
            {
                OperationMultiplicationn();
            }
            else if (num == 4)
            {
                OperationDivision();
            }
            else
            {
                Console.WriteLine("Press 1 of 4 button");
            }



            Console.ReadLine();
        }

        static void OperationAddition()
        {
           

            Console.Write("Enter the num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("The " + num1 + " addition with " + num2 + " and the answer is : " + sum);
        }

        static void OperationSubtraction()
        {
            
            Console.Write("Enter the num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 - num2;
            Console.WriteLine("The " + num1 + " subtaction with " + num2 + " and the answer is : " + sum);
        }
        static void OperationMultiplicationn()
        {
         

            Console.Write("Enter the num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 * num2;
            Console.WriteLine("The " + num1 + " munltiplication with " + num2 + " and the answer is : " + sum);
        }

        static void OperationDivision()
        {
            
            Console.Write("Enter the num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 / num2;
            Console.WriteLine("The " + num1 + " division with " + num2 + " and the answer is : " + sum);
        }

    }
}
