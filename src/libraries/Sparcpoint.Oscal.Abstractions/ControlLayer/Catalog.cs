namespace Sparcpoint.Oscal.ControlLayer;

public record Catalog : OscalLayerModel
{
    public Param[]? Params { get; set; }
    public Control[]? Controls { get; set; }
    public Group[]? Groups { get; set; }
}