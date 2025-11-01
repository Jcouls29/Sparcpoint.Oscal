namespace Sparcpoint.Oscal.Base;

public abstract record OscalRemarksModel : OscalAttributesModel
{
    public MarkupMultiline? Remarks { get; set; }
}