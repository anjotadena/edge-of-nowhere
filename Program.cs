using edge_of_nowhere;

var containsDuplicate = new ContainsDuplicate();

Console.WriteLine($"Contains duplicate: [1,2,3,4,3,5] => {containsDuplicate.Solution(new int[] { 1, 2, 3, 4, 3, 5 })}");


var validAnagrams = new ValidAnagram();

Console.WriteLine($"Valid Anagrams: Input: s = \"anagram\", t = \"nagaram\" => {validAnagrams.Solution("anagram", "nagaram")}");

