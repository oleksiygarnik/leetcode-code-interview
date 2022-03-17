public class Solution {
    public bool IsBipartite(int[][] graph) {
        Queue<int> CurrLevel;
		
		// 0 => Not Traversed
		// 1 => Set A
		// 2 => Set B
        int[] Set = new int[graph.Length];
        int Parent;
        
        for(int i=0;i<graph.Length;i++){
            if(Set[i] == 0){
                Set[i] = 1;
                CurrLevel = new Queue<int>();
                CurrLevel.Enqueue(i);
                
                while(CurrLevel.Count>0){
                    Parent = CurrLevel.Dequeue();
                    foreach(int Child in graph[Parent]){
                        if(Set[Parent] == Set[Child]) return false;
                        
                        if(Set[Child] == 0){
                            CurrLevel.Enqueue(Child);
                            Set[Child] = (Set[Parent] == 1)?2:1;
                        }
                    }
                }
            }
        }
        return true;
    }
}