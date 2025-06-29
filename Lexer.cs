namespace Wayvlyte.BladeDSL;

public class Lexer
{
    public List<BladeNode> nodes = [];

    public List<List<string>> keywords = [
        ["proj", Keywords.Project]
    ];

    public void Parse(string fileContent)
    {
        var words = fileContent.Trim().Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            var word = words[i];

            if (word.StartsWith('{') && word != "{")
            {
                nodes.Add(new BladeNode(Tokens.StartLoop, word));
            }
            else if (word.EndsWith('}') && word != "}")
            {
                nodes.Add(new BladeNode(Tokens.EndLoop, word));
            }

            // Check if there is another word and go ahead
            if (i + 1 < words.Length && )
            {

            }
        }
    }
}
