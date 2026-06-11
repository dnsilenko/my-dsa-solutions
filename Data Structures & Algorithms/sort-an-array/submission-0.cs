public class Solution {
    public int[] SortArray(int[] nums) {
        return MergeSort(nums);    
    }

    private int[] MergeSort(int[] array)
    {
        if (array.Length <= 1) return array;

        int mid = array.Length / 2;
        int[] left = new int[mid];       
        for (int i = 0; i < mid; i++)
        {
            left[i] = array[i];
        }

        int[] right = new int[array.Length - mid];
        for (int i = mid; i < array.Length; i++)
        {
            right[i - mid] = array[i];
        }

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    private int[] Merge(int[] left, int[] right)
    {
        int[] array = new int[left.Length + right.Length]; int a = 0, l = 0, r = 0;
        while (l < left.Length && r < right.Length)
        {
            if (left[l] < right[r]) array[a++] = left[l++];
            else array[a++] = right[r++];
        }

        while (l < left.Length)
        {
            array[a++] = left[l++];     
        }

        while (r < right.Length)
        {
            array[a++] = right[r++];     
        }

        return array;
    }
}