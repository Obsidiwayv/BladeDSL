namespace Wayvlyte.BladeDSL;

public enum Tokens
{
    Keyword,
    Value,
    EndLoop,
    StartLoop,
    Block
}

// Keyword enums to be assigned to keywords
public enum Keywords
{
    Project,
    Libaries,
    Runtimes,
    Includes,
    UnrealNaming,
    Assets
}

// A tree class object to be used for parsing
public class BladeNode(Tokens token, string value)
{
    public Tokens Token { get; } = token;

    public string Value { get; } = value;
}