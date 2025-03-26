namespace Options.Pattern.Api.Settings;

public class GitHubSettings
{
    public const string ConfigurationSection = "GitHubSettings";

    public string BaseUrl { get; init; }
    public string AccessToken { get; init; }
    public string RepositoryName { get; init; }
}