public class MyQueue {
    private Stack<int> _stack1,_stack2;

    public MyQueue() {
        _stack1 = new Stack<int>();
        _stack2 = new Stack<int>();
    }
    
    public void Push(int x) {
        _stack1.Push(x);
    }
    
    public int Pop() {
        Move();
        return _stack2.Pop();
    }
    
    public int Peek() {
        Move();
        return _stack2.Peek();
    }
    
    public bool Empty() {
        return _stack1.Count == 0 && _stack2.Count == 0;
    }
    
    private void Move(){
        if(_stack2.Count == 0 ){
            while(_stack1.Count > 0){
                _stack2.Push(_stack1.Pop());
            }
        }
    }
}