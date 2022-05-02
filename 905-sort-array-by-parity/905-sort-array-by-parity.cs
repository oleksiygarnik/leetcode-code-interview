public class Solution {
    public int[] SortArrayByParity(int[] A) 
    {
        List<int> pairElem = new List<int>();
        List<int> oddElem = new List<int>();
        for(int i = 0; i < A.Count(); i++)
        {
            if(A[i]%2==0)
            {
                pairElem.Add(A[i]);
            }
            else
            {
                oddElem.Add(A[i]);
            }
        }
        pairElem.AddRange(oddElem);
        return pairElem.ToArray();
    }
}