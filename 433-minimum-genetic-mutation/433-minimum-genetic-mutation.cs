public class Solution {
    public int MinMutation(string start, string end, string[] bank) 
    {
        var available = new HashSet<string>(bank);
        var availableChars = new char[]{ 'A', 'C', 'G', 'T' };
        var queue = new Queue<string>();
        queue.Enqueue(start);
        var visited = new List<string>();
        var result = 0;
        
        while(queue.Count() > 0)
        {
            var size = queue.Count();
            while(size-- > 0)
            {
               var current = queue.Dequeue();
                
                if(current == end)
                    return result;
                
                var arr = current.ToCharArray();
                for(int i = 0; i < current.Length; i++)
                {
                    var temp = current[i];
                    foreach(var ch in availableChars)
                    {
                        arr[i] = ch;
                        var tempString = new string(arr);
                        if(bank.Contains(tempString) && !visited.Contains(tempString))
                        {
                            visited.Add(tempString);
                            queue.Enqueue(tempString);
                        }
                    }
                    
                    arr[i] = temp;
                }
            }
            
            result++;
        }
        
        return -1;
    }
}