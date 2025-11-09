namespace Sparcpoint.Oscal;

public record MediaTypeParts(
    string Type,
    string Subtype,
    string? Suffix,
    Dictionary<string, string> Parameters
);
