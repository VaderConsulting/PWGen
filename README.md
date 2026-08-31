# PWGen

VS 2013 VB.NET WinForms password generator that builds random passwords and spells each character for reading aloud. The main form (caption Password Generator) sets length (3-128), how many passwords to create (1-5000), and a Strong checkbox that includes symbols. Create fills a Courier New list of each password plus its NATO-style spelling and copies the list to the clipboard. A later PasswordVB class library ports the same GeneratePassword / SpeltOutPassword / FixedSizeQueue logic; the WinForms project still references an external C# Password library that is not in this folder.

**Source last updated:** 2014-10-17  
**Language:** VB.NET  
**Target:** .NET 3.5 (PWGen) / .NET 4.5 (PasswordVB)  
**Output:** WinForms exe + class library

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `PWGen` | VB.NET | WinForms exe (.NET 3.5) | Password Generator form: length, count, Strong/symbols, clipboard copy |
| `PasswordVB` | VB.NET | Class library (.NET 4.5) | GeneratePassword, NATO-style SpeltOutPassword, FixedSizeQueue |
| `Password` (external) | C# | Class library | Referenced from `..\Clients\DTF\T2Import\Password` - not in this folder |

## How to open

Open `PWGen.sln` in Visual Studio Express 2013 for Windows Desktop (or later). The solution also expects the missing C# `Password` project; use a built `Password.dll` next to the exe, or retarget PWGen to `PasswordVB`, before a clean rebuild.

## Attribution and provenance

From Dave Robinson's Historical Dev archive (OneDrive folder `PWGen`). PWGen assembly metadata: title/product `PWGen`, company Vader Consulting, copyright © Vader Consulting 2013. PasswordVB still has Visual Studio template defaults (Microsoft 2014). No third-party packages in the tree.

## License

MIT License. Copyright (c) 2026 VaderConsulting.
