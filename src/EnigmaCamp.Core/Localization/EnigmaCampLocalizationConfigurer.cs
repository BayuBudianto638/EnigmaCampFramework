using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EnigmaCamp.Localization
{
    public static class EnigmaCampLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EnigmaCampConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EnigmaCampLocalizationConfigurer).GetAssembly(),
                        "EnigmaCamp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
