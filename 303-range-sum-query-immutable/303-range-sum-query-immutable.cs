public class NumArray {

    private readonly Dictionary<int, int> _storage;
    private int[] _nums;
    
    public NumArray(int[] nums) 
    {
        int sum = 0;
        _storage = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            sum+=nums[i];
            _storage.Add(i, sum);
        }
        
        _nums = nums;
    }
    
    public int SumRange(int left, int right)
    {
        return _storage[right] - (left == 0 ? 0 : _storage[left - 1]);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */