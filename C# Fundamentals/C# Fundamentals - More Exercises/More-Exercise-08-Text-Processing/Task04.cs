using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                string[] letters = words[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < letters.Length; j++)
                {
                    sb.Append(GetChar(letters[j]).ToString());
                }

                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }

        static char GetChar(string code)
        {
            char c = '-';

            switch (code)
            {
                case ".-":
                    c = 'A';
                    break;
                case "-...":
                    c = 'B';
                    break;
                case "-.-.":
                    c = 'C';
                    break;
                case "-..":
                    c = 'D';
                    break;
                case ".":
                    c = 'E';
                    break;
                case "..-.":
                    c = 'F';
                    break;
                case "--.":
                    c = 'G';
                    break;
                case "....":
                    c = 'H';
                    break;
                case "..":
                    c = 'I';
                    break;
                case ".---":
                    c = 'J';
                    break;
                case "-.-":
                    c = 'K';
                    break;
                case ".-..":
                    c = 'L';
                    break;
                case "--":
                    c = 'M';
                    break;
                case "-.":
                    c = 'N';
                    break;
                case "---":
                    c = 'O';
                    break;
                case ".--.":
                    c = 'P';
                    break;
                case "--.-":
                    c = 'Q';
                    break;
                case ".-.":
                    c = 'R';
                    break;
                case "...":
                    c = 'S';
                    break;
                case "-":
                    c = 'T';
                    break;
                case "..-":
                    c = 'U';
                    break;
                case "...-":
                    c = 'V';
                    break;
                case ".--":
                    c = 'W';
                    break;
                case "-..-":
                    c = 'X';
                    break;
                case "-.--":
                    c = 'Y';
                    break;
                case "--..":
                    c = 'Z';
                    break;
            }

            return c;
        }
    }
}
