namespace Sparcpoint.Oscal;

public interface IOscalLoader
{
    bool CanLoad(string mediaType);
    Task<OscalLoadResult> ValidateAndLoadAsync(Stream stream);
}
