# Project name: SudokuSolver

Sudoku Solver is a small website designed to display the Sudoku game.

**The project have two main functions:**

- The first function is a Sudoku Solver webpage that displays a 9x9 matrix where users can enter numbers between 1 and 9. The page includes a "Solve" button. When the button is clicked, the program automatically computes the missing numbers. If the Sudoku puzzle is unsolvable, the system displays an error message.

- The second function provides a webpage where users can check the result after clicking on the "Solve" button, displayed in a DxDataGrid."

The solution has three parts:

- **Library**
  + **SudokuSolver.Core**: This class library project provides Enums, Const, Helper Methods, etc.
  + **SudokuSolver.DataAccess**: This class library project connects to the DB using Code First to generate the DB.
  + **SudokuSolver.Model**: This class library project stores Entities.
  + **SudokuSolver.UserCases**: This class library project provides business logic. All actions to get or update data must contact this class.

- **SudokuSolver**: This is the end-user website application. It has two pages to display Sudoku Solver and Solution Result.

- **SudokuSolverApi**: This is the API endpoint that the website can contact to get or update data in the Database.


# Prerequisites and Installing The Project:

Before beginning, make sure you meet the following requirements:

To set up the project, follow these steps:

Step 1: Clone the 'develop' branch to your local machine.

Step 2: Open the project in Visual Studio 2022.

Step 3: Open the file 'appsettings.json' in the SudokuSolverApi project and change the connection string to match your local database." 

Ex: 
![image](https://user-images.githubusercontent.com/11987904/225954679-3dedbb0b-447a-46db-b74c-90740f9fdc91.png)


Step 4: clean and rebuild the solution.

Step 5: In Visual Studio, go to Tools -> NuGet Package Manager -> Package Manager Console. Then type 'update-database' and press Enter. Make sure to choose 'Library\SudokuSolverApi' as the default project. See the image below for more details.


![image](https://user-images.githubusercontent.com/11987904/225974915-8e553870-bbee-4977-a0a7-9dcf7cad286a.png)


Step 6: Click F5 to start project.


# Using The Sudoku Solver:

We have two main pages:

**SudokuSolver Page**: When the website runs successfully, the homepage displays a 9x9 matrix where users can enter numbers between 1 and 9. When the 'Solve' button is clicked, the program automatically computes the missing numbers. The system calls the API to save the Solution Result and displays a message.

**Solution Result Page**: Click on the 'Solution Result' on the header bar to go to the Solution Result page. On this page, you can see all the results in a DxDataGrid.

# Contributing to SudokuSolver project

To contribute to SudokuSolver project, follow these steps:

Step 1: Fork this repository. 

Step 2: Create a branch: git checkout -b <branch_name>. 

Step 3: Make your changes and commit them: git commit -m '<commit_message>' 

Step 4: Push to the original branch: git push origin <project_name>/ 

Step 5: Create the pull request.


Happy Coding !!
