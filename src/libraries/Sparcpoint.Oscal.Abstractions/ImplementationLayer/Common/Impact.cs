namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Impact : OscalAttributesModel
{
    public string Base { get; set; } = string.Empty;
    public string? Selected { get; set; }
    public MarkupMultiline? AdjustmentJustification { get; set; }
}

