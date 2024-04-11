using System;

namespace MyCompiler {
    class Program {
        public static void Main(string[] args) 
        {
            string input = Console.ReadLine();
            int[] arr = AlphabetCount(input);

            PrintArr(arr);
        }

        static int[] AlphabetCount(string word)
        {
            int[] arr = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ') arr[word[i] - 'a'] ++; 
            }

            return arr;
        }

        static void PrintArr(int[] arr)
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i].ToString();
                if (i == arr.Length - 1) break;
                else result += " ";                
            }

            Console.WriteLine(result);
        }

    }
}