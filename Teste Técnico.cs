public class Solution
{
    public static void Main()
    {
        Console.WriteLine(DetectCapitalUse("UsA"));
    }

    static bool DetectCapitalUse(string word)
    {
        if (char.IsUpper(word[0]))
        {
            if (word.Length > 1)
            {
                if (char.IsUpper(word[1]))
                {
                    for (int letter = 1; letter < word.Length; letter++)
                    {
                        if (!char.IsUpper(word[letter])) return false;
                    }
                }
                else
                {
                    for (int letter = 1; letter < word.Length; letter++)
                    {
                        if (char.IsUpper(word[letter])) return false;
                    }
                }
            }
            return true;
        }
        else
        {
            for (int letter = 0; letter < word.Length; letter++)
            {
                if (char.IsUpper(word[letter])) return false;
            }
            return true;
        }
    }
}