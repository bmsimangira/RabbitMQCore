RabbitMQ-with-Entity-Framework

.NET Core project implementing RabbitMQ

Prerequisites to run application: Visual Studio 2015 and .NET Core runtime.

Instructions to run application:

1) Go to https://www.rabbitmq.com/install-windows.html and download the runtime environment "Erlang" and intall on your system.

2) From the same website download and install "RabbitMQ" for your system.

3) Download project from https://github.com/bmsimangira/RabbitMQ-with-Entity-Framework

4) Navigate to the download location and locate the solution file for the application; "PangeaServices.sln".

5) Once the solution is open in Visual Studio, go to Tools -> Nuget Package Manager -> Package Manager Console; and in the console run the following command to create the database for the project: Update-Database

6) Press the Start button through Visual Studio, this will start the console app which listens to the queue for any incoming messages and also starts the website.

6) Once the initial page of the site is loaded, to initiate the application add "/LoadData" to the end of the browser address, ie. http://localhost:XXXX/LoadData .

7) Repeat step 6 but instead of adding "/LoadData" add "/Repositories" which will output the data that was loaded into the database in JSON format.