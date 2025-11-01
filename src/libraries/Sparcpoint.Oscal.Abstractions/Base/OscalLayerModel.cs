namespace Sparcpoint.Oscal.Base;

public abstract record OscalLayerModel
{
    public Uuid Uuid { get; set; }
    public Metadata Metadata { get; set; } = new Metadata();
    public BackMatter? BackMatter { get; set; }
}
