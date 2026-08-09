public class Solution {

public bool IsPalindrome(string s)
{
    // 'RACE CAR'
    string r = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

    int left = 0;
    int right = r.Length-1;

    while (left < right) {

        

        if (r[left] == r[right])
        {
            left++;
            right--;
        }
        else {
            Console.WriteLine("FALSE");
            return false;
                 }
    }

    Console.WriteLine("True");
    return true;
}    

}
