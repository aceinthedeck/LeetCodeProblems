
"""
Given a roman numeral, convert it to an integer.
Input is guaranteed to be within the range from 1 to 3999.
URL: https://leetcode.com/problems/roman-to-integer/description/
"""
class Solution(object):
    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        romanToIntMap = {"I": 1, "V": 5, "X": 10, "L": 50, "C":100, "D": 500, "M": 1000}
        
        integer=0
        for i in range(0,len(s)):
          if(i+1>=len(s)):
            integer+=romanToIntMap[s[i]]
          else:
            if(romanToIntMap[s[i]]<romanToIntMap[s[i+1]]):
              integer-=romanToIntMap[s[i]]
            else:
              integer+=romanToIntMap[s[i]]
        return integer
