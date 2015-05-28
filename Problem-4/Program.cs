/*
 *   Project Euler: Problem 4
 *   Alex Curran 
 *   
 *   A palindromic number reads the same both ways. The largest palindrome made from the
 *   product of two 2-digit numbers is 9009 = 91 × 99.
 *   Find the largest palindrome made from the product of two 3-digit numbers.
 *   
 *  https://projecteuler.net/problem=4
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 999; i >= 0; i--)
            {
                for (int j = 999; i >= 0; i--)
                {
                    sum = i * j;

                    if (isPalindrome(sum.ToString()))
                    {
                        Console.WriteLine(sum);
                        i = 0;
                        j = 0;
                    }
                }
            }

            
        }

        public static bool isPalindrome(string str)
        {
            if (str == reverseString(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string reverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
