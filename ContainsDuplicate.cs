// Link: https://leetcode.com/problems/contains-duplicate/description/

namespace edge_of_nowhere
{
    public class ContainsDuplicate
    {
        public bool Solution(int[] nums)
        {
            HashSet<int> values = new HashSet<int>();
            int i = 0;

            while (i < nums.Length)
            {
                if (values.Contains(nums[i]))
                {
                    return true;
                }

                values.Add(nums[i]);
                i++;
            }

            return false;
        }
    }
}
