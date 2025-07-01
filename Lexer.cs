namespace Wayvlyte.BladeDSL;

public class Lexer
{
    public List<BladeNode> nodes = [];

    public List<string> keywords = [
        "proj",
        "libraries"
    ];

    public void Parse(string fileContent)
    {
        var words = fileContent.Trim().Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];

            if (word.StartsWith('[') && word != "[")
            {
                word = word[..0];
                nodes.Add(new BladeNode(Tokens.StartLoop, word));
            }
            else if (word.EndsWith(']') && word != "]")
            {
                word = Strings.RemoveSuffix(word, "]");
                nodes.Add(new BladeNode(Tokens.EndLoop, word));
            }

            var keywordIndex = keywords.IndexOf(word);

            if (word == "{" || word == "}")
            {
                // Its just there to be fashionable
                nodes.Add(new BladeNode(Tokens.Block, word));
            }
            else
            {
                // Check if there is another word and go ahead
                if (keywordIndex != -1)
                {
                    nodes.Add(new BladeNode(Tokens.Keyword, keywords[keywordIndex]));
                }
                else
                {
                    nodes.Add(new BladeNode(Tokens.Value, word));
                }
            }
        }
    }
}
