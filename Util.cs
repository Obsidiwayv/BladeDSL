namespace Wayvlyte.BladeDSL;

public static class Strings
{
    public static string RemoveSuffix(this string s, string suffix)
    {
        if (s.EndsWith(suffix)) {
            return s[..^suffix.Length];
        }
        return s;
    }
}