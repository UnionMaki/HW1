namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            string? inputLine = Console.ReadLine();
            Crypt crypter = new Crypt();
            Console.WriteLine("Шифровка:");
            crypter.EnCrypt(ref inputLine);
            Console.WriteLine(inputLine);
            Console.WriteLine("Расшифровка:");
            crypter.DeCrypt(ref inputLine);
            Console.WriteLine(inputLine);
        }
    }
    public class Crypt
    {
        private string Al = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЫЭЮЯабвгдеёжзийклмнопрстуфхцчшщъьыэюя";
        private string res;
 
        public void EnCrypt(ref string inputline)
            {
                res = string.Empty;
                foreach (char ch in inputline)
                    {
                        int i = 0;
                        while (ch != Al[i])
                        {
                            i++;
                        }
                    if (i == 0)
                        res += "Ю";
                    else
                        if (i == 1)
                            res += "Я";
                        else
                            if (i == 33)
                                res += "ю";
                            else
                                if (i == 34)
                                    res += "я";
                                else
                                    res += Al[i - 2];
                    }
                inputline = res;

            }
        public void DeCrypt(ref string inputline)
            {
                res = string.Empty;
                foreach (char ch in inputline)
                    {
                        int i = 0;
                        while (ch != Al[i])
                        {
                            i++;
                        }
                        if (i == 31)
                            res += "А";
                        else
                            if (i == 32)
                                res += "Б";
                            else
                                if (i == 64)
                                    res += "а";
                                else
                                    if (i == 65)
                                        res += "б";
                                    else
                                        res += Al[i + 2];
                    }
                inputline = res;

        }
    }
}

           
