public class MapSum 
{
    public Dictionary<string, int> Storage;
    public TrieNode Root;
    
    public MapSum() {
        Root = new TrieNode(0);
        Storage = new Dictionary<string, int>();
    }
    
    public void Insert(string key, int val) 
    {
        var current = Root;
        var isDuplicate = Storage.ContainsKey(key);
        
        for(int i = 0; i < key.Length; i++)
        {
            var index = key[i] - 'a';
            if(current.Children[index] == null)
                current.Children[index] = new TrieNode(val);
            else
            {
                if(isDuplicate)
                    current.Children[index].Sum -= Storage[key];
                
                current.Children[index].Sum += val;
            }
            
            current = current.Children[index];
        }
        
        if(isDuplicate)
            Storage[key] = val;
        else
            Storage.Add(key, val);
    }
    
    public int Sum(string prefix) 
    {
        var current = Root;
        
        for(int i = 0; i < prefix.Length; i++)
        {
            var index = prefix[i] - 'a';
            if(current.Children[index] == null)
                return 0;
            
            current = current.Children[index];
        }
        
        return current.Sum;
    }
    
    public class TrieNode
    {
        public TrieNode[] Children;
        
        public int Sum;
        
        public TrieNode(int sum)
        {
            Sum = sum;
            Children = new TrieNode[26];
        }
    }
}

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */