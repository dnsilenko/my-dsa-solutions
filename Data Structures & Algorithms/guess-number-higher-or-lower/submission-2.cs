/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        long l = 1, r = n, mid = (l + r) / 2;
        while (guess((int)mid) != 0)
        {
            if (guess((int)mid) > 0) l = mid + 1;
            else r = mid - 1;

            mid = (l + r) / 2; 
        }

        return (int)mid;
    }
}