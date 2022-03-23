public class Solution 
{
    public IList<int> LexicalOrder(int n) 
    {
        var trie = new Trie();
        foreach(var digit in Enumerable.Range(1, n))
            trie.Insert(digit.ToString());
        
        //var result = new List<int>();
        trie.Dfs(trie.Root);
        
        return trie.Traversal;
    }
    
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[10];
        
        public bool IsEnd;
        
        public int Number;
    }
    
    public class Trie
    {
        public TrieNode Root = new TrieNode();
        public List<int> Traversal = new List<int>();
        
        public void Insert(string word)
        {
            var current = Root;
            
            for(int i = 0; i < word.Length; i++)
            {
                var index = word[i] - '0';
                if(current.Children[index] == null)
                    current.Children[index] = new TrieNode();
                
                current = current.Children[index];
            }
            
            current.IsEnd = true;
            current.Number = int.Parse(word);
        }
        
        public void Dfs(TrieNode current)
        {
            if(current.IsEnd)
                Traversal.Add(current.Number);
                
            for(int i = 0; i < 10; i++)
            {
                if(current.Children[i] != null)
                    Dfs(current.Children[i]);
            }
        }
    }
}