public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint result = 0;

        for (int i = 0; i < 32; i++) // переносимо кожен біт окремо
        {
            uint bit = (n >> i) & 1; // отримуємо: 0/1 біт із i-позиції
            result += (bit << (31 - i)); // зсуваємо на необхідну позицію 
        }

        return result;        
    }
}                    