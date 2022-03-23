public class Solution {
    public int BrokenCalc(int startValue, int target) 
    {
            int ans = 0;
        while (target > startValue) {
            ans++;
            if (target % 2 == 1)
                target++;
            else
                target /= 2;
        }

        return ans + startValue - target;         
         

        
//         int ans = 0;
//         while (target != startValue) {
//             ans++;
//             if (target < startValue || target % 2 == 1)
//                 target++;
//             else
//                 target /= 2;
//         }

//         return ans;
    }
    
//     private int GetNum(int currentValue, int target, int distance)
//     {
//         if(currentValue == target)
//             return distance;
        
//         Console.WriteLine(currentValue);
        
//         if(currentValue > target)
//             return GetNum(currentValue - 1, target, ++distance);
        
//         return GetNum(currentValue * 2, target, ++distance);
//     }
    
    
    
    //         var unique = new HashSet<int>();
//         unique.Add(startValue);
        
//         var queue = new Queue<int>(startValue);
//         queue.Enqueue(startValue);
        
//         int distance = 0;
//         while(queue.Count() > 0)
//         {
//             var size = queue.Count();
//             while(size-- > 0)
//             {
//                 var current = queue.Dequeue();
                
//                 if(current == target)
//                     return distance;
                
//                 var num = current * 2;
//                 if(current < target && !unique.Contains(num))
//                     queue.Enqueue(num);
                
//                 num = current - 1;
//                 if(!unique.Contains(num))
//                     queue.Enqueue(num);
//             }
            
//             distance++;
//         }
        
//         return distance;
}