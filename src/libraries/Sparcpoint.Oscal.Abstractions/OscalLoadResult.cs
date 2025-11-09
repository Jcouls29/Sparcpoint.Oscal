namespace Sparcpoint.Oscal;

public record OscalLoadResult
{
    public bool IsLoaded { get; set; } = false;
    public OscalModel? Model { get; set; }
    public OscalModelKind Kind => Model?.Kind ?? OscalModelKind.Unknown;
    public Exception? LoadException { get; set; }

    public static OscalLoadResult Successful(OscalModel model)
        => new OscalLoadResult
        {
            IsLoaded = true,
            Model = model,
            LoadException = null
        };

    public static OscalLoadResult Failed(Exception ex)
        => new OscalLoadResult
        {
            IsLoaded = false,
            Model = null,
            LoadException = ex
        };
}
