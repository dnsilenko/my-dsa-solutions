public class Solution {         
    public int MinEatingSpeed(int[] piles, int h) {

        Array.Sort(piles);
        int l = 1, r = piles[piles.Length - 1], mid = (l + r) / 2, lv = 0; 

        while (l <= r) // від одиниці до максимального значення BS
        {
            bool validate = Validate(piles, h, mid); // перевіряємо mid 

            if (validate) // якщо mid підходить:
            {
                lv = mid; // запам'ятовуємо це значення та:
                r = mid - 1; // зменшуємо праву межу, щоб зменшити значення mid
            }
            else if (!validate) // якщо mid не підходить:
            {
                l = mid + 1; // збільшуємо ліву межу, щоб збільшити значення mid
            }
          
            mid = (l + r) / 2; // оновлення значення
            if (mid == 0) mid = 1; // щоб застерегти ділення на нуль
        }

        return lv;
    }

    private bool Validate(int[] piles, int h, int speed)
    {
        int counter = 0;
        for (int i = 0; i < piles.Length; i++)
        {
            counter += (piles[i] + speed - 1) / speed;
        }

        if (counter <= h) return true;
        return false;
    }
}
