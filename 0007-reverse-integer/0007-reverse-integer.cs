public class Solution 
{
    public int Reverse(int x) 
    {
        var strValue = x.ToString();
        var unsign = strValue;
        bool isSign = strValue[0] == '-';
        if(isSign)
            unsign = strValue.Substring(1, strValue.Length - 1);
        
        var reverseNum = unsign.Reverse().SkipWhile(x => x == '0');
        
        if(isSign)
            reverseNum = reverseNum.Prepend('-');
        
        var res = "";
        if(!reverseNum.Any())
            res += "0";
        
        foreach(var ch in reverseNum)
            res += ch.ToString();
        
        var longNum = long.Parse(res);
        return longNum > int.MaxValue || longNum < int.MinValue ? 0 : (int)longNum;
    }
}