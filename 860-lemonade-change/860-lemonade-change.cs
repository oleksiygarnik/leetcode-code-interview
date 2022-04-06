public class Solution {
    public bool LemonadeChange(int[] bills) 
    {
        var dict = new Dictionary<int, int>();
        dict.Add(5, 0);
        dict.Add(10, 0);
        for(int i = 0; i < bills.Length; i++)
        {
            if(bills[i] == 5)
                dict[5]++;
            else if(bills[i] == 10)
            {
                dict[10]++;
                if(dict[5] == 0)
                    return false;
                else
                    dict[5]--;
            }
            else
            {
                var num = 20;
                while(num != 5)
                {
                    if(dict[10] != 0)
                    {
                        if(num - 10 != 0)
                        {
                            dict[10]--;
                            num -= 10; 
                            continue;
                        }
                    }
                    
                    if(dict[5] != 0)
                    {
                         num -= 5;
                        dict[5]--;
                    }
                    else
                        return false;
                }
            }
        }
        
        return true;
    
    }
}