# Simple Library Database (Visual Studio + SSMS)

University desktop app for a small library: members, books, authors, publishers, borrowings, and returns. The UI is a Windows Forms app in C#; data lives in a SQL Server database managed with SQL Server Management Studio (SSMS).

## Features

The main window opens six management screens:

| Screen | What you can do |
|--------|-----------------|
| **Members** | Add, edit, delete, and search members (name, email, address, admin vs member) |
| **Books** | Add, edit, delete, and search books by ISBN or title; set publisher, availability, and authors |
| **Authors** | Add, edit, delete, and search authors (name, biography) |
| **Publishers** | Add, edit, delete, and search publishers (name, website, description) |
| **Borrowings** | Check out a book to a member with borrow and due dates; marks the book unavailable |
| **Returns** | Record a return against a borrowing; late returns are charged **$2 per day** past the due date |

Each screen uses a data grid plus search-as-you-type. Borrowing a book sets `Available` to 0; deleting a borrowing sets it back to 1.

## Database

SQL Server catalog: `Library`. Tables used by the app:

| Table | Role |
|-------|------|
| `Member` | Library members (`Member_ID`, `name`, `email`, `Adreess`, `Is_Admin`) |
| `Book` | Catalog (`ISBN`, title, publisher, availability) |
| `Authors` | Author records |
| `Publisher` | Publisher records |
| `Author_Book` | Many-to-many link between authors and books |
| `Borrowing` | Checkouts (`Member_ID`, `ISBN`, borrow date, due date) |
| `Return` | Returns, including a calculated late-fee amount |

The typed dataset and TableAdapters live in `Library/Library2/Library2/Database.xsd`.

## Tech stack

| Layer | Tool |
|-------|------|
| Language | C# |
| UI | Windows Forms (.NET Framework 4.7.2) |
| IDE | Visual Studio |
| Database | SQL Server (Express was used during development) |
| Access | ADO.NET TableAdapters / typed DataSet |

## Project layout

```
Library/Library2/
├─ Library2.sln
└─ Library2/
   ├─ Program.cs              # app entry
   ├─ Main.cs                 # home menu
   ├─ Members.cs
   ├─ Books.cs
   ├─ Authors.cs
   ├─ Publishers.cs
   ├─ Borrowings.cs
   ├─ Returns.cs
   ├─ Database.xsd            # SQL Server DataSet
   └─ App.config              # connection string
```

## How to run

1. Install **Visual Studio** with the .NET desktop development workload, plus **SQL Server** and **SSMS**.
2. In SSMS, create a database named `Library` and add the tables listed above (or restore from your existing schema).
3. Open `Library/Library2/Library2.sln` in Visual Studio.
4. Update the connection string in `Library/Library2/Library2/App.config` so it matches your SQL Server instance:

```xml
<connectionStrings>
  <add name="Library2.Properties.Settings.LibraryConnectionString"
       connectionString="Data Source=YOUR_SERVER\INSTANCE;Initial Catalog=Library;Integrated Security=True;Encrypt=False"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

The checked-in string points at `ABOHAMEDPC\DBEXPRESS`. Replace that with your machine name and instance.

5. Build and run (`F5`). The main form should open with the six management buttons.

## Notes

- This was a university assignment, so the schema and UI are kept simple (CRUD forms over related tables).
- Column name `Adreess` in `Member` is spelled as stored in the original database.
- Late-fee rule is hardcoded in `Returns.CalculatePenalty`: `$2 × max(0, days late)`.
