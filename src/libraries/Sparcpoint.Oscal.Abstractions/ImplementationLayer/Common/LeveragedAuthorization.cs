namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record LeveragedAuthorization
{
    public Uuid Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public Uuid PartyUuid { get; set; }
    public DateOnly DateAuthorized { get; set; }
}

