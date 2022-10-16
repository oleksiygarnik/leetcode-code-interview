public class Solution 
{
    public string Multiply(string num1, string num2) 
    {
        if(num1 == "0" || num2 == "0")
            return "0"; 
        var multipliers = new List<string>();
        
        for(int i = num2.Length - 1; i >= 0; i--)
            multipliers.Add(MupltiplyInner(num1, num2[i], num2.Length - 1 - i));
        
        return multipliers.Aggregate((x, y) => GetSum(x, y));
    }
    
    private string MupltiplyInner(string num1, char num2, int zeroCount)
    {
        var result = string.Empty;
        
        while(zeroCount != 0)
        {
            result += "0";
            zeroCount--;
        }
        
        var carry = 0;
        for(int i = num1.Length - 1; i >= 0; i--)
        {
            var current = (num1[i] - '0') * (num2 - '0') + carry;
            carry = current / 10;
            
            result += current % 10;
        }
        
        if(carry != 0)
            result += carry;
        
        var answer = "";
        foreach(var item in result.ToCharArray().Reverse())
            answer += item.ToString();
        
        return answer;
    }
    
    private string GetSum(string num1, string num2)
    {
        return num1.Length <= num2.Length 
            ? GetSumInner(num1, num2)
            : GetSumInner(num2, num1);
        
    }
    
    private string GetSumInner(string less, string greater)
    {
        var left = less.Length - 1;
        var right = greater.Length - 1;
        var carry = 0;
        var result = "";
        
        while(left >= 0 && right >= 0)
        {
            var num = (less[left] - '0') + (greater[right] - '0') + carry;
            carry = num / 10;
            
            result += num % 10;
            
            left--;
            right--;
        }
        
        while(right >= 0)
        {
            var num = (greater[right] - '0') + carry;
            carry = num / 10;
            result += num % 10;
            right--;
        }
        
        if(carry != 0)
            result += carry;
        
        var answer = "";
        foreach(var item in result.ToCharArray().Reverse())
            answer += item.ToString();
        
        return answer;
    }
}








































//  var nums = new List<string>();
//         var firstNum = long.Parse(num1);
        
//         for(int i = num2.Length - 1; i >= 0; i--)
//         {
//             var str = (firstNum * int.Parse(num2[i].ToString())).ToString() + GenerateZero(num2.Length - 1 - i);
//             nums.Add(str);
//         }
        
//         return GetSum(nums);
        
// //         var maxItem = nums.Max(x => x.Length);
        
// //         foreach(var test in nums)
// //             Console.WriteLine(test);
        
// //         var result = nums.Aggregate((x, y) => (long.Parse(x) + long.Parse(y)).ToString());
        
// //         return result;
//     }
    
//     private string GenerateZero(int count)
//     {
//         var res = "";
//         while(count != 0)
//         {
//             res += "0";
//             count--;
//         }
        
//         return res;
//     }
    
//     private string GetSum(List<string> nums)
//     {
//         var maxItem = nums.Max(x => x.Length);
//         var result = "";

//         var addition = 0;
//         for(int i = maxItem - 1; i >= 0; i--)
//         {
//             var acc = 0;
//             foreach(var num in nums)
//             {
//                 if(num.Length - 1 <= i)
//                     acc += int.Parse(num);
//             }
//             var sum = acc + addition;
//             addition = sum / 10;
//             result += (acc + addition) % 10; 
//         }
        
//         return result;
//     }