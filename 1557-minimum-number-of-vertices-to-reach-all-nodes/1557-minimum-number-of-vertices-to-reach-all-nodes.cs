public class Solution {
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges) {
        var result = new List<int>();
        var indegree = new int[n];
        for(int i = 0; i < edges.Count(); i++)
            indegree[edges[i][1]]++;
        
        for(int i = 0; i < indegree.Length; i++)
        {
            if(indegree[i] == 0)
                result.Add(i);
        }
        
        return result;
    }
}