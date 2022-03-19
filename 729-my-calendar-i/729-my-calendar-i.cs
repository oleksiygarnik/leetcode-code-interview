public class MyCalendar 
{
    private List<(int, int)> _calendar;
    
    public MyCalendar() 
    {
        _calendar = new List<(int, int)>();
    }
    
    public bool Book(int start, int end) 
    {
        foreach(var day in _calendar)
        {
            if(day.Item1 < end && day.Item2 > start)
                return false;
        }
        
        _calendar.Add((start, end));
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */