public class Solution {
    public int OpenLock(string[] deadends, string target) {
        var deads = new HashSet<string>(deadends);
        if (deadends.Contains("0000") || deadends.Contains(target)) return -1;
        
        var directions = new int[] { 1, -1 };
        int steps = 0;
        var q = new Queue<string>();
        q.Enqueue("0000");
        var visited = new HashSet<string>();
        visited.Add("0000");
        
        while (q.Count > 0) {
            var size = q.Count;
            
            for (int i=0; i<size; i++) {
                var node = q.Dequeue();
                if (node == target) return steps;
                var digitArr = node.ToCharArray();
                for (int k=0; k<4; k++) {
                    var tmp = digitArr[k];
                    int digit = digitArr[k] - '0';
                    foreach (var dir in directions) {
                        var newdigit = digit + dir;
                        if (newdigit == 10) newdigit = 0;
                        if (newdigit == -1) newdigit = 9;
                        digitArr[k] = (char)(newdigit + '0');
                        var news = new string(digitArr);
                        if (!deads.Contains(news) && !visited.Contains(news)) {
                            q.Enqueue(news);
                            visited.Add(news);
                        }
                    }
                    digitArr[k] = tmp;
                }
                
            }
            steps++;
        }
        return -1;
    }
}
// public class Solution {
//     public int OpenLock(string[] deadends, string target) 
//     {
//         var forbiden = new HashSet<string>(deadends);
        
//         if(forbiden.Contains(target) || forbiden.Contains("0000"))
//             return -1;
        
//         var queue = new Queue<string>();
//         queue.Enqueue("0000");
//         var result = 0;
//         var visited = new List<string>();
        
//         var directions = new int[]{ -1, 1 };
//         while(queue.Count() > 0)
//         {
//             var size = queue.Count();
//             while(size-- > 0)
//             {
//                 var current = queue.Dequeue();
                
//                 if(current == target)
//                     return result;
                
//                 var arr = current.ToCharArray();
//                 for(int i = 0; i < 4; i++)
//                 {
//                     var temp = arr[i];
                    
//                     var digit = arr[i] - '0';
//                     foreach(var dir in directions)
//                     {
//                         var newdigit = digit + dir;
//                         if (newdigit == 10) newdigit = 0;
//                         if (newdigit == -1) newdigit = 9;
//                         arr[i] = (char)(newdigit + '0');
                    
//                         var tempString = new string(arr);
//                         if( !forbiden.Contains(tempString) && !visited.Contains(tempString))
//                         {
//                             visited.Add(tempString);
//                             queue.Enqueue(tempString); 
//                         }
//                     }
                    
//                     arr[i] = temp;
//                 }
//             }
            
//             result++;
//         }
        
//         return -1;
//     }
    
//     private char Change(char ch, int num1)
//     {
//         var num = ch - '0' + num1;
//         if(num == 10)
//             num = 0;
//         if(num == -1)
//             num = 9;
        
//         return num.ToString()[0];
//     }
// }