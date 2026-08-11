public class Solution
{
    public uint ReverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {   
            // отримуватимемо біти:  
            // останній -> передостанній і тд.. 
            uint bit = (n >> i) & 1;

            // зсуваємо отриманий (кінцевий) біт на початок
            result += (bit << (31 - i));
        }         
        
        return result;       
    }
}
