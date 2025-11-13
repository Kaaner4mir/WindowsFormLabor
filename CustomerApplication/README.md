# 👥 Customer Application

<div align="center">

![Windows Forms](Images/WF.png)
![SQL Server](Images/DB.png)

**A modern and user-friendly customer management system**

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=for-the-badge&logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927?style=for-the-badge&logo=microsoft-sql-server)](https://www.microsoft.com/sql-server)
[![C#](https://img.shields.io/badge/C%23-8.0-239120?style=for-the-badge&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

</div>

---

## 📋 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Technologies](#-technologies)
- [Requirements](#-requirements)
- [Installation](#-installation)
- [Database Structure](#-database-structure)
- [Usage Guide](#-usage-guide)
- [Project Structure](#-project-structure)
- [Screenshots](#-screenshots)
- [Development Notes](#-development-notes)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 About the Project

**Customer Application** is a professional customer management system developed using Windows Forms technology. This application allows you to perform basic CRUD (Create, Read, Update, Delete) operations such as registering, updating, deleting, and listing customers.

The application works integrated with SQL Server database to securely store and manage all customer information. Thanks to its modern and user-friendly interface, it can be easily used.

### 🎨 Key Features

- ✨ **Modern Interface**: Colorful buttons and organized form structure
- ⏰ **Real-time Date/Time**: Live date and time display
- 📊 **DataGridView Integration**: Display all customers in table format
- 🔒 **Secure Data Management**: Secure data storage with SQL Server
- ⚡ **Fast and Efficient**: Optimized database queries

---

## ✨ Features

### 👤 Customer Management

#### ✅ Add Customer
- Add new customers to the database
- Save all customer information (TCKN, First Name, Last Name, City, Marital Status, Occupation)
- Automatic ID generation
- Success message display

#### ✅ Update Customer
- Edit existing customer information
- Load selected customer information from DataGridView to form fields
- Save updated information to database

#### ✅ Delete Customer
- Delete customers from database
- Secure deletion with ID validation
- Deletion confirmation message

#### ✅ List Customers
- Display all customers in DataGridView
- Automatic column expansion
- Read-only mode (prevents accidental editing)

#### ✅ View Details
- Load selected customer details from table to form fields
- One-click access to customer information

### ⏰ Time Features

- ✅ **Real-time Date**: Live date display (dd.MM.yyyy format)
- ✅ **Real-time Time**: Live time display (HH:mm:ss format)
- ✅ **Timer Control**: Automatic update mechanism

### 📊 Data Fields

The following information is stored for each customer:

| Field | Description | Type |
|-------|-------------|------|
| **ID** | Automatically generated unique identifier | INT (Identity) |
| **TCKN** | Turkish Republic Identity Number | NVARCHAR(11) |
| **FirstName** | Customer first name | NVARCHAR(50) |
| **LastName** | Customer last name | NVARCHAR(50) |
| **City** | City | NVARCHAR(50) |
| **MaritalStatus** | Marital status (Married/Single) | BIT |
| **Occupation** | Occupation | NVARCHAR(100) |

---

## 🛠️ Technologies

### Technologies Used

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D4?style=flat-square&logo=windows)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927?style=flat-square&logo=microsoft-sql-server)
![C#](https://img.shields.io/badge/C%23-8.0-239120?style=flat-square&logo=c-sharp)
![ADO.NET](https://img.shields.io/badge/ADO.NET-Data%20Access-512BD4?style=flat-square)

- **.NET Framework 4.7.2**: Application framework
- **Windows Forms**: User interface technology
- **SQL Server Express**: Database management system
- **ADO.NET**: Database access technology
- **C#**: Programming language
- **DataGridView**: Data display control
- **SqlDataAdapter**: Data adapter
- **Timer**: Timer control

### Architecture

```
┌─────────────────┐
│  Windows Forms  │
│     (UI)        │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│   ADO.NET       │
│  (Data Access)  │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│  SQL Server     │
│   Database      │
└─────────────────┘
```

---

## 📦 Requirements

### System Requirements

- ✅ **Operating System**: Windows 7 or higher
- ✅ **.NET Framework**: 4.7.2 or higher
- ✅ **SQL Server**: Express Edition or higher
- ✅ **RAM**: Minimum 2 GB (4 GB recommended)
- ✅ **Disk Space**: Minimum 500 MB

### Development Environment

- ✅ **Visual Studio**: 2017 or higher
- ✅ **SQL Server Management Studio (SSMS)**: For database management
- ✅ **.NET Framework 4.7.2 SDK**

### Database Requirements

- ✅ SQL Server Express 2014 or higher
- ✅ Windows Authentication or SQL Server Authentication
- ✅ Database creation permissions

---

## 🚀 Installation

### 1️⃣ Download the Project

```bash
# Clone from GitHub
git clone https://github.com/Kaaner4mir/WindowsFormLabor.git

# Navigate to project directory
cd WindowsFormLabor/CustomerApplication
```

Or download as ZIP file and extract it.

### 2️⃣ Create the Database

Open SQL Server Management Studio and run the following SQL script:

```sql
-- Create database
CREATE DATABASE CustomersDB;
GO

-- Use database
USE CustomersDB;
GO

-- Create Customers table
CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Tckn NVARCHAR(11),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    City NVARCHAR(50),
    MaritalStatus BIT DEFAULT 0,
    Occupation NVARCHAR(100)
);
GO

-- Insert sample data (optional)
INSERT INTO Customers (Tckn, FirstName, LastName, City, MaritalStatus, Occupation)
VALUES 
    ('12345678901', 'Ahmet', 'Yılmaz', 'İstanbul', 1, 'Mühendis'),
    ('23456789012', 'Ayşe', 'Demir', 'Ankara', 0, 'Öğretmen'),
    ('34567890123', 'Mehmet', 'Kaya', 'İzmir', 1, 'Doktor');
GO
```

![SQL File Structure](Images/SqlFileStructure.png)

### 3️⃣ Configure Connection String

Open `Form1.cs` file and update the connection string with your SQL Server information:

```csharp
// Edit the connection string on line 16
SqlConnection _connection = new SqlConnection(@"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=CustomersDB;Integrated Security=True;Encrypt=False");
```

**Important Notes:**

- Replace `YOUR_SERVER_NAME` with your computer name
- To find your SQL Server instance name:
  - Check the connection window in SQL Server Management Studio
  - Or run `hostname` command in Windows
- If using **Windows Authentication** (recommended):
  ```csharp
  @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=CustomersDB;Integrated Security=True;Encrypt=False"
  ```
- If using **SQL Server Authentication**:
  ```csharp
  @"Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=CustomersDB;User ID=your_username;Password=your_password;Encrypt=False"
  ```
- If using **LocalDB**:
  ```csharp
  @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CustomersDB;Integrated Security=True;Encrypt=False"
  ```

### 4️⃣ Build and Run the Project

1. Open `CustomerApplication.sln` file in Visual Studio
2. Build the project from `Build > Build Solution` (Ctrl+Shift+B)
3. Run with `Debug > Start Debugging` (F5) or `Start Without Debugging` (Ctrl+F5)

### 5️⃣ First Use

- When the application opens, all customers in the database are automatically listed
- To add a new customer, fill in the form fields and click the **Save** button
- To edit an existing customer, select it from the table and click the **Update** button
- Date and time are automatically updated

---

## 💾 Database Structure

### Customers Table

![Database Structure](Images/DB.png)

| Column Name | Data Type | Nullable | Description |
|-------------|-----------|----------|-------------|
| **Id** | INT | ❌ | Primary Key, Identity (Auto-increment) |
| **Tckn** | NVARCHAR(11) | ✅ | Turkish Republic Identity Number |
| **FirstName** | NVARCHAR(50) | ❌ | Customer first name (Required) |
| **LastName** | NVARCHAR(50) | ❌ | Customer last name (Required) |
| **City** | NVARCHAR(50) | ✅ | City |
| **MaritalStatus** | BIT | ✅ | Marital status (0=Single, 1=Married) |
| **Occupation** | NVARCHAR(100) | ✅ | Occupation |

### Relationships

- **Primary Key**: `Id` (Identity, auto-increment)
- **Index**: Clustered index on `Id`

### Data Type Descriptions

- **INT**: For integer values
- **NVARCHAR**: For Unicode character strings (supports Turkish characters)
- **BIT**: For boolean values (0 or 1)
- **IDENTITY(1,1)**: Auto-increment number (starts at 1, increments by 1)

---

## 📖 Usage Guide

### 🆕 Adding a New Customer

1. Fill in the form fields:
   - **TCKN**: Turkish Republic Identity Number
   - **FirstName**: Customer first name (required)
   - **LastName**: Customer last name (required)
   - **City**: City
   - **MaritalStatus**: Marital status (Married/Single radio buttons)
   - **Occupation**: Occupation
2. Click the **Save** (Green) button
3. View the success message
4. See the newly added customer in the customer list

> **Note**: The ID field is automatically generated and cannot be edited.

### ✏️ Updating a Customer

1. Click on the customer you want to update from DataGridView
2. Form fields are automatically filled
3. Edit the desired fields
4. Click the **Update** (Yellow) button
5. View the success message
6. See the updated information in the list

> **Note**: Update cannot be performed if the ID field is empty.

### 🗑️ Deleting a Customer

1. Click on the customer you want to delete from DataGridView
2. Customer information is loaded into form fields
3. Click the **Delete** (Red) button
4. View the confirmation message
5. Customer is removed from the list

> **⚠️ Warning**: Deletion cannot be undone!

### 📋 Listing Customers

1. Click the **List** button
2. All customers are displayed in DataGridView
3. Click on a row from the list to view customer details

### 🧹 Clearing the Form

- Click the **Clear** (Blue) button to clear all form fields
- Clearing the form is useful when adding a new customer

### 📊 Data Display

- All customers are displayed in table format in DataGridView
- Columns are automatically expanded
- The table is in read-only mode (direct editing is not possible)
- Click on a row to view customer details

### ⏰ Date and Time

- When the application opens, date and time are automatically displayed
- Date and time are updated in real-time
- Date format: **dd.MM.yyyy** (e.g., 15.01.2025)
- Time format: **HH:mm:ss** (e.g., 14:30:45)

---

## 📁 Project Structure

```
CustomerApplication/
│
├── 📄 Form1.cs                    # Main form logic and CRUD operations
├── 📄 Form1.Designer.cs          # Form design and UI components
├── 📄 Form1.resx                 # Form resource file
├── 📄 Program.cs                  # Application entry point
├── 📄 App.config                  # Application configuration file
├── 📄 CustomerApplication.csproj # Project file
│
├── 📁 Images/                     # Image files
│   ├── 🖼️ DB.png                 # Database image
│   ├── 🖼️ SqlFileStructure.png   # SQL structure image
│   └── 🖼️ WF.png                 # Windows Forms image
│
├── 📁 Properties/                 # Project properties
│   ├── 📄 AssemblyInfo.cs        # Assembly information
│   ├── 📄 Resources.Designer.cs  # Resource file designer
│   ├── 📄 Resources.resx         # Resource file
│   ├── 📄 Settings.Designer.cs   # Settings designer
│   └── 📄 Settings.settings      # Application settings
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
| `Form1.cs` | Main form class, all business logic is here |
| `Form1.Designer.cs` | Form design, UI controls |
| `Form1.resx` | Form resource file (icons, images) |
| `Program.cs` | Application entry point, Main method |
| `App.config` | Application configuration settings |
| `CustomerApplication.csproj` | Project file, references and settings |

---

## 🎨 Screenshots

### Main Form

When the application opens, all customers are listed in DataGridView and form fields are ready to use. Date and time are displayed in real-time.

![Windows Forms Application](Images/WF.png)

### Features

- **Modern UI**: Colorful buttons and organized form structure
- **Responsive Design**: Automatic sizing
- **User-Friendly**: Easy-to-use interface
- **Color-Coded Buttons**: 
  - 🟢 Green: Save
  - 🟡 Yellow: Update
  - 🔴 Red: Delete
  - 🔵 Blue: Clear
  - ⚪ White: List
- **Real-time Date/Time**: Live date and time display

### Database Structure

![Database Structure](Images/DB.png)

### SQL Structure

![SQL File Structure](Images/SqlFileStructure.png)

---

## 🔧 Development Notes

### Code Structure

#### Form1.cs
- **Connection Management**: Connection is opened and closed for each operation
- **CRUD Operations**: Create, Read, Update, Delete operations
- **Data Binding**: DataGridView is bound with DataTable
- **Event Handlers**: Event handlers for button clicks and cell selections
- **Timer Control**: Real-time date/time update

#### Important Methods

```csharp
// List customers
void List()

// Clear form fields
void Clear()

// Update date and time
void UpdateDateAndTime()

// Add customer
private void btnSave_Click(object sender, EventArgs e)

// Update customer
private void btnUpdate_Click(object sender, EventArgs e)

// Delete customer
private void btnDelete_Click(object sender, EventArgs e)

// List customers
private void btnList_Click(object sender, EventArgs e)

// DataGridView cell click
private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)

// Timer tick event
private void timer1_Tick(object sender, EventArgs e)
```

### Security

- ✅ **Parameterized Queries**: Parameterized queries are used for SQL injection protection
- ✅ **Data Validation**: Secure deletion and update with ID validation
- ✅ **Read-Only Grid**: DataGridView is in read-only mode

### Performance

- ✅ **Efficient Queries**: Optimized SQL queries
- ✅ **DataTable Caching**: Data is cached in DataTable
- ✅ **Connection Management**: Connection is opened and closed for each operation
- ✅ **Timer Optimization**: Low-frequency timer usage

### Improvement Suggestions

- 🔄 Connection string can be moved to `App.config` file
- 🔄 Error handling can be added with try-catch blocks
- 🔄 Data validation can be added (TCKN format validation, required field validation)
- 🔄 Repository pattern can be used
- 🔄 Unit tests can be written
- 🔄 Connection management can be improved with using statements
- 🔄 Async/await pattern can be used
- 🔄 ORMs like Entity Framework or Dapper can be used
- 🔄 TCKN validation algorithm can be added

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

- 👥 Developed to make customer management easier
- 🎓 Can be used for educational purposes
- 💻 Open source for learning and development

---

## 📌 Important Notes

> **⚠️ Production Use**: This application is developed for educational purposes. It is recommended to make security and performance improvements before using it in a production environment.

> **💡 Tips**: 
> - Store connection string securely
> - Take regular database backups
> - Add error handling
> - Add logging mechanism
> - Add TCKN validation algorithm

---

<div align="center">

**⭐ If you liked this project, don't forget to star it! ⭐**

Made with ❤️ by [Kaaner4mir](https://github.com/Kaaner4mir)

*Last Updated: 2025*

</div>
