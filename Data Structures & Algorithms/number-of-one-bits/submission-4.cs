public class Solution
{
    public int HammingWeight(uint n)
    {
        int counter = 0;
        while (n != 0) // поки є одиниці
        {
            n = n & (n - 1); // видаляєм по одній одиниці
            counter++;
        }

        return counter;              
    }
}
