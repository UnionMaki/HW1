using System.Runtime.CompilerServices;
using System.Text;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            List<int> Arr = new List<int>();
            string inputLine = Console.ReadLine();
            string[] SepInputLine = inputLine.Split(" ");
            foreach (string numStr in SepInputLine)
            {
                bool isParsed = int.TryParse(numStr, out int num);
                if (isParsed)
                {
                    Arr.Add(num);
                }
            }
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for (int i = 0; i < Arr.Count - 1; i++)
                    if (Arr[i] > Arr[i + 1])
                    {
                        int c = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = c;
                        flag = false;
                    }
            }
            foreach (int num in Arr)
            {
                Console.Write(num);
            }
        }
    }
}