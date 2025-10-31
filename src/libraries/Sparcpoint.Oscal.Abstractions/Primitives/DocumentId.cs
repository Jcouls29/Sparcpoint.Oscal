namespace Sparcpoint.Oscal.Primitives;

public readonly record struct DocumentId(Uri? Scheme = null, string? Identifier = null) { }
