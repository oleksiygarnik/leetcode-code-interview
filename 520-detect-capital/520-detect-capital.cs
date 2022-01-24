public class Solution {
    public bool DetectCapitalUse(string word)
    {
        bool isRight = false;
        var firstLetterIsUpper = char.IsUpper(word[0]);
        var isLowerExist = false;
        var isUpperOnly = false;
        for(int i = 1; i < word.Length; i++)
        {
            var isUpper = char.IsUpper(word[i]);
            if(isUpper)
                isUpperOnly = true;
            
            if(!firstLetterIsUpper)
           {
               if(isUpper)
                   return false;
           }
            else{
                if(isLowerExist)
                {
                    if(isUpper)
                        return false;
                    
                    isLowerExist = true;
                    continue;
                }
                else{
                    if(!isUpper)
                    {
                        if(isUpperOnly)
                            return false;
                        
                        isLowerExist = true;
                    }
                }
                
                
            }
        }
        
        return true;
    }
}