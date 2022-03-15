public class Solution {
    public void MoveZeroes(int[] nums) {
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                for(int j = i; j < nums.Length; j++)
                {
                    if(nums[j] != 0)
                    {
                        var temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                        break;
                    }
                }
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
//         int zeroIndex = 0;
//         int digitIndex = 0;
//         for(int i = 0; i < nums.Length; i++)
//         {
//             if(nums[i] == 0)
//             {
//                 zeroIndex = i;
//                 int j = digitIndex;
//                 while(j != nums.Length)
//                 {
//                     if(nums[j] != 0)
//                     {
//                         digitIndex = j;
                        
//                         if(digitIndex > zeroIndex)
//                         {
//                         //Swap
//                             nums[zeroIndex] = nums[digitIndex];
//                             nums[digitIndex] = 0;
//                         }
//                         break;
//                     }
//                     j++;
//                 }
//             }
//         }
    }
}