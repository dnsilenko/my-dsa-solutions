public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {

        var stack = new Stack<int>();
        foreach (var asteroid in asteroids)
        {
            bool alive = true;
            while (alive && asteroid < 0 && stack.Count > 0 && stack.Peek() > 0)
            {
                if (stack.Peek() < Math.Abs(asteroid)) stack.Pop();
                else
                {
                    alive = false;
                    if (stack.Peek() == Math.Abs(asteroid)) stack.Pop();
                }
            }

            if (alive) stack.Push(asteroid);
        }    

        var result = new int[stack.Count];
        for (int i = result.Length - 1; i >= 0; i--)
        {
            result[i] = stack.Pop();
        }

        return result;
    }
}