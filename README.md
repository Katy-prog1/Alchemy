# Alchemy

**Description**

Alchemy is a Windows Forms application written in C#, where the player combines basic elements (Air, Water, Earth, Fire) to discover new ones. All combinations are stored in a database, and game results and discovered combinations can be saved and viewed.

**Features**

* Drag-and-drop elements to combine them.
* Display the count of discovered elements.
* Save player results (number of discovered elements) to the database.
* View all possible recipes (each recipe is a combination of two elements).
* View the leaderboard of all players' scores.

**Requirements**

* Windows 10 or 11
* .NET Framework 4.7.2 or later
* SQL Server (or LocalDB) with a database named **AlchemyDB** and tables `Elements`, `Combinations`, and `Scores`

**Installation and Setup**

1. Clone the repository:

   ```bash
   git clone https://github.com/Katy-prog1/Alchemy.git
   ```
2. Open the solution file `Alchemy.sln` in Visual Studio.
3. Update the connection string in **Form1.cs** and **Game.cs** if necessary:

   ```csharp
   private string connectionString = "Server=YOUR_SERVER;Database=AlchemyDB;Integrated Security=True;";
   ```
4. Build and run the project in Visual Studio.

**Usage**

1. Click **Start** on the main form to begin the game.
2. Drag one element onto another to create new elements.
3. Enter your name and click **Save Score** to save your results.
4. Click **View Recipes** to browse all combinations.
5. Click **View Scores** to view the saved scores leaderboard.

**Project Structure**

* `Alchemy.sln` — Visual Studio solution file.
* `/Alchemy` — project source code:

  * `Form1.cs` / `Form1.Designer.cs` — main menu form.
  * `Game.cs` / `Game.Designer.cs` — game logic and element combination.
  * `ViewRecipes.cs` / `ViewRecipes.Designer.cs` — recipes viewing form.
  * `ViewScores.cs` / `ViewScores.Designer.cs` — scores viewing form.
  * `Program.cs` — application entry point.

**Author**

Katya Polunin
