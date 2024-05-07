using System.Diagnostics;

namespace reverse_string;

class Program {
    static void Main() {
        Stopwatch stopwatch = new();
    
        char[] test1 = ['h','e','l','l','o'];
        stopwatch.Start();
        ReverseString(test1);
        stopwatch.Stop();
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms\n");

        char[] test2 = ['H','a','n','n','a','h'];
        stopwatch.Restart();
        ReverseString(test2);
        stopwatch.Stop();
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

    public static void ReverseString(char[] s) {
        // ---
        Console.Write("Original string: ");
        foreach (char c in s) {
            Console.Write(c);
        }   

        // ---
        // Array.Reverse(s);
    
        // ---
        for (int i = 0, j = s.Length - 1; i < j; i++, j--) {
            // if (Char.IsControl(s[i])) {
            //     Console.WriteLine($"{s[i]} is a non-printing character");
            //     return;
            // }
            (s[i], s[j]) = (s[j], s[i]);
        }

        // ---
        Console.Write($"\nReversed string: ");
        foreach (char c in s) {
            Console.Write(c);
        }
        Console.WriteLine();
    }

    // public static void ReverseString(char[] s) {
    //     // Iterate over the first half of the array
    //     for (int i = 0; i <= (s.Length - 2) / 2; i++) {
    //         // Store the character at position i
    //         var tmp = s[i];
    //         // Replace the character at position i with the character at the corresponding position from the end
    //         s[i] = s[s.Length - 1 - i];
    //         // Replace the character at the corresponding position from the end with the original character at position i
    //         s[s.Length - 1 - i] = tmp;
    //     }
    // }
}

/*
    Write a function that reverses a string. The input string is given as an array of characters s.

    You must do this by modifying the input array in-place with O(1) extra memory.

    Example 1:
    Input: s = ["h","e","l","l","o"]
    Output: ["o","l","l","e","h"]
    
    Example 2:
    Input: s = ["H","a","n","n","a","h"]
    Output: ["h","a","n","n","a","H"]
    
    Constraints:
    - 1 <= s.length <= 105
    - s[i] is a printable ascii character.
*/
