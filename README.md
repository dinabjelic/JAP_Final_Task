RecipeApp 

STARTING THE APPLICATION 

-You need to do some things listed below so you can start application 

-The first step you need to do is clone the githab repository. After you cloned the project do the rebuild of the whole solution in Visual studio. 
After that you need to do an update database to create all the necessary tables. To do that open .sln and in Package Manager Console choose as Default project 
RecipesApp.Database and type update-database -context RecipesDbContext. If you want to add logging, in Package Manager Console as Default project choose 
RecipesApp.LoggerDatabase and type update-database -context RecipesLoggerDbContext. 

-After you finished updateing you will have to add user manually so you can login.
First, start the project with (F5, ctrl F5). This project is API and on the startup, it will be Swagger where you need to authorized 
for some endpoints. You will have to generate hashed password by starting this endpoint https://localhost:5001/api/Authentication and after that you will be able 
to add test data in tables 'User' and 'AspNetUsers', including hashed password. 

-If you want to run the frontend part of the application, open client folder in Visual Studio Code and after that open the Terminal(make sure you are in the client folder.
You can use command 'cd client' to enter folder) and type

npm install

With this command you are making sure that all dependencies are being installed.

After that, use

ng serve

This command is launching the application on the browser. In the browser type http://localhost:4200/ and the application will be started.
To be able to see the required data you need to run both the backend and frontend part of the application at once.


About application

-This application allows you to enter and view recipes and various categories of dishes. For building this app is used the RESTful API C# .NET CORE for backend, 
Microsoft SQL Server Managment Studio for database and Angular for frontend. First thing that appears are categories which allows you to continue to other routes by 
clicking the button 'See details'. If you are logged in you will be able to update, delete and add categories. Same things are applied to other components. If you click 
'Ingredients' button you will be abble to add, updated or delete ingredient, search ingredients by quantity, measure and name, sort data by name, quantity and price 
and load data by clicking options 'Load 10,20,50 or 100'. 









