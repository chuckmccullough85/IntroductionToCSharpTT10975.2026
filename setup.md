# Development Environment Setup

This guide provides instructions for setting up your C# development environment using either **Visual Studio** or **VS Code**. Choose the option that best fits your needs and operating system.

---

## Prerequisites

Before proceeding, ensure you have:

- **Windows 10/11**, **macOS 10.15+**, or **Linux** (Ubuntu 18.04+, Fedora, Debian, etc.)
- Administrator or sudo access to install software
- Internet connection for downloading tools
- At least 2 GB of free disk space (more for Visual Studio)

---

## Option 1: Visual Studio Community (Windows Only)

### Supported Platforms
- **Windows 10/11** (Home, Pro, Enterprise editions)

### Prerequisites
- Windows 10 version 1909+ or Windows 11
- 4 GB RAM minimum (8 GB recommended)
- 6-8 GB free disk space

### Installation

#### Step 1: Download Visual Studio
1. Visit [visualstudio.microsoft.com](https://visualstudio.microsoft.com/)
2. Click **"Download Visual Studio"** → Select **Community** (free option)
3. Save the `VisualStudioSetup.exe` file

#### Step 2: Run the Installer
1. Double-click `VisualStudioSetup.exe`
2. Select **"Continue"** to proceed with installation
3. On the workload selection screen, check:
   - ✅ **".NET desktop development"** (essential for C#)
   - ✅ **"ASP.NET and web development"** (optional, for future web projects)
   - ✅ **".NET Framework development tools"** (optional)
4. Click **"Install"** to begin installation (may take 10-30 minutes)
5. Restart your computer if prompted

#### Step 3: Create a Microsoft Account (Optional but Recommended)
1. Launch Visual Studio after installation
2. Sign in with a Microsoft account when prompted
3. Or select "Create one!" if you don't have an account

### Verification

Open **Command Prompt** or **PowerShell** and run:

```powershell
dotnet --version
```

Expected output: `8.0.x` or higher (where x is any number)

Also verify the C# compiler:
```powershell
csc --version
```

### Uninstall Instructions

#### Via Control Panel
1. Press `Win + X` → Select **"Apps and Features"**
2. Search for **"Visual Studio"**
3. Click it and select **"Uninstall"**
4. Follow the uninstall wizard

#### Via Programs and Features
1. Press `Win + R` → Type `appwiz.cpl` → Press **Enter**
2. Find **"Visual Studio"** → Right-click → **"Uninstall"**
3. Follow the uninstall wizard

#### Complete Removal
To remove all Visual Studio components:
1. Download the [Visual Studio Installer](https://visualstudio.microsoft.com/downloads/)
2. Run the installer and select **"Modify"** for your installation
3. Click **"Uninstall"** at the bottom

---

## Option 2: VS Code (Windows, macOS, Linux)

### Supported Platforms
- **Windows 7/8/10/11** (32-bit or 64-bit)
- **macOS 10.15+** (Intel or Apple Silicon)
- **Linux**: Ubuntu, Debian, Fedora, Arch, RHEL, CentOS, openSUSE, SLE, and others

### Prerequisites
- 256 MB RAM minimum (1 GB recommended)
- 500 MB free disk space
- .NET SDK 8.0 or later (installed separately)

### Installation

#### Step 1: Install .NET SDK

**Windows (Command Prompt/PowerShell):**
```powershell
# Visit https://dotnet.microsoft.com/download
# Download .NET 8.0 SDK installer for Windows
# Run the installer and follow the prompts
```

**macOS (Terminal):**
```bash
# Using Homebrew (recommended)
brew install dotnet-sdk

# Or download from https://dotnet.microsoft.com/download
# and run the .pkg installer
```

**Linux (Ubuntu/Debian):**
```bash
# Add Microsoft package repository
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --version latest

# Or using apt (Ubuntu 22.04+)
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
```

**Linux (Fedora/RHEL):**
```bash
sudo dnf install dotnet-sdk-8.0
```

#### Step 2: Install VS Code

**Windows:**
1. Visit [code.visualstudio.com](https://code.visualstudio.com/)
2. Click **"Download for Windows"** (installer or portable)
3. Run the installer and follow the prompts
4. Restart your computer if prompted

**macOS:**
1. Visit [code.visualstudio.com](https://code.visualstudio.com/)
2. Click **"Download for Mac"** (Intel or Apple Silicon)
3. Open the `.zip` file and drag **Visual Studio Code** to **Applications**
4. Launch from Spotlight or Applications folder

**Linux:**

```bash
# Ubuntu/Debian
sudo apt-get update
sudo apt-get install code

# Fedora/RHEL
sudo dnf install code

# Arch
sudo pacman -S code
```

#### Step 3: Install C# Extension

1. Open **VS Code**
2. Click the **Extensions** icon on the left sidebar (or press `Ctrl+Shift+X` / `Cmd+Shift+X`)
3. Search for **"C# Dev Kit"**
4. Click **"Install"** on the Microsoft C# extension
5. Also install **"C# Extensions"** by kreativ (optional, but helpful)
6. Restart VS Code when prompted

### Verification

Open **Terminal/Command Prompt** and run:

```bash
dotnet --version
code --version
```

Both commands should return version numbers without errors.

### Uninstall Instructions

**Windows:**
1. Press `Win + X` → **"Apps and Features"**
2. Search for **"Visual Studio Code"**
3. Click it and select **"Uninstall"**

**macOS:**
1. Open **Finder** → **Applications**
2. Drag **Visual Studio Code** to **Trash**
3. Empty Trash

**Linux:**
```bash
# Ubuntu/Debian
sudo apt-get remove code

# Fedora/RHEL
sudo dnf remove code

# Arch
sudo pacman -R code
```

---

## Getting Started After Setup

### Create Your First Project

**Visual Studio (Windows/Mac):**
1. Open Visual Studio
2. Click **"Create a new project"**
3. Search for **"Console App (.NET)"**
4. Follow the wizard to create your first C# project

**VS Code:**
1. Open a terminal and navigate to your desired folder
2. Run:
   ```bash
   dotnet new console -n MyFirstApp
   cd MyFirstApp
   code .
   ```

### Verify Installation

Create a test file `Program.cs`:

```csharp
Console.WriteLine("Hello, C#!");
```

Run it:
```bash
dotnet run
```

Expected output: `Hello, C#!`

---

## Troubleshooting

### Issue: `dotnet` command not found

**Solution (Windows):**
- Restart PowerShell/Command Prompt
- Add .NET to PATH manually:
  - Press `Win + X` → **"System"**
  - Click **"Advanced system settings"**
  - Click **"Environment Variables"**
  - Add `C:\Program Files\dotnet` to PATH

**Solution (macOS/Linux):**
```bash
# Add to ~/.zshrc or ~/.bashrc
export PATH="$PATH:/usr/local/share/dotnet"
source ~/.zshrc  # or ~/.bashrc
```

### Issue: C# extension not working in VS Code

1. Reload VS Code window: `Ctrl+Shift+P` / `Cmd+Shift+P` → "Developer: Reload Window"
2. Ensure .NET SDK is installed: `dotnet --version`
3. Install additional debugging tools:
   ```bash
   dotnet tool install -g csharpier
   ```

### Issue: Visual Studio installation fails

1. Disconnect antivirus/firewall temporarily
2. Ensure you have Administrator privileges
3. Run the installer in **Safe Mode with Networking**
4. Try the **"Repair"** option in Add/Remove Programs

---

## Comparison: Visual Studio vs VS Code

| Feature | Visual Studio | VS Code |
|---------|---------------|---------|
| **Cost** | Free (Community), Paid (Pro/Enterprise) | Free |
| **Platform** | Windows, macOS | Windows, macOS, Linux |
| **Memory Usage** | Higher (~8GB) | Lower (~200MB) |
| **Setup Time** | 20-30 minutes | 5-10 minutes |
| **Built-in Tools** | Debugger, Profiler, Designer | Extensions needed |
| **Learning Curve** | Steeper (more features) | Gentler (lightweight) |
| **Project Size** | Best for large projects | Good for all sizes |

---

## Additional Resources

- [Microsoft Learn - C# Fundamentals](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)
- [Visual Studio Documentation](https://learn.microsoft.com/en-us/visualstudio/)
- [VS Code C# Extension Guide](https://github.com/OmniSharp/omnisharp-vscode)

---

## Next Steps

After completing setup:
1. Review the course [Readme.md](./Readme.md)
2. Start with the **VisualStudio** lab in `labs/VisualStudio/Readme.md`
3. Follow the lab sequence as outlined in the course materials

**Happy coding!** 🚀
