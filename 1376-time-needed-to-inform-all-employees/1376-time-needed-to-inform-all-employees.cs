public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) 
    {
        var company = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < manager.Length; i++)
            company.Add(i, new List<int>());
        
        for(int i = 0; i < manager.Length; i++)
        {
            if(i == headID)
                continue;
            
            company[manager[i]].Add(i);
        }
        
        return Dfs(company, informTime, headID);
    }
    
    private int Dfs(Dictionary<int, List<int>> company, int[] informTime, int employee)
    {
        int maxTime = int.MinValue;
        foreach(var collegue in company[employee])
            maxTime = Math.Max(maxTime, Dfs(company, informTime, collegue));
        
        return maxTime == int.MinValue ? informTime[employee] : maxTime + informTime[employee];
    }
}