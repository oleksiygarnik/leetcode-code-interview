public class Solution {
    public bool IsPerfectSquare(int num) 
    {
        if(num == 1)
            return true;
        
        int left = 0, right = num;
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            if(middle * middle == num)
                return true;
            
            if(middle > num/middle)
                right = middle - 1;
            else
                left = middle + 1;
        }
        
        return false;
    }
}