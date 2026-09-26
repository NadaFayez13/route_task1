namespace Task__1____WS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region the task
            //Console.Write("Enter your name:");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age:");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter your grade 1:");
            //double grade1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter your grade 2:");
            //double grade2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter your grade 3:");
            //double grade3 = double.Parse(Console.ReadLine());
            //double total_grades = (grade1 + grade2 + grade3);
            //double avg_grades = total_grades / 3;


            //Console.WriteLine("student name:" + name);

            //if (age >= 18)
            //    Console.WriteLine("age: " + age + "(adult)");
            //else
            //    Console.WriteLine("age: " + age + "(minor)");

            //Console.WriteLine($"total grades:{total_grades:F2}");
            //Console.WriteLine($"avg grades: {avg_grades:F2}");

            //if (avg_grades >= 50)
            //    Console.WriteLine("Status : passed");
            //else
            //    Console.WriteLine("Status : failed");
            #endregion

            #region WS_1
            //Console.WriteLine("Enter character:");
            //char character = char.Parse(Console.ReadLine());
            //switch (character)
            //{
            //    case 'a' or 'A':
            //    case 'e' or 'E':              
            //    case 'i' or 'I':
            //    case 'o' or 'O':
            //    case 'u' or 'U':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion

            #region WS_2
            //Console.WriteLine("Enter a number:");
            //int n = int.Parse(Console.ReadLine());

            //int number_fact = 1;
            //for (int i = 1; i <= n; i++)
            //{number_fact =number_fact * i;}

            //Console.WriteLine(number_fact);
            #endregion

            #region WS_3
            //Console.WriteLine("Enter a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter b: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter c: ");
            //int c = int.Parse(Console.ReadLine());

            //if (a > b && a > c)
            //    Console.WriteLine(a);
            //else if (b > a && b > c)
            //    Console.WriteLine(b);
            //else
            //    Console.WriteLine(c);
            #endregion

            #region WS_4
            //Console.WriteLine("Enter a number:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter an operator:");
            //char op = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter another number:");
            //int b = int.Parse(Console.ReadLine());

            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine(a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine(a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        if (b != 0)
            //            Console.WriteLine(a / b);
            //        else
            //            Console.WriteLine("Error: Division by zero");
            //        break;
            //    case '%':
            //        if (b != 0)
            //            Console.WriteLine(a % b);
            //        else
            //            Console.WriteLine("Error: Division by zero");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //  }
            #endregion

            #region WS_5
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even");
                }
                else
                {
                    Console.WriteLine($"{number} is odd");
                }
            }
            #endregion

        }
    }
}
    
