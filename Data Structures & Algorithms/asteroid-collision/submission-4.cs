public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {

        var stack = new Stack<int>();
        stack.Push(asteroids[0]);
        for (int i = 1; i < asteroids.Length; i++)
        {
            bool go = true;
            while (stack.Count > 0 && asteroids[i] < 0 && stack.Peek() > 0)
            {
                if (Math.Abs(asteroids[i]) != Math.Abs(stack.Peek()))
                {
                    int asteroid = stack.Pop();
                    if (Math.Abs(asteroid) > Math.Abs(asteroids[i]))
                    {
                        go = false; 
                        stack.Push(asteroid);
                        break;
                    }
                }
                else
                {
                    go = false;
                    stack.Pop();
                    break;
                }
            }     

            if (go) stack.Push(asteroids[i]);
        }    

        var result = new int[stack.Count];
        for (int i = result.Length - 1; i >= 0; i--)
        {
            result[i] = stack.Pop();
        }

        return result;
    }
}