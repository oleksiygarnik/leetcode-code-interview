public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) 
    {
        var trie = new Trie();
        foreach(var word in folder)
            trie.Insert(word);
        
        trie.Traversal(trie.Root, string.Empty);
        
        return trie.Result;
    }
    
    public class TrieNode
    {
        public Dictionary<string, TrieNode> Children = new Dictionary<string, TrieNode>();
        
        public bool IsEnd;
    }
    
    public class Trie
    {
        public TrieNode Root = new TrieNode();
        public List<string> Result = new List<string>();
        
        public void Insert(string foldersString)
        {
            var current = Root;
         
            var folders = foldersString.Split(new char[]{ '/' });
            foreach(var folder in folders)
            {
                if(folder == "")
                    continue;
                
                if(!current.Children.ContainsKey(folder))
                    current.Children.Add(folder, new TrieNode());
                
                if(current.Children[folder].IsEnd)
                    return;
                
                current = current.Children[folder];
            }
            
            current.IsEnd = true;
            current.Children = new Dictionary<string, TrieNode>();
        }
        
        public void Traversal(TrieNode current, string text)
        {
            if(current.IsEnd)
                Result.Add(text);
            
            foreach(var pair in current.Children)
            {
                text += $"/{pair.Key}";
            
                Traversal(pair.Value, text);
                text = text.Substring(0, text.Length - 1 - pair.Key.Length);
            }
        }
    }
}