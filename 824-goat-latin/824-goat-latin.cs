public class Solution {
    public string ToGoatLatin(string sentence)
    {
        var rules = new ITransformable[]{
            new VowelTransformationRule(),
            new ConsonantTransformationRule(),
            new IndexTransformationRule()
        };
        
        var words = sentence.Split(new char[]{ ' '});
        var sb = new StringBuilder();
        for(int i = 0; i < words.Length; i++)
        {
            var temp = words[i];
            foreach(var rule in rules)
                temp = rule.Execute(temp, i + 1);
            
            sb.Append(temp);
            
            if(i != words.Length - 1)
                sb.Append(" ");
        }
        
        return sb.ToString();
    }
    
    public interface ITransformable{
        string Execute(string word, int index);
    }
    
    public class VowelTransformationRule : ITransformable
    {
        private static readonly char[] Vowel = new[]
        {
            'a', 'e', 'i', 'o', 'u'
        };
        
        public string Execute(string word, int index)
        {
            if(Vowel.Contains(char.ToLowerInvariant(word[0])))
                return word + "ma";
            
            return word;
        }
    }
    
    public class IndexTransformationRule : ITransformable
    {
        public string Execute(string word, int index)
        {
            var sb = new StringBuilder();
            foreach(var ch in Enumerable.Range(0, index).Select(x => "a"))
                sb.Append(ch);
            
            return word + sb.ToString();
        }
    }
    
    public class ConsonantTransformationRule : ITransformable
    {
        private static readonly char[] Vowel = new[]
        {
            'a', 'e', 'i', 'o', 'u'
        };
        
        public string Execute(string word, int index)
        {
            var sb = new StringBuilder();
            if(!Vowel.Contains(char.ToLowerInvariant(word[0])))
            {
                sb.Append(word.Substring(1, word.Length - 1))
                    .Append(word[0].ToString())
                    .Append("ma");
                
                word = sb.ToString();
            }
            
            return word;
        }
    }
}