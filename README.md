# WebApiTokenEmployee

This is a sample Web Api Token Based Authentication project where you can perform CRUD operations through the authorized employees api controller.

## Configuration
You can download the application directly to your computer from the download section.
Application has been developped with Code First Data-Access method. The application has an entity named Employee. You can find the EmployeeDbContext which has the Connection string: "server=.;database=EmployeeDB;trusted_connection = true;". If you are using user and password, you can change from here. Database name will be EmployeeDB. If you have existing database with same name then you need to change the name. Don't forget to change it from web.config too.

Please enter: Enable-Migrations -ContextTypeName WepApiToken.Context.EmployeeDbContext in Package Manager Console.

in Configuration, change AutomaticMigrationsEnabled to true and add below code to Seed method. This will enable Employee table to be created with below sample data. Then you can enter update-database command to Package Manager Console.

      List<Employee> employees = new List<Employee>
            {
                new Employee{Title="Sales Representative", FirstName="Nancy", LastName="Davilo",Gender="Female"},
                new Employee{Title="Vice President, Sales", FirstName="Andrew", LastName="Fuller",Gender="Male"},
                new Employee{Title="Sales Manager", FirstName="Steven", LastName="Buchanan",Gender="Male"},
                new Employee{Title="Inside Sales Coordinator", FirstName="Laura", LastName="Callahan",Gender="Female"}
            };
            foreach (var employee in employees)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
            
![image](https://user-images.githubusercontent.com/71972947/152697456-dc5c9847-a440-411b-bef1-7b2a7c795218.png)

There are 3 html pages under Client folder. They have ajax scripts which you need to change the url with your project url. Right click on project / Properties, on web tab you can find the project url.

![image](https://user-images.githubusercontent.com/71972947/152697899-6f066478-d0ad-4463-90ac-2a873e8b7f8e.png)

You can find token settigs in Startup.Auth class under App_Start folder. Timespan is set to 10 minutes.

## Usage

You can run the project now.

![image](https://user-images.githubusercontent.com/71972947/152697975-b1c2e0b6-13e9-416b-ae00-4cfd9baf5a87.png)

We are going to list the employees, add, update and delete through Employees Api Controller. But this Api controller is authorized and we need token to be able to take action.
First we need to register, then login with same credentials to get the token then we are able to perform the CRUD operations.

You can directly go to https://localhost:xxxxx/Client/Register.html or click on Get Employess button. It will direct us to login page as we are not logged in yet.

There you can click on Register button.
![image](https://user-images.githubusercontent.com/71972947/152698180-b110db53-25d1-45e3-b212-27351ee74344.png)

First registiration might take some time because identity tables will be created.
![image](https://user-images.githubusercontent.com/71972947/152698195-48ec6013-451e-4492-a6f7-18da7bf175e2.png)

Once registiration is done, you will see the success message and re directed to login page.
![image](https://user-images.githubusercontent.com/71972947/152698288-f07381dd-d090-4cb9-8356-2d461639c27d.png)

 If you check the EmployeeDB, you will see the created user tables.
![image](https://user-images.githubusercontent.com/71972947/152698359-b8f9a4bb-1922-4e65-910b-8a5b9e83979b.png)

When you login, you will be granted the token and directed to Data page. When you click Get Employees button, they will be listed now.
![image](https://user-images.githubusercontent.com/71972947/152698408-7097103f-1f5b-4cf1-9073-94705472a94f.png)

When you click Add button on top, a panel will be opened on the right side. You can add new employee.
![image](https://user-images.githubusercontent.com/71972947/152698489-7fa2fc3c-f154-4626-ad88-0ae5322161d5.png)

When you click on update button, the panel will be opened for the employee that is clicked on. 
Lets change Anne's gender as Female. Click update button in the panel again.
![image](https://user-images.githubusercontent.com/71972947/152698632-10664823-1fee-40b3-9669-f96cc40e2249.png)

Finally to delete the employee, just click on the delete button for the required employee.

To log off, you can click on Log Off button on upper right corner. This will redirect you to the login page.

## Contact

You can reach me via engin.tayfun@gmail.com.

Thank you.

