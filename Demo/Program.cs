using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statement
            //Console.WriteLine("1 T");
            //Console.WriteLine("2 T");
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}
            #endregion
            #region For - Foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Numbers[i] += 10;
            //if (Numbers[i] == 5)
            //{
            //    break;
            //}
            //if (Numbers[i] == 5)
            //{
            //    continue;
            //}
            //    Console.WriteLine(Numbers[i] + 10);
            //}

            // Class Implement interface IEnumerable

            //foreach (int Number in Numbers)
            //{
            //    //Number += 10;
            //    Console.WriteLine(Number + 10);
            //}
            #endregion
            #region While - Do While
            //int Number;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    flag = int.TryParse(Console.ReadLine(),out Number);
            //} while (Number % 2 == 1 || !flag);
            //Console.WriteLine($"{Number} is Even");

            //int Number = 3;
            //bool flag = false;
            //while (Number % 2 == 1 || !flag)
            //{
            //    Console.WriteLine("Enter Even Number");
            //    flag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //Console.WriteLine($"{Number} is Even");

            #endregion
            #region String
            // Class => Reference Type
            // immutable Data type [Value can not be changed]
            // Array of Chars


            //string Name;
            //Name = new string("Ahmed");

            //Name = "Ahmed"

            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");


            //string Name01 = "Ahmed";
            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            //Name02 = Name01;
            //Console.WriteLine("***************** Name02 = Name01 ***********");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            //Name01 = "Mostafa";
            //Console.WriteLine("***************** Name02 = Mostafa ***********");
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");
            //string Message = "Hello";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message += " Route";
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder
            //StringBuilder Message;
            //Message = new StringBuilder("Hello");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            ////Message += " ROute";
            //Message.Append(" Route");
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder Methods
            //StringBuilder Message = new StringBuilder("Welcome");

            //Message.Append(" to route");
            //Message.AppendLine(" Mohamed");

            //Message.Remove(0, 7);
            //Message.Insert(0, "Hello");


            //int Age = 10;
            //string name = "Ali";
            //Message.AppendFormat("Name : {0} ,  Age : {1}",name , Age);
            //Message.AppendJoin("/", "Mazen", "Mohamed", 2);
            //Console.WriteLine(Message);
            #endregion
        }
    }
}
