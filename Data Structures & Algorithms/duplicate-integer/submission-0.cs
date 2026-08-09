public class Solution {
     public bool hasDuplicate(int[] nums) { 
    
    HashSet<int> hash = new();

    for (int i= 0; i < nums.Length; i++) {

    if (!hash.Add(nums[i]))
    {
        Console.WriteLine("True");
        return true;
    }
    
    
    
}
        return false;
 
    
}
}