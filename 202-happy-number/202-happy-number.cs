public class Solution {
    public bool IsHappy(int n) {
        var currentNum = n;
        int length = 0;
        while(currentNum != 1)
        {
            if(length == 20)
                return false;
            
            currentNum = Calculate(currentNum);
            length++;
        }
        
        return true;
        
    }
    
    public int Calculate(int currentNum)
    {
        var numInString = currentNum.ToString();
        int sum = 0;
        for(int i = 0; i < numInString.Length; i++)
        {
            var current = int.Parse(numInString[i].ToString());
            sum+= current*current;
        }
        
        return sum;
    }
}