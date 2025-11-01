namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemInformation : OscalAttributesModel
{
    public InformationType[] InformationTypes { get; set; } = Array.Empty<InformationType>();
}

