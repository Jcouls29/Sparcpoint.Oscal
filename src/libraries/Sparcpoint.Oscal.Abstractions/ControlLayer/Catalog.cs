using System.Reflection;

namespace Sparcpoint.Oscal.ControlLayer;

public record Catalog
{
    public Uuid Uuid { get; set; }
    public Metadata Metadata { get; set; } = new Metadata();
    public Param[]? Params { get; set; }
    public Control[]? Controls { get; set; }
    public Group[]? Groups { get; set; }
    public BackMatter? BackMatter { get; set; }
}