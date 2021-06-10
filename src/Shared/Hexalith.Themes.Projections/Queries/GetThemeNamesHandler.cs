namespace Hexalith.Themes.Queries
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using Hexalith.ApplicationLayer.Model;

    public class GetThemeNamesHandler : QueryHandler<GetThemeNames, List<string>>
    {
        private readonly IOptions<ApplicationLayerSettings> _settings;

        public GetThemeNamesHandler(ICollectionStore<ThemeSummary> settings)
        {
            _settings = settings;
        }

        public override Task<string> Handle(Envelope<GetApplicationName> envelope, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_settings.Value.ApplicationName);
        }
    }
}