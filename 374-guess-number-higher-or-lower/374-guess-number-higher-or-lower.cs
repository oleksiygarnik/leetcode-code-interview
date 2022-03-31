/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) 
    {
        int left = 1, right = n;
        
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            
            var result = guess(middle);
            if(result == 0)
                return middle;
            else if(result == 1)
                left = middle + 1;
            else 
                right = middle - 1;
        }
        
        return -1;
    }
}