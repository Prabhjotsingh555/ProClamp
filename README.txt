Starting time = 10-10-2023 0235
Program name = ProClamp
Program Purpose = Making a MVC project
Program author = Prabhjot Singh

-------START FIRST STEP-------

1. First I ceatre new project
2. Filter the search by choosing c# language ande platform > web
3. Then name the project (ProClamp) choose path and place in same folder file as in project
4. Then choose version 3.1 
5. And create
6. Then click on git and make new clone respository 
7. Write the desciption
8. Done.
9. Then create readme
10. Then comment the local host line  7 inside > Properties > launchSettings.json
Test it = IT WORKED
11. Commint to Github

-------COMPLETED FIRST STEP-------

-------START SECOND STEP-------

Starting time = 10-10-2023 0237

1. Right click on Controllers > Add > Controller > MVC Controller - Empty > Add > name it > ProClampController.cs
2. Make two new string, First > deafult messag, Second > welcome message
 Test it = IT WORKED
3. Make another public string code with  name and numTimes variable and comments previous one
 Test it = IT WORKED
4. Make another string with name and ID variable and comment previous one
 Test it = IT WORKED
5. Write the comments
6. Commint to Github

-------COMPLETED SECOND STEP-------

-------START THIRD STEP-------

Starting time = 11-10-2023 1018

1. Clone the respositery in the visual studio
2. Open solution, clean solution and rebuild solution
 Test it = IT WORKED
3. Write the new index string in ProClampControlller.cs folder
4. Right click on > View folder > add new folder > name it ProClamp > add > view > indesx.cshtml
5. Wright code in this folder
 Test it = NOT WORKED
6. I forget to remove the comma in launchSettings.json in 6th page                                                           ............EROR............
7. So I remove it
 Test it = IT WORKED
8. Changed the name from ProClamp to ProClamp App in the 14th line in Views > Shared > _Layout.cshtml
 Test it = IT WORKED
9. Change the h2 and title in Views > QuickClamp > Index.cshtml
10. Change the title
 Test it = IT WORKED
11. Make new Welcome string in ProClampController.cs page 
12. Make new razor empty Page with name Welcome.cshtml inside the Views > ProClamp
13. Write the code in Welcome.cshtml page
 Test it = IT WORKED
14. Write the Comments
15. Commint to Github

-------COMPLETED THIRD STEP-------

-------START FOURTH STEP-------

Starting time = 11-10-2023 1108

1. Makinfg a new class (Clamp.cs) inside the > Model folder > add > class
2. Write the product properties in this class 
3. Install Package  Microsoft.EntityFrameworkCore.SqlServer but it not installed                                               ............EROR............
4. I solve this through tools > Nuget Pacakeg Manger > Manage nuget pacakage for solution > paste : Microsoft.EntityFrameworkCore.SqlServer in the browse field
5. Select the latest one > select the project > choose he version 3.1.0 > and install it
 IT WORKED
6. Create a new folder in the project with name Data 
7. Add class in this folder and name it ProClampContext
8. Write the code in this class
9. Register the database context with the DI container by adding using MvcMovie.Data;, using Microsoft.EntityFrameworkCore; in the Startup.cs file
10. Make connection string in this file by writing code
11. Make a string connection for the ProClampContext Databse in the appsetting.json file
12. Add Scaffold movie page > Controllers > Add > New Scaffolded item > MVC Controller with views, using Entity Framework
13. choosing MvcMovieContext (MvcMovie.Data) in first search field and by clicking on add choose the default one 
14. Add it
!5. Run the Command Add-Migration InitialCreate > tools >  Nuget Pacakeg Manger > Package manager console
 IT WORKED
16. Run the command Update-Database
 IT NOT WORKED                                                                                                                  ............EROR............
17. The error is clamp table name is already exists in the database so to solve this issue i close the current project and create a new project
18. Through this new project i go to database and delete the old one
19. Again open the previous projeect and run the command
 IT WORKED
20. Write the comments
 Test it = IT WORKED
21. Commint to Github

-------COMPLETED FOURTH STEP-------

-------START FIFTH STEP-------

Starting time = 11-10-2023 1222

1.Exmine the table data in the sql server
2. Create a new class (SeedData) inside Models folder
3. Write the properties and it's infomation in this class
4. Write code in Program.cs file
5. Write the comments
 Test it = IT WORKED
6. Commint to Github

 -------COMPLETED FIFTH STEP-------

 -------START SIXTH STEP-------

Starting time = 11-10-2023 0110

1. Update data annotation attribute for date and decimel string.
2. Write comments
 Test it = IT WORKED
3. Commint to Github

 -------COMPLETED SIXTH STEP-------

 -------START SEVENTH STEP-------

Starting time = 11-10-2023 0111

1. Update the index method in ClampsController.cs class
 Test it = IT WORKED
2. Again Update some lines in the same class
 Test it = IT WORKED
3. Make a new class (ClampTypeViewModel.cs) insidde the Models folder > Add > Class
4. Write code in this class
5. Update the ClampsController.cs class once again
6. Update Index.cshtml inside the Views > Clamps > Index.cshtml
7. Write the comments
 Test it = IT WORKED
8. Commint to Github

-------COMPLETED SEVENTH STEP-------

-------START EIGHTH STEP-------

Starting time = 11-10-2023 0211

1. Write new string Rating in Clamp.cs class inside the Models folder
2. Write the code in Index.cshtml file Views > Clamps > Index.cshtml
3. Also in Create.cshtml Views > Clamps > Create.cshtml
4. Updtae the SeedData by adding Rating in every columns Models > SeedData.cs
5. Run The Commands Add-Migration Rating, Update-Database
 IT NOT WORKED                                                                                             ............EROR............
6. Error was unknow name Rating
7. To solve this issuse i close the project and clone from git again
8. Open the solution, clean it and rebuild it
9. Run it 
 Test it = IT NOT WORKED                                                                                    ............EROR............
10. Error was SqlException: Cannot open database "ProClampContext-1" requested by the login. The login failed.
11. Now i have two error 
12. To solve this issue i run the command Update-Database
 Test it = IT WORKED
13. Now i delete the all records from the table
14. Now from starting i add the rating field
15. Run The Commands Add-Migration Rating, Update-Database
 Test it = IT WORKED
16. Add comments
17. Commit to Github

-------COMPLETED EIGHTH STEP-------

-------START NINTH STEP-------

Starting time = 12-10-2023 0748

1. Clone the respositery in the visual studio
2. Open solution, clean solution and rebuild solution
 Test it = IT WORKED
3. Add regularExpression, Required and StringLength
 Test it = IT WORKED
4. Now i tried to change rating string to decimel, so I change regular expression and string to decimel
 Test it = IT  NOT WORKED                                                                                 ............EROR............
5. to solve this issue First i try to run this without changing anything
 Test it = IT  NOT WORKED 
6. Delete the records form the table
7. Then I delete the rating migration file > Migrations > 20231012120609_Rating.cs
8. Now i changed the change regular expression and string to decimel again
9. Run the commands Add-migration Rating and update-database
 Test it = IT  NOT WORKED 
10. Add the comments
11. Commint to github

-------COMPLETED NINTH STEP-------

-------START DOING REST THINGS-------

Starting time = 12-10-2023 1135

1. Start adding new page (About Us)
2. Create a new view Home > Add > View > AboutUs.cshtml
3. Link it in _Layout.cshtml
 Test it = IT  NOT WORKED                                                    ............EROR............
4. Error was This localhost page can’t be found
5. I forget to add Action method for displaying the About Us page in HomeController.cs file : Controllers > HomeController.cs
 Test it = IT  NOT WORKED 
6. Modifiy the page add images, fonts and colour
7. Add readme in Github
8. Link it to the Azure

-------COMPLETED LAST STEP-------
