# Assignment 03 (Week 4)

A simple, interactive menu from an internet source.

![](Screenshot.gif)

## Universal Acceptance Criteria  

This represents acceptance criteria that is true irrespective of assignment criteria.

(_This does not change from week to week_)

1. You **must understand** every single line of your solution.
2. Your code **must compile and run** without errors.
3. You **must turn in your repository URL** in Brightspace.

## Assignment 

This represents acceptance criteria necessary for assignment completion.

> **Regarding the API.** This is the URL to retrieve internet information: https://cis-230-sp25.azurewebsites.net/api/stringarray This has already been integrated in the `Client.Library` for you (by me) but I encourage you to look at the code as this is our first time to use internet information and our first time to deserialize information. Getting information from the internet is an incredibly common step in most applications; hopefully, this will reinforce how most complex tasks have been makde quite simple. In future assignments, you'll write this code yourself.

1. Ensure the project structure detailed below this list. 
2. Ensure the application never exist, "Press any key to continue..." restarts.
3. Show `Api.GetStringArrayAsync()` results as a numbered list/menu.
4. Listen for and support `Up` and `Down` keys to change highlight.
5. Listen for an support `Enter` to select and display the chosen item (with a border).
6. Use `Screen.Print()` and `Screen.SurroundWithBorder()` I provided in `Client.Library`.

## Bonus Acceptance Criteria  

This represents optional acceptance criteria available for additional learning and bonus.

1. Add "Loading..." when fetching from the API sournce. 
2. Handle `Escape` key to exit the list and fetch a new one. 
3. Support menu wrapping - pressing `Down` on the last menu item highlights the first.
4. Support menu wrapping - pressing `Up` on the first menu item highlights the last.

# Setup

> **Existing code** You will notice that the repository already comes with the `Client.Library` project. Because of this, you do not need to create it. However, you will need to add a project reference to it from the `Client` project you create.

1. **Clone Your Repository**
1. **Configure Debugging**

   - Open Settings (`Ctrl+,`) and search for `csharp.debug.console`.
   - Set its value to `externalTerminal`.

1. **Create Solution Structure**

It's up to you if you use the `dotnet` commands in the terminal of if you create the solution in the VS Code UI. Note that `gitignore` and `editorconfig` files can only be created using the `dotnet` commands in the terminal - there is, currently, no UI equivelent. 

```text
Assignment03.sln
├── .gitignore
├── .editorconfig
├── Client
│   ├── Client.csproj
│   ├── Program.cs (This week, all of your code will be written here.)
│   └── References: Client.Library
└── Client.Library
    ├── Client.Library.csproj
    ├── Screen.cs (I provided this; it holds console methods like: Print(), SurroundWithBorder(), and Listen())
    └── Api.cs (I provided this; async methods like: GetStringArrayAsync())
```

### Now you can do your assignment

 * Read the *Acceptance Criteria*!
 * Keep committing your changes with git.
 * Remember to push your final work!
 * Turn in the URL to your repository.
