public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        var dict = new Dictionary<int, int>();
        foreach(var num1 in nums1)
        {
            foreach(var num2 in nums2)
            {
                var current = num1 + num2;
                if(dict.ContainsKey(current))
                    dict[current]++;
                else
                    dict.Add(current, 1);
            }
        }
        
        var result = 0;
        foreach(var num3 in nums3)
        {
            foreach(var num4 in nums4)
            {
                var current = (num3 + num4) * -1;
                if(dict.ContainsKey(current))
                    result+=dict[current];
            }
        }
        
        return result;
    }
}