public class Solution {
    public int MySqrt(int x) {
        if (x == 0 || x == 1) return x;

        int l = 2, r = x / 2, mid = (l + r) / 2;
        while (l <= r)
        {
            if (mid < x / mid) l = mid + 1;
            else if (mid > x / mid) r = mid - 1;
            else return mid;

            mid = (l + r) / 2;
        }

        return mid;
    }
}