/*
35. Search Insert Position
Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0

URL:https://leetcode.com/problems/search-insert-position/description/
Level: Easy
Language: C#

*/


public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int location = 0;

            int i = 0;
            int len = nums.Length;
            while (i < len && nums[i] < target)
            {
                if (target == nums[i])
                {
                    location = i;
                    break;
                }
                location = ++i;
            }

           

            return location;
        
    }
}
