public class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] numbers = { 1000021, 121, 101, 1005981 };
        int idx = rnd.Next(0, numbers.Length);
        
        bool isPalindrome = Palindrome(numbers[idx]);
        Console.WriteLine("Number {0} is Palindromo {1}", numbers[idx], isPalindrome);
        
        bool isPalindrome2 = Palindrome(numbers[idx], 0);
        Console.WriteLine("Number {0} is Palindromo {1}", numbers[idx], isPalindrome2);
    }

    static bool Palindrome(int x)
    {
        string y = x.ToString();
        if (x < 0 || !(y[0] == y[y.Length - 1]) ) return false;

        int count = 0;
        char[] reverse = new char[y.Length];
        for (int i = y.Length; i > 0; i--)
        {
            reverse[count] = y[i - 1];
            count++;
        }

        if (Int32.TryParse(reverse, out int result))
        {
            if (result == x) return true;
        };
        
        return false;
    }

    static bool Palindrome(int x, int y = 0)
    {
        string f = x.ToString();
        char[] charArr = f.ToCharArray();
        char[] reverse = f.ToCharArray();
        
        Array.Reverse(reverse);
        
        return charArr.SequenceEqual(reverse);
    }

}