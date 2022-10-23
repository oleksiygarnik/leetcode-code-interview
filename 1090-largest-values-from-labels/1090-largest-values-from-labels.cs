public class Solution {
    public int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit) 
    {
        var items = new List<Item>();
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < values.Length; i++)
        {
            var item = new Item{
                Value = values[i],
                Label = labels[i]
            };
            
            if(!dict.ContainsKey(labels[i]))
                dict.Add(labels[i], useLimit);
            
            items.Add(item);
        }
        
        items = items.OrderBy(x => x.Value).ToList();
        var index = items.Count() - 1;
        var result = 0;
        while(numWanted > 0 && index >= 0)
        {
            if(dict[items[index].Label] > 0)
            {
                result += items[index].Value;
                dict[items[index].Label]--; 
                numWanted--;
            }
            
            index--;
        }
        
        return result;
    }
    
    public class Item
    {
        public int Value{get; set;}
        public int Label{get; set;}
    }
}