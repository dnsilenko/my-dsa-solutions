public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var list = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length; j++)
            {
                int tg = (nums[i] + nums[j]) * -1;
                int l = j + 1, r = nums.Length - 1;
                int mid = (l + r) / 2;

                while (l <= r)
                {
                    if (nums[mid] < tg)
                    {
                        l = mid + 1;
                    }
                    else if (nums[mid] > tg)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        var li = new List<int>();
                        li.Add(nums[i]);
                        li.Add(nums[j]);
                        li.Add(tg);

                        Validate(list, li);
                        break;
                    }

                    mid = (l + r) / 2;
                }
            }
        }     

        return list;
    }

    private void Validate(List<List<int>> list, List<int> li)
    {
        foreach (var item in list)
        {
            if (item[0] == li[0] && item[1] == li[1] && item[2] == li[2]) return;
        }

        list.Add(li);
    }
}
