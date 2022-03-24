public class Solution {
    public int NumMatchingSubseq(string s, string[] words) 
    {    
        var trie = new Trie();
        trie.Insert(s);
        
        var storage = new Dictionary<string, int>();
        foreach(var word in words)
        {
            if(storage.ContainsKey(word))
                storage[word]++;
            else
                storage.Add(word, 1);
        }
        
        var result = 0;
        foreach(var word in storage.Keys)
        {
            if(trie.IsSequence(trie.Root, word, 0))
                result+=storage[word];
        }
        
        return result;
    }
    
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        
        public bool IsEnd;
    }
    
    public class Trie
    {
        public TrieNode Root = new TrieNode();
        
        private HashSet<string> Cache = new HashSet<string>();
        
        public void Insert(string word)
        {
            var current = Root;
            
            for(int i = 0; i < word.Length; i++)
            {
                if(!current.Children.ContainsKey(word[i]))
                    current.Children.Add(word[i], new TrieNode());
                //var index = word[i] - 'a';
                //if(current.Children[index] == null)
                //    current.Children[index] = new TrieNode();
                
                current = current.Children[word[i]];
            }
            
            current.IsEnd = true;
        }
        
        public bool IsSequence(TrieNode current, string word, int index)
        {
            if(Cache.Contains(word))
                return true;
            
            if(word.Length == index)
            {
                Cache.Add(word);
                return true;
            }
//             var current = Root;
//             var i = 0;
//             while(i != word.Length)
//             {
//                 if(current.Children.ContainsKey(word[i]))
//                 {
//                     if(i == word.Length - 1)
//                         return true;
//                 }
//                 else
//                 {
//                     if(current.IsEnd)
//                         return false;
//                     else
//                     {
//                         foreach(var neighbour in current.Children)
//                         {
//                             current = neighbour.Value;
//                             break;
//                         }
//                     }
//                 }
                
//                 i++;
//             }
            foreach(var neighbour in current.Children)
            {
                 if(neighbour.Key == word[index])
                        index++;
                
                return IsSequence(neighbour.Value, word, index);
            }
//             for(int i = 0; i < 26; i++)
//             {
//                 if(current.Children[i] != null)
//                 {
//                     var ch = (char)(i + 'a');
//                     if(ch == word[index])
//                         index++;
                    
//                     return IsSequence(current.Children[i], word, index);
//                 }
//             }
                        
            return false;
        }
    }
}