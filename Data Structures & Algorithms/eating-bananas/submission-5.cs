public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        Array.Sort(piles);
        int l = 1, r = piles[piles.Length - 1], mid = (l + r) / 2, lv = 0; 

        while (l <= r)
        {
            bool validate = Validate(piles, h, mid);

            if (validate) 
            {
                lv = mid;
                r = mid - 1;
            }
            else if (!validate)
            {
                l = mid + 1;
            }
          
            mid = (l + r) / 2;
            if (mid == 0) mid = 1;
        }

        if (Validate(piles, h, mid)) return mid;
        else return lv;
    }

    private bool Validate(int[] piles, int h, int speed)
    {
        int counter = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            counter += (piles[i] + speed - 1) / speed;
        }

        if (counter <= h) return true;
        return false;
    }
}
