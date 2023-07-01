public class Solution {
    public bool IsPalindrome(int x) {
            //int x = 12221;
            string y = x.ToString();
            bool isPalindrome = false;
            int length = y.Length;
            for(int i = 0; i < y.Length; i++)
            {
                if (y[i] == y[length -= 1])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                }
                if (!isPalindrome)
                {
                    break;
                }
            }
            return isPalindrome;
    }
}
