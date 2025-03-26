using FluentValidation.TestHelper;
using Options.Pattern.Api.Settings;
using Options.Pattern.Api.Validators;

namespace Options.Pattern.Tests;

public class ValidationTests
{
    // Uses helper methods from FluentValidation.TestHelper
    [Fact]
    public void GitHubSettings_WithMissingAccessToken_ShouldHaveValidationError()
    {
        // Arrange
        var validator = new GitHubSettingsValidator();
        var settings = new GitHubSettings 
        { 
            BaseUrl = "https://base_url.com",
            AccessToken = "access-token",
            RepositoryName = "test-repo" 
        };

        // Act
        TestValidationResult<GitHubSettings>? result = validator.TestValidate(settings);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }
}
