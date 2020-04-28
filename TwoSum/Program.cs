using System;
using System.Collections.Generic;

namespace TwoSum
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode() { }
    }

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
            //Console.WriteLine("Reversing : " + BetterReverse(1534236469));

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
            //Console.WriteLine("Valid Parentheses : " + IsValid("{[(]}"));

            //Merge Two Sorted Lists
            //ListNode l1 = new ListNode(1);
            //ListNode l2 = new ListNode(2);
            //ListNode l3 = new ListNode(4);
            //l1.next = l2;
            //l2.next = l3;

            //ListNode l4 = new ListNode(1);
            //ListNode l5 = new ListNode(3);
            //ListNode l6 = new ListNode(4);
            //l4.next = l5;
            //l5.next = l6;

            //ListNode l = MergeTwoLists(l1, l4);

            //while (l.next != null)
            //{
            //    Console.WriteLine("Merge Two Sorted Lists : " + l.val);
            //    l = l.next;
            //}

            //Remove Duplicates from Sorted Array
            //Console.WriteLine("Remove Duplicates from Sorted Array : " + RemoveDuplicatesNewer(new int[] { 1, 1, 1, 2 }));
            //{ 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 })); //
            //Console.WriteLine("Remove Duplicates from Sorted Array : " + RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }));

            //Remove Element
            //Console.WriteLine("Remove Element : " + RemoveElement(new int[] { 2, 2, 2, 3, 4 }, 2));

            //Implement strStr()
            //Console.WriteLine("Implement strStr() : " + StrStr("aaa", "aaaa"));

            //Search Insert Position
            //Console.WriteLine("Search Insert Position : " + SearchInsert(new int[] {1, 3, 5, 6 }, 2));

            //Number of Steps to Reduce a Number to Zero
            //Console.WriteLine("Number of Steps to Reduce a Number to Zero : " + NumberOfSteps(14));

            //Decompress Run-Length Encoded List
            //Console.WriteLine("Decompress Run-Length Encoded List : " + DecompressRLElist(new int[] { 1, 3, 5, 6 }));

            //Jewels and Stones
            //Console.WriteLine("Jewels and Stones : " + NumJewelsInStones("sA","sAsss"));

            //Subtract the Product and Sum of Digits of an Integer
            //Console.WriteLine("Subtract the Product and Sum of Digits of an Integer : " + SubtractProductAndSum(4421));

            //Find Numbers with Even Number of Digits
            // Console.WriteLine("Find Numbers with Even Number of Digits :" + FindNumbers(new int[] { 12, 123, 1234, 12345 , 34}));

            //Squares of a Sorted Array
            //Console.WriteLine("Squares of a Sorted Array : " + SortedSquares(new int[] { -4, -1, 0, 3 }));

            //Sort Array By Parity
            //Console.WriteLine("Sort Array By Parity : " + SortArrayByParity(new int[] { 1, 0, 2, 3 }));

            //Robot Return to Origin
            Console.WriteLine("Robot Return to Origin : " + JudgeCircle("LUDRD"));
        }

        //Robot Return to Origin
        public static bool JudgeCircle(string moves)
        {
            char[] str = moves.ToCharArray();

            int rl = 0, ud = 0;

            foreach (var item in str)
            {
                switch (item)
                {
                    case 'L':
                        rl++;
                        break;
                    case 'R':
                        rl--;
                        break;
                    case 'U':
                        ud++;
                        break;
                    case 'D':
                        ud--;
                        break;
                }
            }
            return rl == 0 && ud == 0;
        }

        //Sort Array By Parity
        public static int[] SortArrayByParity(int[] num)
        {
            var list = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    if (list.Count > 0)
                    {
                        var x = list[0];
                        num[x.Key] = num[i];
                        num[i] = x.Value;
                        list.Remove(x);
                        list.Add(new KeyValuePair<int, int>(i, x.Value));
                    }
                }
                else
                {
                    list.Add(new KeyValuePair<int, int>(i, num[i]));
                }
            }

            return num;
        }

        //Squares of a Sorted Array
        public static int[] SortedSquares(int[] A)
        {
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];
            }

            Array.Sort(A);

            return A;

            //List<int> num = new List<int>();
            //foreach (var item in A)
            //{
            //    num.Add(item * item);
            //}

            //num.Sort();

            //return num.ToArray();
        }

        //Find Numbers with Even Number of Digits
        public static int FindNumbers(int[] nums)
        {
            int count = 0;

            foreach (var item in nums)
            {
                count = item.ToString().Length % 2 == 0 ? count + 1 : count;
            }

            return count;
        }

        //Subtract the Product and Sum of Digits of an Integer
        public static int SubtractProductAndSum(int n)
        {
            char[] chars = n.ToString().ToCharArray();
            string[] str = Array.ConvertAll(chars, char.ToString);

            int prod = 1;
            int sum = 0;

            foreach (var item in str)
            {
                int var = Convert.ToInt16(item);
                prod = prod * var;
                sum = sum + var;
            }

            return prod - sum;
        }

        //Jewels and Stones
        public static int NumJewelsInStones(string J, string S)
        {
            char[] chars = J.ToCharArray();
            string[] str = Array.ConvertAll(chars, char.ToString);

            int count = 0;

            foreach (var item in str)
            {
                string temp = S;
                int index = 0;
                while(index >= 0)
                {
                    index = temp.IndexOf(item);
                    if(index >= 0)
                    {
                        count++;
                        temp = temp.Length > 1 ? temp.Substring(index + 1) : string.Empty;
                    }
                }
            }

            return count;
        }

        //Decompress Run-Length Encoded List
        public static int[] DecompressRLElist(int[] nums)
        {
            List<int> x = new List<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int j = nums[i++];
                int k = nums[i];

                while(j > 0)
                {
                    x.Add(k);
                    j--;
                }
            }
            return x.ToArray();
        }

        //Number of Steps to Reduce a Number to Zero
        public static int NumberOfSteps(int num)
        {
            int x = 0;
            while(num > 0)
            {
                if (num % 2 == 0)
                    num = num / 2;
                else
                {
                    num = num - 1;
                }
                x++;
            }

            return x;
        }

        //Search Insert Position
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length < 1 || target <= nums[0])
                return 0;
            if (nums.Length == 1)
            {
                return 1;
            }

            if (target > nums[nums.Length - 1])
            {
                return nums.Length;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                {
                    return i;
                }

                if (target > nums[i] && target < nums[i + 1])
                {
                    return i + 1;
                }

            }
            return 0;
        }

        //Implement strStr()
        public static int StrStr(string haystack, string needle)
        {
            if (needle == null || needle == string.Empty) { return 0; }

            for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if(haystack[i] == needle[0])
                {
                    int x = i;
                    bool found = true;
                    for(int j = 1; j < needle.Length; j++)
                    {
                        if(x+1 < haystack.Length && needle[j] == needle[x+1])
                        {
                            x++;
                        }
                        else
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                        return i;
                }
            }
            return -1;
        }

        //Remove Element
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1 && nums[0] == val)
                return 1;

            int x = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //if (i < nums.Length - 1)
                //{
                    if (nums[i] != val)
                    {
                        nums[x] = nums[i];
                        x++;
                    }
                //}
            }
            return x;
        }

        //Remove Duplicates from Sorted Array
        public static int RemoveDuplicates(int[] nums)
        {
            int temp = 0, count =  0;
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            for (int k = 0; k < nums.Length; k++)
            {
                if(temp == nums[count])
                {
                    for(int i = count; i < nums.Length - count; i++)
                    {
                        nums[i] = i < nums.Length - 1 ? nums[i + 1] : nums[nums.Length - 1];
                    }
                    if(k < nums.Length - 1 && temp != nums[k+1])
                    {
                        count++;
                    }
                    temp = k < nums.Length- 1 ? nums[k + 1] : nums[nums.Length - 1];
                }
                else
                {
                    temp = nums[k];
                    count++;
                }
            }

            temp = nums[0];
            count = 1;
            for (int k = 1; k < nums.Length; k++)
            {
                if (temp != nums[k])
                {
                    temp = nums[k];
                    count++;
                }
                else
                    continue;
            }
            return count;
        }

        public static int RemoveDuplicatesNew(int[] nums)
        {
            int count = 1;
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            int temp = 0;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                temp = nums[i];
                if(temp == nums[i+1])
                {
                    int s = temp;
                    //find the first non matcing number
                    for(int x = i; x < nums.Length; x++)
                    {
                        if(temp != nums[x])
                        {
                            temp = nums[x];
                            count++;
                            break;
                        }
                    }

                    //then loop through and overwrite the next set of duplicates with that number.
                    for (int k = i + 1; k < nums.Length - 1; k++)
                    {
                        if (nums[k] < temp)
                        {
                            nums[k] = temp;
                        }
                    }
                }
                else
                {
                    count++;
                }
            }
            return count;
        }

        public static int RemoveDuplicatesNewer(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            int x = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1)
                {
                    if (nums[i] != nums[i + 1])
                    {
                        nums[x] = nums[i + 1];
                        x++;
                    }
                }
            }
            return x;
        }

        //Merge Two Sorted Lists
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode p = null;
            ListNode q = null;

            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            ListNode node = l1.val > l2.val ? l2 : l1;

            // insert l2 into l1
            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val && p == null)
                {
                    q = l2.next;
                    l2.next = l1;
                    l1 = l2;
                    l2 = q;
                }
                else if (l1.val > l2.val)
                {
                    q = l2.next;
                    p.next = l2;
                    l2.next = l1;
                    p = l2;
                    l2 = q;
                }
                else
                {
                    p = l1;
                    l1 = l1.next;
                }
            }

            if (l2 != null)
            {
                p.next = l2;
            }
            return node;



            return p;
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

        public static int BetterReverse(int n)
        {
            if (n == 0)
                return 0;

            int rev = 0;

            while (n != 0)
            {
                try
                {
                    rev = (rev * 10) + (n % 10);
                    n = n / 10;
                }
                catch (OverflowException)
                {
                    return 0;
                }
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

