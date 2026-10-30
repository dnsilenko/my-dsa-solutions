public class Solution
{
    public int GetSum(int a, int b)
    {
        while (b != 0) 
        {
            // знаходимо: де виникає кожен перенос (1 + 1)
            int carry = (a & b) << 1;
            
            a ^= b; //  додавання у стовпчик
            b = carry;
        }

        return a;   
    }
}
