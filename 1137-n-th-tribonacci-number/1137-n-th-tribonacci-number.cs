public class Solution {
    public int Tribonacci(int n) {
        
        if(n == 0)
            return 0;
        if(n == 1)
            return 1;
        if(n == 2)
            return 1;
        
        int first = 0;
        int second = 1;
        int third = 1;
        int newItem = 0;
        for(int i = 3; i <= n; i++)
        {
            newItem = first + second + third;
            first = second;
            second = third;
            third = newItem;
        }
        
        return newItem;
    }
}