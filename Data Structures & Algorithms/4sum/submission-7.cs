public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var list = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    long tg = (long)target - (long)nums[i] - (long)nums[j] - (long)nums[k];
                    int l = k + 1, r = nums.Length - 1, mid = (l + r) / 2;
                    while (l <= r)
                    {
                        if ((long)nums[mid] < tg) l = mid + 1;
                        else if ((long)nums[mid] > tg) r = mid - 1;
                        else 
                        {
                            var li = new List<int>();
                            li.Add(nums[i]);
                            li.Add(nums[j]);
                            li.Add(nums[k]);
                            li.Add(nums[mid]);

                            Validate(list, li);
                            break;
                        }

                        mid = (l + r) / 2;
                    }
                }
            }
        }  

        return list;
    }

    private void Validate(List<List<int>> list, List<int> li)
    {
        foreach (var item in list)
        {
            if (item[0] == li[0] && item[1] == li[1] &&
            item[2] == li[2] && item[3] == li[3]) return;
        }

        list.Add(li);
    }
}