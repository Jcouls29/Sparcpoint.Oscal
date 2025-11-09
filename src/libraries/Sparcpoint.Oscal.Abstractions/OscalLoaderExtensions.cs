namespace Sparcpoint.Oscal;

public static class OscalLoaderExtensions
{
    public static Task<OscalLoadResult> ValidateAndLoadAsync(this IOscalLoader loader, string json)
    {
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json));
        return loader.ValidateAndLoadAsync(stream);
    }
}