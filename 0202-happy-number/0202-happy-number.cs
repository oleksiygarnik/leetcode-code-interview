public class Solution {
    public bool IsHappy(int n) 
    {
        var unique = new HashSet<double>();

        while(true)
        {
            var stringValue = n.ToString();
            double sum = 0;
            for(int i = 0; i < stringValue.Length; i++)
            {
                var num = double.Parse(stringValue[i].ToString());
                sum += Math.Pow(num, 2);
            }
                
                if(sum == 1)
                    return true;
                
                if(unique.Contains(sum))
                    return false;
                else
                {
                    unique.Add(sum);
                }
            
            n = (int)sum;
            }
    }
}