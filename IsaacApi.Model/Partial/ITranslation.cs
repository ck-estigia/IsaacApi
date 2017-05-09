using IsaacApi.Model.Helpers;

namespace IsaacApi.Model.Partial
{
    public interface ITranslation
    {
        string TranslationKey { get; set; }
        string TranslationValue { get; set; }
    }
}
