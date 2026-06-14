public class Solution {
    public int MySqrt(int x) {
if (x == 0) return 0;

        int counter = 1;         
        for (int i = 0; i < x; i++)
        {
            if ((long)i * i > x) return counter;
            counter = i;
        }

        return 1;
    }
}