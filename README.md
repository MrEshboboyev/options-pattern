# 🚀 .NET Options Pattern with Fluent Validation

## 🌟 Project Overview

Supercharge your .NET configuration management with a robust Options Pattern implementation using FluentValidation! This project demonstrates a clean, type-safe, and extensible approach to handling configuration settings in ASP.NET Core applications.

![.NET Version](https://img.shields.io/badge/.NET-10.0-purple?style=for-the-badge&logo=dotnet)
![FluentValidation](https://img.shields.io/badge/FluentValidation-12.0-blue?style=for-the-badge)
![Build Status](https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge)

## ✨ Key Features

- 🔒 Type-safe configuration management
- 🛡️ Robust validation using FluentValidation
- 🧩 Modular and extensible design
- 📦 Easy configuration binding
- 🚦 Validation on application startup

## 🛠️ Technologies

- .NET 10.0
- FluentValidation
- ASP.NET Core
- Dependency Injection

## 📦 Installation

```bash
# Clone the repository
git clone https://github.com/MrEshboboyev/options-pattern.git

# Navigate to the project directory
cd Options.Pattern

# Restore packages
dotnet restore

# Run the application
dotnet run
```

## 💡 Usage Example

```csharp
// Automatically register and validate options
builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);
builder.Services.AddOptionsWithFluentValidation<GitHubSettings>(
    GitHubSettings.ConfigurationSection
);
```

## 🔍 Project Structure

```
├── src/
│   └── Options.Pattern.Api/
│       ├── Extensions/
│       ├── Settings/
│       └── Validators/
└── tests/
    └── Options.Pattern.Tests/
```

## 🧪 Running Tests

```bash
dotnet test
```

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.

## 🌈 Tags

`#dotnet` `#configuration` `#options-pattern` `#fluent-validation` `#aspnetcore` `#csharp`

---

**Made with ❤️ by MrEshboboyev**
