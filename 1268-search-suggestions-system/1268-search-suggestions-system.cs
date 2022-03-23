public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) 
    {
        var result = new List<IList<string>>();
        var trie = new Trie();
        
        foreach(var product in products)
            trie.Insert(product);
        
        var prefix = string.Empty;
        for(int i = 0; i < searchWord.Length; i++)
        {
            prefix += searchWord[i].ToString();
            result.Add(trie.GetWordsStartingWith(prefix));
        }
        
        return result;
    }
    
    public class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        
        public bool IsEndWord;
    }
    
    public class Trie
    {
        private TrieNode _root = new TrieNode();
        
        public void Insert(string word)
        {
            Console.WriteLine(word);
            var current = _root;
            
            for(int i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';
                if(current.Children[index] == null)
                    current.Children[index] = new TrieNode();
                
                current = current.Children[index];
            }
            
            current.IsEndWord = true;
        }
        
        public List<string> GetWordsStartingWith(string prefix)
        {
            var result = new List<string>();
            var current = _root;
            
            for(int i = 0; i < prefix.Length; i++)
            {
                var index = prefix[i] - 'a';
                if(current.Children[index] == null)
                    return result;
                
                current = current.Children[index];
            }
            
            Dfs(result, current, prefix);
            
            return result;
        }
        
        public void Dfs(List<string> words, TrieNode current, string word)
        {
            if(words.Count() == 3)
                return;
            
            if(current.IsEndWord)
                words.Add(word);
            
            for(int i = 0; i < 26; i++)
            {
                if(current.Children[i] != null)
                    Dfs(words, current.Children[i], word + (char)(i + 'a'));
            }
        }
    }
}