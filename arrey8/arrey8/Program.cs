using System;
using System.Collections;

namespace arrey8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "A", "B", "B", "B", "B", "A", "A", "A", "A", "A", "A", "B" };
            ArrayList new_str = new ArrayList();
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1] && i < str.Length - 2)
                { 
                    count++; new_str.Add(str[i]); new_str.Add(count); count = 0;
                }
                else if (i == str.Length - 2)
                {
                    if (str[i - 1] == str[i]) { count++; new_str.Add(str[i]); new_str.Add(count); }
                    else { new_str.Add(str[i - 1]); new_str.Add(count); new_str.Add(str[i]); new_str.Add(1); }
                }
                else { count++; }
            }
            foreach (object o in new_str) { Console.Write(o); }
        }
    }
}
