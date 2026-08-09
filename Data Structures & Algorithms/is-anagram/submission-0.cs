public class Solution {
    public bool IsAnagram(string s, string t) { 
    
    Dictionary<char,int> dic = new();
    for (int i= 0; i < s.Length; i++) {

        if (s.Length != t.Length)
        {
            Console.WriteLine("false");
            return false;
        }
    else if (dic.ContainsKey(s[i]))
    {
        dic[s[i]]++;
    } else { dic[s[i]] = 1; }
}
    for (int i=0; i<t.Length; i++)
{
    if (dic.ContainsKey(t[i]))
    {
        dic[t[i]]--;
    } else { 
        Console.WriteLine("false");
        return false; }
    if (dic[t[i]] < 0) { 
        Console.WriteLine("false");
        return false;
    }
}
Console.WriteLine("True");
return true; }
}
