public class Solution {
    public bool CheckValid(int[][] matrix) {
        return Enumerable.Range(0, matrix.Length).All(x => IsValid(matrix[x])) &&
            Enumerable.Range(0, matrix.Length).All(x => IsValid(matrix.Select(z => z[x])));
    }
    
    private bool IsValid(IEnumerable<int> matrix)
    {
        return matrix.GroupBy(x => x).All(x => x.Count() == 1);
    }
}