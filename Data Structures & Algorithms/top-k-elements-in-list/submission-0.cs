public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{

    //Input: nums = [1, 2, 2, 3, 3, 3], k = 2 (n of nums to reurn)
    //Output: [2, 3]
    Dictionary<int, int> dic = new();
    List<int>[] buckets = new List<int>[nums.Length + 1];
    for (int i = 0; i < nums.Length; i++)
    {
        if (!dic.ContainsKey(nums[i]))
        {
            dic.Add(nums[i],1);
        } else
        {
            dic[nums[i]]++;
        }
    }
        //now i want to return the highest number in the dictionary
        //make list (buckets) initialize the list from the hashmap
        foreach (var pair in dic){
        
        int number = pair.Key;
        int freq = pair.Value;

        if (buckets[freq] == null)
        {
            buckets[freq] = new List<int>(); //Initializing the freq into the lists int
        }
        buckets[freq].Add(number);
        }
    List<int> result = new();    
    for (int i = buckets.Length-1; i >= 0; i--)
    {
        if (buckets[i] != null)
        {
            foreach(int num in buckets[i])
            {
                result.Add(num);

                if (result.Count == k) return result.ToArray();
            }
        }
    }

    return [];
}
}
