public class Solution {
    public int[] TwoSum(int[] nums, int target)
{
        Dictionary<int,int> hash = new();
    for (int i = 0; i < nums.Length; i++)
    {
        int difference = target - nums[i];
        if (hash.ContainsKey(difference))
        {

            int[] final = new int[2];
            final[0] = hash[difference];
            final[1] = i;
            
            Console.WriteLine("true");
            return final;
        }
        hash.Add(nums[i], i);
    }
    Console.WriteLine("FALSE");
    return [];
    
    //return nums;
}
}
