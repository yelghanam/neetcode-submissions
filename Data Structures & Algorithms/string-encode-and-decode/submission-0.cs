public class Solution
{
    public string Encode(IList<string> strs)
    {
        string result = "";

        foreach (string s in strs)
        {
            result += s.Length + "#" + s;
        }

        return result;
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();

        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            while (s[j] != '#')
            {
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

            j++; // move past '#'

            string word = s.Substring(j, length);
            result.Add(word);

            i = j + length;
        }

        return result;
    }
}