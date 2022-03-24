public class Solution {
    public int NumRescueBoats(int[] people, int limit) 
    {
        if(people.Length == 1)
            return 1;
        
        Array.Sort(people);
        var left = 0;
        var right = people.Length - 1;
        var result = 0;
        
        while(left <= right)
        {
            if(people[left] + people[right] <= limit)
                left++;
            
            right--;
            result++;
        }
        
        return result;
    }
}