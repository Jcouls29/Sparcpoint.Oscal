namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileModifyRemove
{
    public Token? ByName { get; set; }
    public Token? ByClass { get; set; }
    public Token? ById { get; set; }
    public Token? ByItemName { get; set; }
    public Token? ByNamespace { get; set; }
}
