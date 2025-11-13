# 🧮 Basic Calculator

<div align="center">

![Windows Forms](Images/WF.png)

**A simple and efficient calculator application**

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=for-the-badge&logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

</div>

---

## 📋 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Technologies](#-technologies)
- [Requirements](#-requirements)
- [Installation](#-installation)
- [Usage Guide](#-usage-guide)
- [Project Structure](#-project-structure)
- [Screenshots](#-screenshots)
- [Development Notes](#-development-notes)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About the Project

**Basic Calculator** is a simple and efficient calculator application developed using Windows Forms technology. This application allows you to perform basic mathematical operations such as addition, subtraction, multiplication, division, exponentiation, and root extraction.

The application features a clean and user-friendly interface with error handling for edge cases like division by zero and indeterminate forms. It's perfect for quick calculations and educational purposes.

### 🎨 Key Features

- ✨ **Simple Interface**: Clean and intuitive design
- ➕ **Basic Operations**: Addition, subtraction, multiplication, division
- 🔢 **Advanced Operations**: Exponentiation and root extraction
- ⚠️ **Error Handling**: Handles division by zero and indeterminate forms
- 🧹 **Clear Function**: Reset all fields with one click

---

## ✨ Features

### ➕ Basic Arithmetic Operations

#### ✅ Addition
- Add two numbers together
- Supports decimal numbers
- Instant result display

#### ✅ Subtraction
- Subtract the second number from the first
- Supports decimal numbers
- Instant result display

#### ✅ Multiplication
- Multiply two numbers
- Supports decimal numbers
- Instant result display

#### ✅ Division
- Divide the first number by the second
- Error handling for division by zero
- Error handling for indeterminate form (0/0)
- Supports decimal numbers

### 🔢 Advanced Operations

#### ✅ Exponentiation
- Raise the first number to the power of the second number
- Error handling for indeterminate form (0^0)
- Supports decimal numbers and negative exponents

#### ✅ Root Extraction
- Calculate the nth root of a number
- Error handling for zeroth root
- Supports decimal numbers

### ⚠️ Error Handling

- ✅ **Division by Zero**: Shows error message when dividing by zero
- ✅ **Indeterminate Forms**: Handles 0/0 and 0^0 cases
- ✅ **Zeroth Root**: Prevents calculation of zeroth root
- ✅ **User-Friendly Messages**: Clear error messages for all edge cases

### 🧹 Utility Functions

- ✅ **Clear**: Clears all input fields and result
- ✅ **Decimal Support**: Full support for decimal numbers
- ✅ **Real-time Calculation**: Instant results

---

## 🛠️ Technologies

### Technologies Used

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=flat-square&logo=windows)
![C#](https://img.shields.io/badge/C%23-12.0-239120?style=flat-square&logo=c-sharp)

- **.NET 8.0**: Application framework
- **Windows Forms**: User interface technology
- **C# 12.0**: Programming language
- **Math Library**: Built-in mathematical functions

### Architecture

```
┌─────────────────┐
│  Windows Forms  │
│     (UI)        │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│  Math Library   │
│  (Operations)   │
└─────────────────┘
```

---

## 📦 Requirements

### System Requirements

- ✅ **Operating System**: Windows 10 or higher
- ✅ **.NET Runtime**: 8.0 or higher
- ✅ **RAM**: Minimum 512 MB
- ✅ **Disk Space**: Minimum 50 MB

### Development Environment

- ✅ **Visual Studio**: 2022 or higher
- ✅ **.NET 8.0 SDK**
- ✅ **Windows Forms Designer**

---

## 🚀 Installation

### 1️⃣ Download the Project

```bash
# Clone from GitHub
git clone https://github.com/Kaaner4mir/WindowsFormLabor.git

# Navigate to project directory
cd WindowsFormLabor/BasicCalculator
```

Or download as ZIP file and extract it.

### 2️⃣ Build and Run the Project

1. Open `BasicCalculator.sln` file in Visual Studio
2. Build the project from `Build > Build Solution` (Ctrl+Shift+B)
3. Run with `Debug > Start Debugging` (F5) or `Start Without Debugging` (Ctrl+F5)

### 3️⃣ First Use

- When the application opens, you'll see two input fields and operation buttons
- Enter numbers in the input fields
- Click the desired operation button
- View the result in the result field

---

## 📖 Usage Guide

### ➕ Addition

1. Enter the first number in **Number 1** field
2. Enter the second number in **Number 2** field
3. Click the **Add** button
4. View the result in the **Result** field

**Example**: 5 + 3 = 8

### ➖ Subtraction

1. Enter the first number in **Number 1** field
2. Enter the second number in **Number 2** field
3. Click the **Subtract** button
4. View the result in the **Result** field

**Example**: 10 - 4 = 6

### ✖️ Multiplication

1. Enter the first number in **Number 1** field
2. Enter the second number in **Number 2** field
3. Click the **Multiply** button
4. View the result in the **Result** field

**Example**: 6 × 7 = 42

### ➗ Division

1. Enter the first number in **Number 1** field
2. Enter the second number in **Number 2** field
3. Click the **Divide** button
4. View the result in the **Result** field

**Example**: 15 ÷ 3 = 5

> **⚠️ Note**: Division by zero will show an error message. The indeterminate form (0/0) is also handled.

### 🔢 Exponentiation

1. Enter the base number in **Number 1** field
2. Enter the exponent in **Number 2** field
3. Click the **Base** (Power) button
4. View the result in the **Result** field

**Example**: 2^3 = 8

> **⚠️ Note**: 0^0 is undefined and will show an error message.

### √ Root Extraction

1. Enter the number in **Number 1** field
2. Enter the root degree in **Number 2** field
3. Click the **Root** button
4. View the result in the **Result** field

**Example**: ∛8 = 2 (3rd root of 8)

> **⚠️ Note**: Zeroth root is undefined and will show an error message.

### 🧹 Clearing Fields

- Click the **Clear** button to clear all input fields and result
- Useful when starting a new calculation

---

## 📁 Project Structure

```
BasicCalculator/
│
├── 📄 Form1.cs                    # Main form logic and operations
├── 📄 Form1.Designer.cs          # Form design and UI components
├── 📄 Form1.resx                 # Form resource file
├── 📄 Program.cs                  # Application entry point
├── 📄 BasicCalculator.csproj     # Project file
│
├── 📁 Images/                     # Image files
│   └── 🖼️ WF.png                 # Windows Forms image
│
├── 📁 bin/                        # Compiled files
│   └── 📁 Debug/                  # Debug build outputs
│
└── 📁 obj/                        # Temporary build files
    └── 📁 Debug/                  # Debug obj files
```

### File Descriptions

| File | Description |
|------|-------------|
| `Form1.cs` | Main form class, all calculation logic is here |
| `Form1.Designer.cs` | Form design, UI controls |
| `Form1.resx` | Form resource file (icons, images) |
| `Program.cs` | Application entry point, Main method |
| `BasicCalculator.csproj` | Project file, references and settings |

---

## 🎨 Screenshots

### Main Form

When the application opens, you'll see a clean interface with two input fields, operation buttons, and a result field.

![Windows Forms Application](Images/WF.png)

### Features

- **Simple UI**: Clean and organized form structure
- **Color-Coded Buttons**: Easy-to-identify operation buttons
- **User-Friendly**: Intuitive interface for quick calculations
- **Error Messages**: Clear error messages for invalid operations

---

## 🔧 Development Notes

### Code Structure

#### Form1.cs
- **Variable Declaration**: Two double variables for number storage
- **Operation Methods**: Separate methods for each operation
- **Error Handling**: Try-catch logic for edge cases
- **Event Handlers**: Event handlers for button clicks

#### Important Methods

```csharp
// Addition
private void btnAdd_Click(object sender, EventArgs e)

// Subtraction
private void btnSubtract_Click(object sender, EventArgs e)

// Multiplication
private void btnMultiply_Click(object sender, EventArgs e)

// Division
private void btnDivide_Click(object sender, EventArgs e)

// Exponentiation
private void btnBase_Click(object sender, EventArgs e)

// Root extraction
private void btnRoot_Click(object sender, EventArgs e)

// Clear fields
private void btnClear_Click(object sender, EventArgs e)
```

### Error Handling

- ✅ **Division by Zero**: Checks if divisor is zero before division
- ✅ **Indeterminate Forms**: Handles 0/0 and 0^0 cases
- ✅ **Zeroth Root**: Prevents calculation of zeroth root
- ✅ **User Feedback**: Shows MessageBox with clear error messages

### Mathematical Operations

- ✅ **Math.Pow()**: Used for exponentiation and root extraction
- ✅ **Double Precision**: Uses double data type for decimal support
- ✅ **String Conversion**: Converts numbers to strings for display

### Improvement Suggestions

- 🔄 Input validation can be added (check for non-numeric input)
- 🔄 Try-catch blocks can be added for conversion errors
- 🔄 History of calculations can be added
- 🔄 Keyboard shortcuts can be added
- 🔄 Scientific notation support can be added
- 🔄 Memory functions (M+, M-, MR, MC) can be added
- 🔄 Percentage calculations can be added
- 🔄 More advanced mathematical functions can be added

---

## 🤝 Contributing

We welcome your contributions! To help improve this project:

### How Can You Contribute?

1. ⭐ **Star the Project**: If you liked the project, don't forget to star it!
2. 🐛 **Report Bugs**: If you found a bug, open an Issue
3. 💡 **Suggest Features**: Open an Issue for new features
4. 🔧 **Code Contribution**: Submit a Pull Request

### Steps to Submit a Pull Request

1. Fork this repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Create a Pull Request

### Contribution Guidelines

- Follow code standards
- Add comments
- Test your code
- Update README if necessary

---

## 📞 Contact

For questions, suggestions, or bug reports:

- 📧 **GitHub Issues**: [Issues Page](https://github.com/Kaaner4mir/WindowsFormLabor/issues)
- 👤 **Developer**: Kaaner4mir
- 🔗 **Repository**: [WindowsFormLabor](https://github.com/Kaaner4mir/WindowsFormLabor)

---

## ⭐ Don't Forget to Star!

If you liked this project, don't forget to star it! ⭐

[![GitHub stars](https://img.shields.io/github/stars/Kaaner4mir/WindowsFormLabor.svg?style=social&label=Star)](https://github.com/Kaaner4mir/WindowsFormLabor)

---

## 🙏 Thanks

Thank you for using this project!

- 🧮 Developed to make calculations easier
- 🎓 Can be used for educational purposes
- 💻 Open source for learning and development

---

## 📌 Important Notes

> **⚠️ Production Use**: This application is developed for educational purposes. It is recommended to add input validation and error handling improvements before using it in a production environment.

> **💡 Tips**: 
> - Add input validation for non-numeric values
> - Add try-catch blocks for conversion errors
> - Consider adding calculation history
> - Add keyboard shortcuts for better UX

---

<div align="center">

**⭐ If you liked this project, don't forget to star it! ⭐**

Made with ❤️ by [Kaaner4mir](https://github.com/Kaaner4mir)

*Last Updated: 2025*

</div>

