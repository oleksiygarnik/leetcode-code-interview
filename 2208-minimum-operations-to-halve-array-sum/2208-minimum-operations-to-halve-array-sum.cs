public class Solution {
    public class GreatnessComparer: IComparer<double>
{
    // highest to lowest
    public int Compare(double x, double y) => y.CompareTo(x);
}

    
    public int HalveArray(int[] nums) {
        var pq = new PriorityQueue<double, double>(new GreatnessComparer());
        int count = 0;
        double half = 0,sum = 0;
        
        foreach(int i in nums){
            pq.Enqueue((double)i, (double)i);
            sum += (double)i;
        }
        
        half = sum/2;
        while(sum > half && pq.Count > 0){
            double num = pq.Dequeue();
            double num2 = num/2;
            sum -= num2;
            pq.Enqueue(num2, num2);
            count++;
        }
        
        return count;
    }
}