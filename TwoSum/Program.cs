using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] theArray = { 1, 3, 5, 7, 9 };
            //int[] arr = SumTwo(theArray, 12);

            //LinkedList<int> l1 = new LinkedList<int>();
            //l1.AddLast(2);
            //l1.AddLast(4);
            //l1.AddLast(3);

            //LinkedList<int> l2 = new LinkedList<int>();
            //l2.AddLast(5);
            //l2.AddLast(6);
            //l2.AddLast(4);
            //LinkedList<string> l3 = AddTwoNumbers(l1, l2);

            //Reverse Integer
            //Console.WriteLine("Reversing : " + Reverse(1534236469));

            //Palindrome
            //Console.WriteLine("Palindrome : " + Palindrome(-101));

            //Roman to Integer
            //Console.WriteLine("Roman to Integer : " + RomanToInt("III"));
            //Console.WriteLine("Roman to Integer : " + RomanToInt("IV"));
            //Console.WriteLine("Roman to Integer : " + RomanToInt("IX"));
            //Console.WriteLine("Roman to Integer : " + RomanToInt("LVIII"));
            //Console.WriteLine("Roman to Integer : " + RomanToInt("MCMXCIV"));

            //Longest Common Prefix
            //Console.WriteLine("Longest Common Prefix : " + LongestCommonPrefix(new string[] { "aa", "a" }));

            //Valid Parentheses
            Console.WriteLine("Valid Parentheses : " + IsValid("{[(]}"));
        }

        //Valid Parentheses
        public static bool IsValid(string s)
        {
            char[] chars = s.ToCharArray();
            string[] str = Array.ConvertAll(chars, char.ToString);
            int pushPop = 0;

            Stack<string> myStack = new Stack<string>();
            foreach (var item in str)
            {
                if (item == "{" || item == "[" || item == "(")
                {
                    myStack.Push(item);
                    pushPop++;
                }
                else
                {
                    if(myStack.Count == 0)
                    {
                        return false;
                    }
                    string open = myStack.Pop();
                    pushPop--;
                    if ((open == "[" && item == "]") || (open == "{" && item == "}") || (open == "(" && item == ")"))
                    {
                        continue;
                    }
                    else return false;
                }
            }
            if (pushPop == 0)
                return true;
            else
                return false;
        }

        //Longest Common Prefix
        public static string LongestCommonPrefix(string[] strs)
        {
            //if there is only one string
            //if(strs.Length == 1)
            //{
            //    return strs[0];
            //}

            //int strLength = 0;
            //if(strs.Length > 1)
            //{
            //    strLength = strs[0].Length;
            //    //Get the length of the smallest string
            //    foreach (var item in strs)
            //    {
            //        if (strLength > item.Length)
            //            strLength = item.Length;
            //    }

            //}

            //string returnString = string.Empty;

            //for(int i = 1; i <= strLength; i++)
            //{
            //    string compStr = strs[0].Substring(0, i);
            //    foreach (var item in strs)
            //    {
            //        if(compStr != item.Substring(0, i) && i == 1)
            //        {
            //            return "";
            //        }
            //        else if (compStr != item.Substring(0, i))
            //        {
            //            return returnString;
            //        }
            //    }
            //    returnString = compStr;
            //}
            //return returnString;


            //Better and faster way of doing it
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix)) return "";
                }
            return prefix;
        }

        public static int[] SumTwo(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                        return new int[] { nums[i], nums[j] };
                }
            }
            return null;
        }

        public static LinkedList<string> AddTwoNumbers(LinkedList<int> l1, LinkedList<int> l2)
        {
            int num = GetNumber(l1) + GetNumber(l2);
            return GetLinkedList(num);
        }

        private static int GetNumber(LinkedList<int> num)
        {
            string str = string.Empty;
            while(num.Count > 0)
            {
                str = str + num.Last.Value.ToString();
                num.RemoveLast();
            }

            return Convert.ToInt32(str);
        }

        private static LinkedList<string> GetLinkedList(int num)
        {
            string str = num.ToString();
            char[] charArr = str.ToCharArray();
            LinkedList<string> my_list = new LinkedList<string>();
            for(int i = charArr.Length - 1; i >= 0; i--)
            {
                my_list.AddLast(charArr[i].ToString());
            }
            return my_list;
        }

        //Reverse Integer
        public static int Reverse(int x)
        {
            bool isXNegative = x < 0;
            if(isXNegative)
            {
                x = x * -1;
            }
            int y = 10;
            int rev = 0;
            while(x % 10 >= 0 && x != 0)
            {
                int rem = x % 10;
                if(rev == 0)
                {
                    rev = rem;
                }
                else
                {
                    try
                    {
                        rev = checked((rev * y) + rem);
                    }
                    catch (OverflowException)
                    {
                        return 0;
                    }
                }
                x = x / 10;
            }
            if (isXNegative)
            {
                rev = rev * -1;
            }
            return rev;
        }

        public static bool Palindrome(int x)
        {
            if (x < 0)
                return false;
            return Math.Floor(Math.Log10(x) + 1) == Math.Floor(Math.Log10(Reverse(x)) + 1);
        }

        //Roman to Integer
        public static int RomanToInt(string s)
        {
            if (s.Length == 1)
            {
                return GetRomanValue(s);
            }

            int i = 0;

            return GetRomanStringArray(s);
        }

        private static int GetRomanStringArray(string s)
        {
            char[] chars = s.ToCharArray();
            string[] num = Array.ConvertAll(chars, char.ToString);
            int i = 0;
            string nextChar = num.Length > 1 ? num[++i] : num[0];
            int total = 0;

            bool skipNext = false;

            foreach (var item in num)
            {
                if(skipNext)
                {
                    nextChar = i == num.Length - 1 ? null : num[++i];
                    skipNext = false;
                    continue;
                }

                if(item == nextChar)
                {
                    total = total + GetRomanValue(item);
                    nextChar = i == num.Length - 1 ? null : num[++i];
                    continue;
                }
                else
                {
                    if(GetRomanValue(item + nextChar) > 0)
                    {
                        total = total + GetRomanValue(item + nextChar);
                        skipNext = true;
                    }
                    else
                    {
                        total = total + GetRomanValue(item);
                    }
                    nextChar = i == num.Length - 1 ? null : num[++i];
                }
            }
            return total;
        }

        private static int GetRomanValue(string s)
        {
            const int M = 1000;
            const int D = 500;
            const int C = 100;
            const int L = 50;
            const int X = 10;
            const int V = 5;
            const int I = 1;

            switch (s)
            {
                case "M": return 1000;
                case "D": return 500;
                case "C": return 100;
                case "L": return 50;
                case "X": return 10;
                case "V": return 5;
                case "I": return 1;
                case "IV": return 4;
                case "IX": return 9;
                case "XL": return 40;
                case "XC": return 90;
                case "CD": return 400;
                case "CM": return 900;
            }
            return 0;
        }
    }
}

