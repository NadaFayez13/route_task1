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
            Console.WriteLine("Enter character:");
            char character = char.Parse(Console.ReadLine());
            switch (character)
            {
                case 'a' or 'A':
                case 'e' or 'E':              
                case 'i' or 'I':
                case 'o' or 'O':
                case 'u' or 'U':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }
            #endregion
        }
    }
    }
    
