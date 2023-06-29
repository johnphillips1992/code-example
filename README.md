How to set up application
- Create Microsoft SQL Database running locally named LexingtonPreschoolAcademy
- Open the LexingtonPreschoolAcademy.sln in Visual Studio 2022
- Update connection string in appsettings.json, you can get the connection string from the sql server object exporer
- To create tables and stored procedures, in Package Manager Console run: Update-Database
- To seed courses and students, in Developer PowerShell run: dotnet run seed
- Now run the application from visual studio to start the development server
- In the terminal navigate to the Vue Folder and install serve with node: npm install -g serve
- In that same terminal run: serve -s LexingtonPreschoolAcademy
- Open browser to localhost:3000

- If you are having issues check that the .NET application is running on port 5211 and the vue application is running on port 3000
- If the .NET application port has changed you will need to update the main.js file with the correct api URLs