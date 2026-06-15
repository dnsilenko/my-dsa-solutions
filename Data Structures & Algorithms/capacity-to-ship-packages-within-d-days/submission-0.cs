public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = 0, r = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            r += weights[i];
            if (weights[i] > l) l = weights[i];
        }

        int mid = (l + r) / 2, lastValidate = 0;
        while (l <= r)
        {
            if (Validate(weights, days, mid))
            {
                lastValidate = mid;
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }

            mid = (l + r) / 2;
        }

        return lastValidate;
    }   

    private bool Validate(int[] weights, int days, int capacity)
    {
        int counter = 1, localcap = 0;
        for (int i = 0; i < weights.Length; i++)
        {
            if (localcap + weights[i] <= capacity)
            {
                localcap += weights[i];
            }
            else
            {
                localcap = weights[i];
                counter++;
            }
        }

        return counter <= days;
    } 
}