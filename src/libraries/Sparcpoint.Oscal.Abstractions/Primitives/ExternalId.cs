namespace Sparcpoint.Oscal.Primitives;

public readonly record struct ExternalId(Uri Scheme, string? Id = null) { }
