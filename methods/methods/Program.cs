


using System;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Worth());

            //FirstWord();

            //int[] array = { 1, 3, 4, 5, 6, 254 };
            //AddWord(ref array);
            //Console.WriteLine(WordCount());


        }
        public static bool Worth()

        {
            //task2
            string word = "Men AP-204 qrupunda tehsil almaga calisiram...";
            bool isdigit = false;
            bool islower = false;
            bool isupper = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    isdigit = true;
                    continue;
                }
                if (char.IsLower(word[i]))
                {
                    islower = true;
                    continue;
                }
                if (char.IsUpper(word[i]))
                {
                    isupper = true;
                }

            }
            bool result = isdigit && islower && isupper;
            return result;




        }

        public static void FirstWord()
        {
            string doubleword = "Bir terefden heyat sixir,bir terefden Sunal mellim";
            int num = doubleword.IndexOf(' ');
            num = doubleword.IndexOf(' ', num);
            string result = doubleword.Substring(0, num);
            Console.WriteLine(result);



        }


        public static int WordCount()
        {
            string sentence = "Dersler getdikce cox cetinlesir";
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i]==' '||i== sentence.Length-1)
                {
                    count++;    
                }
            }
            return count;
        }
        public static void AddWord(ref int[] array )
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length - 1] = 196;
                foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }


    }
}
