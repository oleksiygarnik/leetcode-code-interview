public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) 
    {
        var score = 0;
        Array.Sort(tokens);
        var left = 0;
        var right = tokens.Length - 1;
        while(left <= right)
        {
            if(power - tokens[left] >= 0)
            {
                power -= tokens[left];
                score++;
                left++;
            }
            else
            {
                if(score >= 1 && right - left > 1)
                {
                    power += tokens[right];
                    right--;
                    score--;
                }
                else
                    break;
            }
        }
        
        return score;
    }
}