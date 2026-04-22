namespace LeetCode.Easy;

public class Palindrome_Number
{
    // Input: x = 121
    public bool IsPalindrome(int x)// 121
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        int revHalf = 0;
        while (x > revHalf)
        {
            revHalf = (revHalf * 10) + (x % 10);// 1
            x /= 10; // 12, 1
        }

        return x == revHalf || x == revHalf / 10; // 1, 1 == true
    }
}