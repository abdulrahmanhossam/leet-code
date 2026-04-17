namespace LeetCode.Easy;

public class Two_Sum
{
    // Input: nums = [2, 7, 11, 15], target = 9
    public int[] TwoSum(int[] nums, int target)
    {
        var numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int comp = target - nums[i]; // 2

            if (numMap.ContainsKey(comp))
            {
                return [numMap[comp], i]; // [0,1]
            }

            numMap[nums[i]] = i; // 0
        }

        return [];
    }
}