public class Solution
{
    public int HammingWeight(uint n)
    {
        int counter = 0;
        while (n != 0)
        {
            n &= n - 1;
            counter++;
        }            

        return counter;
    }
}
