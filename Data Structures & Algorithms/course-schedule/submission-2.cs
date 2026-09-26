public class Solution
{
    public HashSet<int> visiting = new HashSet<int>();
    public Dictionary<int, List<int>> opening = 
        new Dictionary<int, List<int>>(); // який курс пройти : які відкриються

    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        for (int i = 0; i < numCourses; i++) // загальна кількість курсів, деякі існуюють без передумов
            opening[i] = new List<int>();

        foreach (var prereq in prerequisites) // заповнення: який курс пройти - які відкриються
            opening[prereq[1]].Add(prereq[0]);

        for (int i = 0; i < numCourses; i++) // проходимось по усім курсам (деякі без передумови)
            if (!DFS(i)) return false;

        return true;
    }
        private bool DFS(int course)
        {
            if (visiting.Contains(course)) return false; // міститься цикл
            if (opening[course].Count == 0) return true; // цей курс нічого не відкриває

            visiting.Add(course);
            foreach (int open in opening[course]) // проходимось по тим, що відкриваються
                if (!DFS(open)) return false; // зацикленність

            visiting.Remove(course);

            // означає: курс (та інші, що відкриваються) пройдені 
            // й не містять циклу (якщо сюди дійшли), то ми очищаємо, щоб цей курс не перевірявся
            opening[course].Clear();
            return true;
        }
}
