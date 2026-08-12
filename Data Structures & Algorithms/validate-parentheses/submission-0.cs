public class Solution {
    public bool IsValid(string s)
{
    //s = "(  [   {   }   ]   )";

    Stack<char> stack = new Stack<char>();
    foreach (char c in s) {

        if (c == '(' || c == '[' || c == '{') 
        {
            stack.Push(c);
        } else if (c== ')' || c == ']' || c == '}') {
            // Handle closing brackets
            if (stack.Count == 0) {
                return false;
            }
            char top = stack.Pop();
            if ((c == ')' && top != '(') ||
                (c == ']' && top != '[') ||
                (c == '}' && top != '{')) {
                return false;
            }
        }
    }
        if (stack.Count != 0)
        {
            return false;
        }
    return true;

}
}
