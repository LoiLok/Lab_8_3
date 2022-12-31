using System;

namespace Lab_8_3
{
    class Program
    {
        static void Main()
        {
            string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };
            List<string> list = new List<string>(array);
            string[] res = NewArray(list); 

            foreach (string words in res)
                Console.WriteLine(words);
        }
        public static string[] NewArray(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    bool check = Check(list[i], list[j]);
                    if (check == true)
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }
            return list.ToArray();
        }

        public static bool Check(string first, string second)
        {
            List<char> firstSymbols = first.ToList();
            List<char> secondSymbols = second.ToList();
            int firstCount = firstSymbols.Count;
            int secondCount = secondSymbols.Count;
            int k = 0;

            if (firstCount != secondCount)
            {
                return false;
            }

            for (int i = 0; i < firstCount; i++)
            {
                char findSymbol = firstSymbols[i];
                if (secondSymbols.Contains(findSymbol))
                {
                    secondSymbols.Remove(findSymbol);
                    k++;
                }
            }

            if (firstCount == k && secondCount == k)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}