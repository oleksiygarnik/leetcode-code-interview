public class MinStack 
{
    private Stack<int> _stack;
    private int _min;
    
    public MinStack() {
        _stack = new Stack<int>();
        _min = int.MaxValue;
    }
    
    public void Push(int val) 
    {
        if(val < _min)
            _min = val;
        
        _stack.Push(val);
    }
    
    public void Pop() 
    {
        if(_stack.Count() == 0)
            return;
        
        var item = _stack.Pop();
        if(item == _min)
        {
            _min = int.MaxValue;
            var newStack = new Stack<int>();
            while(_stack.Count != 0)
            {
                var newItem = _stack.Pop();
                if(newItem < _min)
                    _min = newItem;
                newStack.Push(newItem);
            }
            
            while(newStack.Count != 0)
                _stack.Push(newStack.Pop());
        }
    }
    
    public int Top() 
    {
        return _stack.Peek();
    }
    
    public int GetMin() 
    {
        return _min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */