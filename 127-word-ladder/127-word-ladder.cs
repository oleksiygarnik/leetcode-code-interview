public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) 
    {
        if(!wordList.Contains(endWord))
            return 0;
        
        var visited = new HashSet<string>();
        visited.Add(beginWord);
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        var distance = 1;
        
        while(queue.Count() > 0)
        {
            var size = queue.Count();
            while(size-- > 0)
            {
                var current = queue.Dequeue();
                
                if(current == endWord)
                    return distance;
                
                foreach(var word in wordList)
                {
                    if(visited.Contains(word))
                        continue;
                    
                    var diff = 0;
                    for(int i = 0; i < word.Length; i++)
                    {
                        if(word[i] != current[i])
                            diff++;
                    }
                    
                    if(diff == 1)
                    {
                        visited.Add(word);
                        queue.Enqueue(word);
                    }
                }
            }
            
            distance++;
        }
        
        return 0;
    }
}