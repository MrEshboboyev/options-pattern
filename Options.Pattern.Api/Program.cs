using FluentValidation;
using Options.Pattern.Api.Extensions;
using Options.Pattern.Api.Settings;
using Options.Pattern.Api.Validators;
using System.Net.NetworkInformation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//// #Option 1: Standard Registration with Manual Validator Registration
//// Register the validator
//builder.Services.AddScoped<IValidator<GitHubSettings>, GitHubSettingsValidator>();

//// Configure options with validation
//builder.Services.AddOptions<GitHubSettings>()
//    .BindConfiguration(GitHubSettings.ConfigurationSection)
//    .ValidateFluentValidation() // Configure FluentValidation validation
//    .ValidateOnStart();

//// #Option 2: Using the Convenience Extension Method
//// Register the validator
//builder.Services.AddScoped<IValidator<GitHubSettings>, GitHubSettingsValidator>();

//// Use the convenience extension
//builder.Services.AddOptionsWithFluentValidation<GitHubSettings>(GitHubSettings.ConfigurationSection);

// #Option 3: Automatic Validator Registration
// If you have many validators and want to register them all at once,
// you can use FluentValidation's assembly scanning:

// Register all validators from assembly
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

// Use the convenience extension
builder.Services.AddOptionsWithFluentValidation<GitHubSettings>(GitHubSettings.ConfigurationSection);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
