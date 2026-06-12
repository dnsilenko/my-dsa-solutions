public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int l = 0, r = people.Length - 1, counter = 0;

        while (l <= r)
        {
            if (people[r] == limit)
            {
                counter++;
                r--;
            }
            else if (people[r] + people[l] <= limit)
            {
                counter++;
                r--;
                l++;
            }
            else if (people[r] <= limit)
            {
                counter++;
                r--;
            }
            else
            {
                counter++;
                l++;
            }
        }

        return counter;
    }
}