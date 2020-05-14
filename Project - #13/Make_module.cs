using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
namespace Test11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("Введите текст:");             
            string[] TArr;             
            string Me = Console.ReadLine();             
            TArr = text.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(TArr.Length);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
