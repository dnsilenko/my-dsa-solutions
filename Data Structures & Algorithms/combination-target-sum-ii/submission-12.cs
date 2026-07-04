public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var total = new List<List<int>>(); 
        DFS(0, candidates, target, new List<int>(), total);

        return total;
    }

    private void DFS(int start, int[] num, int tg, List<int> list, List<List<int>> total)
    {   // tg -> це "скільки ще залишилось", якщо == 0 -> знайшли підмножину
        if (tg == 0) total.Add(list);
        if (tg <= 0) return;
        
        //  
        for (int i = start; i < num.Length; i++) 
        {   // i > start -> являє "поточне дерево рекурсії" 
            if (i > start && num[i] == num[i - 1]) continue;
            else if (num[i] > tg) break;

            list.Add(num[i]); // додаємо елемент та пробуємо із ним
            DFS(i + 1, num, tg - num[i], list.ToList(), total);
            
            list.RemoveAt(list.Count - 1);
        }        
    }

}
