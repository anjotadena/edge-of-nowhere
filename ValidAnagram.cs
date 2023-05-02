namespace edge_of_nowhere
{
    public class ValidAnagram
    {
        public bool Solution(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            if (s == t)
            {
                return true;
            }

            Dictionary<char, int> firstChars = new Dictionary<char, int>();
            Dictionary<char, int> secondChars = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                // First characters sets
                if (!firstChars.ContainsKey(s[i]))
                {
                    firstChars[s[i]] = 0;
                }

                firstChars[s[i]]++;

                // Second characters sets
                if (!secondChars.ContainsKey(t[i]))
                {
                    secondChars[t[i]] = 0;
                }

                secondChars[t[i]]++;
            }

            foreach (char c in firstChars.Keys)
            {
                int count = 0;

                if (secondChars.ContainsKey(c))
                {
                    count = secondChars[c];
                }

                if (count != firstChars[c])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
