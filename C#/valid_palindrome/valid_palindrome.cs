using System;
using System.Diagnostics;
using System.Text;

namespace valid_palindrome;

public class Program {
public static void Main() {
    Stopwatch stopwatch = new();
    string test1 = "A man, a plan, a canal: Panama";
    string test2 = "race a car";
    string test3 = " ";

    stopwatch.Start();
    IsPalindromeA(test1);
    stopwatch.Stop();
    Console.WriteLine($"IsPalindromeA(test1) took {stopwatch.ElapsedMilliseconds} ms\n");
    stopwatch.Reset();

    stopwatch.Start();
    IsPalindromeB(test1);
    stopwatch.Stop();
    Console.WriteLine($"IsPalindromeB(test1) took {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Reset();

	Console.WriteLine("\n----------\n");

    stopwatch.Start();
    IsPalindromeA(test2);
    stopwatch.Stop();
    Console.WriteLine($"IsPalindromeA(test2) took {stopwatch.ElapsedMilliseconds} ms\n");
    stopwatch.Reset();

    stopwatch.Start();
    IsPalindromeB(test2);
    stopwatch.Stop();
    Console.WriteLine($"IsPalindromeB(test2) took {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Reset();

	Console.WriteLine("\n----------\n");

    stopwatch.Start();
    IsPalindromeA(test3);
    stopwatch.Stop();
    Console.WriteLine($"IsPalindromeA(test3) took {stopwatch.ElapsedMilliseconds} ms\n");
    stopwatch.Reset();

    stopwatch.Start();
    IsPalindromeB(test3);
    stopwatch.Stop();
    Console.WriteLine($"IsPalindromeB(test3) took {stopwatch.ElapsedMilliseconds} ms");
}

    // public static bool IsPalindrome(string s) {
    //     // Converting all uppercase letters into lowercase letters
    //     for (int i = 0; i < s.Length; i++) {
    //         char c = s[i];
    //         if (Char.IsUpper(c)) {
    //             c = Char.ToLower(c);
    //             s = s.Remove(i, 1); // Remove the original character
    //             s = s.Insert(i, c.ToString()); // Insert the lowercase character
    //         }
    //         // Removing all non-alphanumeric characters
    //         if (!Char.IsLetterOrDigit(c)) {
    //             s = s.Remove(i, 1);
    //             i--; // Decrement the index because the string length has changed
    //         }
    //     }

    //     int len = s.Length;
    //     if (len == 0) {
    //         Console.WriteLine($"String '{s}' IS a valid palindrome");
    //         return true;
    //     }
	// 	for (int i = 0, j = len - 1; i < len / 2; i++, j--) {
	// 		if (s[i] != s[j]) {
	// 			Console.WriteLine($"String '{s}' is NOT a valid palindrome");
	// 			return false;
	// 		}
	// 	}
    //     Console.WriteLine($"String '{s}' IS a valid palindrome");
    //     return true;
    // }

    public static bool IsPalindromeA(string s) {
        StringBuilder sb = new();

        for (int i = 0; i < s.Length; i++) {
            char c = Char.ToLowerInvariant(s[i]);
            if (Char.IsLetterOrDigit(c)) {
                sb.Append(c);
            }
        }
        s = sb.ToString();

        int len = s.Length;
        if (len == 0) {
            Console.WriteLine($"'{s}' is a palindrome");
            return true;
        }
		for (int i = 0, j = len - 1; i < len / 2; i++, j--) {
			if (s[i] != s[j]) {
				Console.WriteLine($"'{s}' is not a palindrome");
				return false;
			}
		}
        Console.WriteLine($"'{s}' is a palindrome");
        return true;
    }

	public static bool IsPalindromeB(string s) {
        int start = 0;
        int end = s.Length - 1;

        while (start < end) {
            // Skip non-alphanumeric characters from the start
            if (!Char.IsLetterOrDigit(s[start])) {
                start++;
				continue;
            }
            // Skip non-alphanumeric characters from the end
            if (!Char.IsLetterOrDigit(s[end])) {
                end--;
				continue;
            }

            // Compare the characters
            if (Char.ToLower(s[start]) != Char.ToLower(s[end])) {
                Console.WriteLine($"'{s}' is not a palindrome");
                return false;
            }
            start++;
            end--;
    	}
		Console.WriteLine($"'{s}' is a palindrome");
		return true;
	}
}

/*
    A phrase is a palindrome if, after converting all uppercase letters into
    lowercase letters and removing all non-alphanumeric characters, it reads
    the same forward and backward. Alphanumeric characters include letters
    and numbers.

    Given a string s, return true if it is a palindrome, or false otherwise.

    Example 1:
    Input: s = "A man, a plan, a canal: Panama"
    Output: true
    Explanation: "amanaplanacanalpanama" is a palindrome.
    
    Example 2:
    Input: s = "race a car"
    Output: false
    Explanation: "raceacar" is not a palindrome.
    
    Example 3:
    Input: s = " "
    Output: true
    Explanation: s is an empty string "" after removing non-alphanumeric characters.
    Since an empty string reads the same forward and backward, it is a palindrome.
    

    Constraints:
    - 1 <= s.length <= 2 * 105
    - s consists only of printable ASCII characters
*/
