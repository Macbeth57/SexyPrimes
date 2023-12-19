/*

Sexy primes are pairs of two primes that are 6 apart. In this kata, your job is to complete the function which returns true if x & y are sexy, false otherwise.
Examples

5, 11   -->  true
61, 67  -->  true
7, 13   -->  true
5, 7    -->  false
1, 7    -->  false  (1 is not a prime)

Note: x & y are always positive integers, but they are not always in order of precendence... For example you can be given either (5, 11) or (11, 5) - both are valid.

*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static bool SexyPrime(int x, int y)
  { 
    for (int i = 2; i < x; i++)
    {
      
      if(x % i == 0)
      {
        return false;
      }
      
    }
    
    for (int j = 2; j < y; j++)
    {
      
      if(y % j == 0)
      {
        return false;
      }
      
    }
    
    if(x - y == 6 || y - x == 6)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
