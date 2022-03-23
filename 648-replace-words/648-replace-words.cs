public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) 
    {
        var trie = new Trie();
        foreach(var word in dictionary)
            trie.Insert(word);
        
        var sb = new StringBuilder();
        foreach(var word in sentence.Split(new char[]{ ' ' }))
            sb.Append(trie.GetSuccessor(word)).Append(" ");
        
        return sb.ToString().Substring(0, sb.Length - 1);
    }
    
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        
        public bool IsEnd;
    }
    
    public class Trie
    {
        public TrieNode Root = new TrieNode();
        
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
        
        public string GetSuccessor(string word)
        {
            var current = Root;
            var successor = string.Empty;
            for(int i = 0; i < word.Length; i++)
            {
                successor += word[i];
                
                var index = word[i] - 'a';
                if(current.Children[index] == null)
                    return word;
                
                if(current.Children[index].IsEnd)
                    return successor;
                
                current = current.Children[index];
            }
            
            return word;
        }
    }
}