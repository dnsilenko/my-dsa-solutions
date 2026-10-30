public class Solution
{
    public int[] CountBits(int n)
    {
        var array = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            int counter = 0;
            for (int j = i; j > 0;)
            {
                j &= j - 1;
                counter++;
            }        

            array[i] = counter;
        }

        return array;    
    }
}
