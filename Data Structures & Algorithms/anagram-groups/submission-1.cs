public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
    //strs = ["act", "pots", "tops", "cat", "stop", "hat"];
    Dictionary<string, List<string>> dic = new();
    for (int i=0; i < strs.Length; i++)
    {
        char[] chars = strs[i].ToCharArray();// cat->[c,a,t]
        Array.Sort(chars);
        string sorted = new string(chars); //   -->[a,c,t]
        if (dic.ContainsKey(sorted))
        {
            dic[sorted].Add(strs[i]);
        }
        else 
        { 
            dic[sorted] = new List<string>();
            dic[sorted].Add(strs[i]);
        }
    }
        
        return dic.Values.ToList();


}
}
