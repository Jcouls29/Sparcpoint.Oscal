namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ComponentStatement : OscalRemarksModel
{
    public Token StatementId { get; set; }
    public Uuid Uuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}
