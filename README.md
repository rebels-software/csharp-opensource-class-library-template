# C# Library Template

![License](https://img.shields.io/badge/license-Apache%202.0-blue.svg)

## Overview
Welcome to the [Rebels'](https://www.rebels.software/) **C# Library Template**! This repository provides a structured template for creating C# libraries with Apache 2.0 license. It serves as a starting point for developing open-source C# projects and follows best practices for maintainability, testing, and deployment.

## Features
- **Pre-configured project structure** for C# library development.
- **Apache 2.0 License**, ensuring open-source compliance.
- **Unit testing** setup with nUnit.
- **CI/CD integration** with GitHub Actions.
- **NuGet package publishing support** (optional).
- **Code style enforcement** using .editorconfig and Roslyn analyzers.

## Getting Started

### Prerequisites
Ensure you have the following installed:
- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Git](https://git-scm.com/)

### Installation

<details>
<summary>Clone repository and install template locally</summary>

1. Ensure that template is not installed
   ```sh
   dotnet new list | grep "rebels-class-library"
   ```
2. Ensure that you cloned this repository:
   ```sh
   git clone https://github.com/rebels-software/csharp-opensource-class-library-template
   ```
3. Install by pointing to directory with cloned project with [dotnet install](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates#to-install-a-template-package-from-a-file-system-directory)
   ```sh
   dotnet new install <PATH-TO-CLONED>
   ```
</details>

<details>
<summary>Install from NuGet</summary>
1. Use NuGet package manager [dotnet install](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates#to-install-a-template-package-from-a-nuget-package-stored-at-nugetorg)
   ```sh
   dotnet new install <NUGET-PACKAGE-ID>
   ```
</details>

### Usage
<details>
<summary>From command line interface</summary>
   ```sh
   dotnet new rebels-class-library -n <YOUR-LIBRARY-NAME>
   ```
</details>

<details>
<summary>From Visual Studio</summary>
1. Go to File -> New -> Project
2. Select Rebels class library
3. Follow the wizard
</details>

### Customization
- Modify `README.md`
- Modify `.github/workflows/build.yml` for CI/CD settings.
- Configure NuGet publishing if needed.

## Contributing
We welcome contributions! Please follow these steps:
1. Fork this repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -m "Add feature"`).
4. Push to your branch (`git push origin feature-name`).
5. Open a Pull Request.

### Code Style
Ensure code follows the .NET coding standards:
- Use `dotnet format` to auto-format code.
- Run `dotnet test` before submitting a PR.

## License
This project is licensed under the [Apache 2.0 License](LICENSE).

## Contact
For questions or support, open an issue or contact us at [we@rebels.software](mailto:we@rebels.software).

