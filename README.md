# LinkHub Bookmark

LinkHub Bookmark is a Blazor Server web application for managing personal bookmarks with user authentication. Users can register, log in, and organize their bookmarks by categories. The app supports adding, searching, filtering, and deleting bookmarks, and each user's data is kept private.

## Features

- User registration and login (ASP.NET Core Identity)
- Add, edit, and delete bookmarks
- Organize bookmarks by custom categories
- Search and filter bookmarks by title and category
- SQLite database for persistent storage (ongoing...)

## Tech Stack

- ASP.NET Core Blazor Server
- ASP.NET Core Identity (authentication & authorization)
- Entity Framework Core with SQLite

## Getting Started

1. **Install dependencies:**
   - [.NET 8 SDK or later](https://dotnet.microsoft.com/download)
2. **Apply database migrations:**
   ```sh
   dotnet ef database update
   ```
3. **Run the app:**
   ```sh
   dotnet run
   ```
4. Open your browser at [https://localhost:****] (the URL shown in the terminal).

## Project Structure

- `Pages/` - Main Blazor pages and components
- `Areas/Identity/` - Identity UI for authentication
- `Data/` - ApplicationDbContext and EF Core setup
- `LinkItem.cs` - Model for bookmarks

## License

MIT License
