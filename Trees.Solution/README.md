# _Glorbo's Treats_

#### By _Ben Dunham & Melissa Scmi_
<br/>

#### _Whatchu got in that bag?_
<br/>

WE DONT DIE, WE STAY HIGH.

<hr>
<br/>

## Technologies Used
* _C#_
* _NuGet_
* _.NET 5_
* _MySql_
* _ASP.NET Core_
* _Entity Framework_
* _Swagger_


## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run the console app.
- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)

### Setup/Installation

1. Clone [this repository](https://github.com/bendunhampdx/Trees.Solution) to an empty folder or to your desktop, or download and open the Zip on your local machine. Instructions for cloning can be found [here](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository).
2. Navigate to the ```Trees.Solution``` directory on your computer
3. Open the Trees.Solution folder in your preferred text editor
4. Set up your SQL database using MySQL:
   - Create a new `appsettings.json` file in the ```Trees.Solution``` directory
   - Copy the following code into the `appsettings.json` file, replacing `YOUR_PASSWORD` with your MySQL password:
   ```
        "Logging": {
         "LogLevel": {
           "Default": "Warning",
           "System": "Information",
           "Microsoft": "Information"
         }
      },
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=trees;uid=root;pwd=YOUR_PASSWORD;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and hit enter to launch MySQL servers
5. To run the console app:
 - Navigate to ```Trees.Solution``` in your command line
   - Run:
     - `dotnet restore` to restore the dependencies that are listed in ```Trees.Solution.csproj```
     - ```dotnet ef migrations add Initial``` and ```dotnet ef database update```
   - Run ```dotnet run``` to run the project

6. Visit the application via web browser at: `http://localhost:5000/`

## Documentation and Routes

### Swagger

_To access Swagger Documentation for API calls for GET, PUT, and POST:_
 - Run the application from `Trees.Solution` in your command line
 - Once the application is running, go to `http://localhost:5000`
    - You can also follow this link while the program is running [Swagger](http://localhost:5000).

### Manual Routes

- GET `/api/plants`
    - Returns all plants in database

- GET `/api/plants/{id}`
    - Returns a single plant with the specified ID

- POST `/api/plants`
    - Creates a new plant in the database

- PUT `/api/plants/{id}`
    - Edits the existing plant with the specified id

- DELETE `/api/plants/{id}`
    - Deletes the existing plant with the specified id


## Known Issues
* _None. We're perfect. Golden angels._

## License

_[GPL](https://opensource.org/licenses/gpl-license)_
_Copyright (c) 2021, Ben Dunham & Melissa Schatz-Miller_

## Contact Information  

Ben Dunham 
Melissa Schatz-Miller <melissa.scmi@gmail.com>  
_Please feel free to reach out to us with suggested changes/improvements, or if you have any questions._