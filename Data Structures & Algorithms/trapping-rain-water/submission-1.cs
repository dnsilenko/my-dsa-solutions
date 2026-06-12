public class Solution {
    public int Trap(int[] height) {
        int l = 0, r = height.Length - 1, maxl = height[l], maxr = height[r];
        int counter = 0;

        while (l < r)
        {
            if (height[l] < height[r])
            {
                l++;
                int diapason = maxl - height[l];
                if (diapason > 0) counter += diapason;   
                        
                if (maxl < height[l]) maxl = height[l];  
            }
            else
            {
                r--;
                int diapason = maxr - height[r];
                if (diapason > 0) counter += diapason;

                if (maxr < height[r]) maxr = height[r];
            }
        } 

        return counter;
    }
}