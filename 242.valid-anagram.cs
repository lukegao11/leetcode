/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
// public class Solution {
//     public bool IsAnagram(string s, string t) {
//         PriorityQueue<char, char> sp = new PriorityQueue<char, char>(
//         (a, b) => a.AsciiCode - b.AsciiCode);
//         PriorityQueue<char, char> tp = new PriorityQueue<char, char>(
//         (a, b) => a.AsciiCode - b.AsciiCode);

//         foreach (char i in s){
//             sp.Enqueue(i, i);
//         }
//         foreach (char i in t){
//             tp.Enqueue(i, i);
//         }
//         return sp.Equals(tp)? true: false;
//     }
// }

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) {
            return false;
        }
        char[] str1 = s.ToCharArray();
        char[] str2 = t.ToCharArray();
        Array.Sort(str1);
        Array.Sort(str2);
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        string res1 = new string(str1);
        string res2 = new string(str2);
        return res1.Equals(res2);
    }
}
// @lc code=end

