public class Trie 
{
    public TrieNode Root = new TrieNode();
    
    public Trie() 
    {
    }
    
    public void Insert(string word) 
    {
        var current = Root;
        for(int i = 0; i < word.Length; i++)
        {
            var index = word[i] - 'a';
            if(current.Children[index] == null)
                current.Children[index] = new TrieNode();
            
            current = current.Children[index];
        }
        
        current.IsEnd = true;
    }
    
    public bool Search(string word) 
    {
        var current = Root;
        for(int i = 0; i < word.Length; i++)
        {
            var index = word[i] - 'a';
            if(current.Children[index] == null)
                return false;
            
            current = current.Children[index];
        }
        
        return current.IsEnd;
    }
    
    public bool StartsWith(string prefix) 
    {
        var current = Root;
        for(int i = 0; i < prefix.Length; i++)
        {
            var index = prefix[i] - 'a';
            if(current.Children[index] == null)
                return false;
            
            current = current.Children[index];
        }
        
        return true;
    }
    
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        
        public bool IsEnd;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */