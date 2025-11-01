namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Actor : OscalAttributesModel
{
    public Token Type { get; set; }
    public Uuid ActionUuid { get; set; }
    public Token? RoleId { get; set; }
}
