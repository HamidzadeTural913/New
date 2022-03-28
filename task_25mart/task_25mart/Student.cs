using System;
using System.Collections.Generic;
using System.Text;

namespace task_25mart
{
    internal class Student
    {
        public string _fullname;
        public string _groupNo;
        public byte Age;

        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (CheckFullName(value))
                {
                    _fullname = value;
                }
            }
        }

        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length >= 0)
            {
                bool HasDigit = false;
                bool HasUpper = false;
                foreach (char no in groupNo)
                {
                    if (char.IsDigit(no))
                    {
                        HasDigit = true;
                        continue;
                    }
                    if (char.IsUpper(no))
                    {
                        HasUpper = true;    
                    }
                }
                bool result = HasDigit && HasUpper; 
                return result;
            }
            return false;
        }
        public static bool CheckFullName(string fullname)
        {
            return $"Fullname: {}";
        }

    }
}
