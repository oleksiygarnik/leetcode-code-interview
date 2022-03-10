public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var visited = new bool[rooms.Count()];
        var stack = new Stack<int>();
        stack.Push(0);
        while(stack.Count > 0)
        {
            var currentRoom = stack.Pop();
            
            if(visited[currentRoom] == true)
                continue;
            
            visited[currentRoom] = true;
            foreach(var nextRoom in rooms[currentRoom])
            {
                if(visited[nextRoom] == false)
                    stack.Push(nextRoom);
            }
        }
        
        return visited.All(x => x == true);
    }
}