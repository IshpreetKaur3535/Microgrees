MICROGREENS STOCK MANAGEMENT WEBSITE
*************************************************************************************************************************************************************
Developed by Ishpreet Kaur
*************************************************************************************************************************************************************
Version 2.0
*************************************************************************************************************************************************************
AppSettings
--------------------------------------------------------------------------------
{
  "ConnectionStrings": {

    "DefaultConnection": "Server=(LocalDB)\\MSSQLLocalDB;Database=Microgreen_IshpreetKaur; Trusted_Connection=True; MultipleActiveResultSets=true;"

  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}

--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Software Requirement
-------------------------------------------------------------------------------
   --Operating System: Windows 10(32 or 64 bit version), Windows11
   --Processor: Any processor would work
   --RAM: Min 4GB  
-------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Software specs
--------------------------------------------------------------------------------
  --Microsoft Visual Studio 2022
  	->Version 17.2
  	->ASP.NET Core Web App (Model-View_Controller)
  	->Net framework 5.0
  --Microsoft SQL Server Management Studio
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Frameworks
--------------------------------------------------------------------------------
        -Microsoft.AspNetCore.App
	-Microsoft.NetCore.App
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Plugin
--------------------------------------------------------------------------------
        -bootstrap (5.2.3)
	-Microsoft.AspNetCore.Identity.EntityFrameworkCore (5.0.17)
	-Microsoft.AspNetCore.Identity.UI(5.0.17)
	-Microsoft.EntityFrameworkCore.Design (5.0.17)
	-Microsoft.EntityFramework.SqlServer (5.0.17)
	-Microsoft.EntityFrameworkCore.Tools (5.0.17)
	-Microsoft.VisualStudio.Web.CodeGeneration.Design (5.0.2)
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Background
--------------------------------------------------------------------------------
The local farmer produces microgreens (Young seedlings of edible vegetables and
herbs are known as microgreens) in their farm, but they could not manage to sell them
all and left over gets damaged or eaten by the animals. Basically, they are not able to
make any type of profit from their farm.

To resolve this issue the group of local farmers have decided to start a brick-andmortar
store where they can sell all the products together under a one roof. They call
themselves a Microgreen’s. Microgreens has approached software developer to develop their
stock management website where they can manage their incoming and outgoing stock. 
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Project Description
---------------------------------------------------------------------------------------------------------------------------------
The progarm uses asp.net core 5 MVC to create the prototype of a web application for microgreens stock management website. The 
website will have three types of users which are "Admin", "Employee" and "Farmer" and each user will be assigned to a specific
role. The admin will able to view the whole website and will allow to make any changes with the website. The adim can also add
oe delete the farmer from the website or can update the products information as well. The admin will be allowed to do everything 
on the website. When an employees los in to the website they are allow to add or remove farmer from the website. The employee will
also be able to filter the displayed list of product supplied be a specific farmer. The farmer will only be allowes to add a new 
products. The farmer will have a full CRUD functionality while they are adding a product. 
 
--------------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
How To Use the app
---------------------------------------------------------------------------------------------------------------------------------
When the user runs the website the user will only be able to view the home page and about us page of the webite. The user has 
to login to the webite in order to use the functionality. The user must click on the login tab which will be found at the top 
navbar on the right side of the screen. The user will now able to login to the webiste. If the user which is logged in to the 
website, is assigned a Admin role then the user will be able to view all the functionalty of the app. If the user is logged in 
as a Employee then they will be able to only see the farmer tab and a Product tab. When the user(Employee) cliks on the farmer
tab they will be able to add or remove the farmer and if they click on the products tab they only be able to view the list of 
products supplied by the farmer and can filter the list using the search bar given at the top of this page. The Employee will
also be able to view the category tabs where they can add the types of the product. If the user is logged in as a Farmer they 
will only view the Produts tab where they can add or remove product. 
 
--------------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Features
---------------------------------------------------------------------------------------------------------------
   --User input with exception handling
   --Makes use of good comments to follow and guide through the program
   --Makes use of graphical interface 
   --Provides authorisation for three different types of users which are "Admin", "Employee" and "Farmer"
   --The program makes use of colour changes for easy navigation in the graphical pages 
   --This Program is all in all, user friendly and if the user reads all prompts everything
     will run smoothly, if not the program will redirect the user on the right path.
--------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Installations instructions and Instructions on How to use the application
--------------------------------------------------------------------------------------------------------------------
   --Unzip the folder: PROG7311_Part2_ST10084227_IshpreetKaur  
   --Place it in repos folder 
   --First thing the user has to do is to make sure that the connection string in the appsetting is correct.
     The user can find the connection at the end of this document. 
   --If you do not have the visual studio you won't be able to place the folder in the repos,
     so to download the visual studio heres the link: https://visualstudio.microsoft.com/downloads/,
     I would recommed you to download the community version.
   --Once the folder is placed in the repos open the folder MicrogreensWebsiteVersion2
   --Then open the file MicrogreensWebsite.sln. Once the project is open click on the run button to run the application.
   --The Microgreens Stock Management website will run.
------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Troubleshooting
--------------------------------------------------------------------------------------------------------------------------------------
   --Make sure that you place the folder in the repos folder otherwise the application will not work at all.
   --When the user run the application and if the error occur, The user can simply press three keys from the keyword which are 
     ctrl+alt+delete and it will give you options to choose, the user must select task manager and then end all the task that are 
     running related to the application or any c# project.
   --The user can also restart their computer if any external error occur.
   --While the web application is running and the user gets error, the user must simply refresh the page or they can close the
     browser and restart the program again.  
--------------------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
FAQs
----------------------------------------------------------------------------------------------------------------
  --Q1: What happens if we input the wrong input for the numerical values?
        If you input the string values in the numerical inputs the application will alert 
        user to inuput the correct values.

  --Q2: Does it save the data somewhere?
        Yes it does save data in database.

  --Q3: Why I am getting  Access denied on some of the  pages when I log in to add product/
	Because the website has used authorisation so that some of the  content of the website will bbe restricted 
	according to the roles assigned to the user.
 
  --Q4: When searchning for a specific user do have have to put in the full farmer name?
  	Yes, Have to put in the full name otherwise it will not show the products added by the specific farmer

   --Q5: Show can a user view the detail of the product on the View product page?
         The user have to click on the detail button on at the botton of each card in order to vie the product detail. 
-------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Developer contact info 
--------------------------------------------------------------------------------
   --Name: Ishpreet Kaur
   --Student number: ST10084227
   --Email ID: ST10084227@vcconnect.edu.za
   --Cell number: +27791936637
--------------------------------------------------------------------------------
***************************************************************************************************************************************************************
Code Attribution
----------------------------------------------------------------------------------------------------------------------------------------------------
-Digital TechJoint. How To Apply Free Bootstrap Themes in ASP.NET. Available at: https://www.youtube.com/watch?v=bUgFQeUaze0&t=328s. [Accessed 27 May 2023]
-tutorialsEU - C#. ASP.NET User Roles - Create and Assign Roles for AUTHORIZATION!. Available at: https://www.youtube.com/watch?v=Y6DCP-yH-9Q. [Accessed 25 May 2023]
-Anderson, R. (2023). Part 7, add search to an ASP.NET Core MVC app. Available at: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-5.0.
 [Accessed 26 May 2023]
-Microsoft. (2022). Role-based authorization in ASP.NET Core. Available at: https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-5.0
 [Accessed 25 May 2023]
-W3School. (2023). Bootstrap 5 Carousel. Available at: https://www.w3schools.com/bootstrap5/bootstrap_carousel.php. [Accessed 26 May 2023]
Images Reference
	-Onion: https://shorturl.at/jmoHN
	-Melon: https://shorturl.at/fqAI5
	-Broccoli1: https://shorturl.at/jOQW0
	-Cauliflower1: https://shorturl.at/pALQ3
	-Fennel1: https://shorturl.at/dHMY0
	-Lettuce1: https://shorturl.at/zSUZ0
	-garlic1: https://shorturl.at/cjBRX
	-spinach1: https://shorturl.at/hHKL4
	-Home1: https://shorturl.at/glAR5
	-Home2: https://shorturl.at/DKLOV
	-Home3: https://shorturl.at/jpEWX
	-Home4: https://shorturl.at/wHIV7
	-Logo: I created the logo in paint
-----------------------------------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Connection String
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    "DefaultConnection": "Server=(LocalDB)\\MSSQLLocalDB;Database=Microgreen_IshpreetKaur; Trusted_Connection=True; MultipleActiveResultSets=true;"

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Default Login Info
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
	-Admin
		Email: Admin2@gmail.com
		Password: Test!234
	-Employee
		Email: Employee@gmail.com
		Passwrod: Test!2345
	-Farmer1
		Email: Mark@gmail.com
		Password: Test!2345
	-Farmer2
		Email: John@gmail.com
		Password: Test!2345
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Demo Video Link
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    https://drive.google.com/drive/folders/1YKpbTLccyB0avZmD5XB3oh6VPqqrutWX?usp=sharing

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
