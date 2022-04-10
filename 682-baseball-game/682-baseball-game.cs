public class Solution {
    public int CalPoints(string[] ops) 
    {
        var stack = new Stack<int>();
        foreach(var word in ops)
        {
            if(word[0] == '+')
            {
                var item1 = stack.Pop();
                var item2 = stack.Pop();
                stack.Push(item2);
                stack.Push(item1);
                stack.Push(item1 + item2);
            }
            else if(word[0] == 'C')
            {
                stack.Pop();
            }
            else if(word[0] == 'D')
            {
                var item1 = stack.Pop();
                stack.Push(item1);
                stack.Push(item1 * 2);
            }
            else
            {
                stack.Push(int.Parse(word));
            }
        }
        
        var result = 0;
        foreach(var item in stack)
            result += item;
        
        return result;
    }
}