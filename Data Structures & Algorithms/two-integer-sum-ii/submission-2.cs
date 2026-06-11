public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int i = 0; i < numbers.Length; i++)
        {
            int l = 0, r = numbers.Length - 1;
            int mid = numbers.Length / 2;

            while (l <= r)
            {
                if (numbers[mid] < target - numbers[i])
                {
                    l = mid + 1;
                }
                else if (numbers[mid] > target - numbers[i])
                {
                    r = mid - 1;
                }
                else
                {
                    var result = new int[2];
                    result[0] = i + 1;
                    result[1] = mid + 1;

                    return result;
                }

                mid = (l + r) / 2;
            }     
        }

        return null;
    }
}
