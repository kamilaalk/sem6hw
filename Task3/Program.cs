

string input = "1234";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");

bool IsPalindrome(string str)
{
string normal = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return normal.SequenceEqual(normal.Reverse());
}
