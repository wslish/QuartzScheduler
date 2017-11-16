using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace QuartzScheduler.Localization
{
    public static class QuartzSchedulerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(QuartzSchedulerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(QuartzSchedulerLocalizationConfigurer).GetAssembly(),
                        "QuartzScheduler.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
