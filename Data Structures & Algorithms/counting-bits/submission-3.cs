public class Solution
{
    public int[] CountBits(int n)
    {
        var counting = new int[n + 1];   
        for (int i = 0; i <= n; i++)
        {
            int counter = 0;
            for (int num = i; num > 0;)
            {
                num = num & (num - 1);
                counter++;
            }

            counting[i] = counter;
        }   

        return counting;
    }
}
  