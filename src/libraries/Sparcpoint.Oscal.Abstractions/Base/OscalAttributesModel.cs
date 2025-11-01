namespace Sparcpoint.Oscal.Base;

public abstract record OscalAttributesModel : OscalPropsModel
{
    public Link[]? Links { get; set; }
}
