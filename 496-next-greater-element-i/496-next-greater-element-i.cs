public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums2.Length; i++)
            dict[nums2[i]] = i;
        
        var result = new int[nums1.Length];
        Array.Fill(result, -1);
        
        for(int i = 0; i < nums1.Length; i++)
        {
            var elem = nums1[i];
            for(int j = dict[nums1[i]]; j < nums2.Length; j++)
            {
                if(nums2[j] > elem)
                {
                    result[i] = nums2[j];
                    break;
                }
            }
        }
        
        return result;
    }
}