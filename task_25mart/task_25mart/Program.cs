
using System;

namespace task_25mart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 ekrana cixanllar

            //Console.WriteLine(Divide1(14));
            //Console.WriteLine(Divide2(21));
            #endregion

            string groupNo;
            string fullname;
            byte age;
            

            do
            {
                Console.WriteLine("Enter group No: \n");
                groupNo = Console.ReadLine();
            } while (CheckGroupNo(groupNo));

            do
            {
                Console.WriteLine("Enter FullName: \n");
                fullname = Console.ReadLine();

            } while (CheckFullname(fullname));

            Student student = new Student(fullname, groupNo,age);

        }
        #region Task1 kodlar
        //public static bool Divide1(int num1)
        //{
        //    return num1 % 2 == 0;

        //}

        //public static bool Divide2(int num2)
        //{
        //    return num2 % 2 == 1;

        //}
        #endregion
        public static bool CheckGroupNo(string groupNo)
        {
            if(groupNo.Length>=4)
            {
                bool hasUpper = false;

                foreach (char item in groupNo)
                {
                    if(char.IsUpper(item))
                    {
                        hasUpper = true;
                        continue; 
                    }
                }
            }
            return true;
        }



    }
}
