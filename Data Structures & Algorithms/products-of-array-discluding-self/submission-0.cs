public class Solution {
    
    public int[] ProductExceptSelf(int[] nums)
{
    int product = 1;
    int zeroCount = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0)
        {
            zeroCount++;
        }
        else
        {
            product *= nums[i];
        }
    }

    int[] answer = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        if (zeroCount > 1)
        {
            answer[i] = 0;
        }
        else if (zeroCount == 1)
        {
            if (nums[i] == 0)
            {
                answer[i] = product;
            }
            else
            {
                answer[i] = 0;
            }
        }
        else
        {
            answer[i] = product / nums[i];
        }
    }

    return answer;
}
}
