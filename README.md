<h1 align="center">MovieAPI</h1>

<div align="center">

![](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visual%20studio&logoColor=white)
![](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![GitHub repo size](https://img.shields.io/github/repo-size/Oswaldo-Hqz/MovieAPI)
![Nuget](https://img.shields.io/badge/EntityFrameworkCore-v6.0.0-blueviolet)
![Nuget](https://img.shields.io/badge/JwtBearer-v6.0.0-blueviolet)
![GitHub](https://img.shields.io/github/license/Oswaldo-Hqz/MovieAPI)

</div>

---

<p align="center"> This is a basic movie catalog API, the functionality developed consists of registration and user authentication under the roles Administrator and User. Registration of movies with category catalog and rating by users.
    <br> 
</p>


## 🏁 Getting Started <a name = "getting_started"></a>

The project is developed with EF core for SQLServer database and which is already preconfigured for development environments. If you want to test it you will have to modify the connection string, which you will find in the `appsettings.Development.json` file.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=[YOUR-DB-NAME];Database=MovieWebDB;Integrated Security=True;TrustServerCertificate=True"
  }
}
```

You will have to execute a command to perform the database migration so that the database is created in your local SQLServer and the seed data that is already configured is saved.

If you use VisualStudio from PowerShell you must enter the following command.

```cl
Update-Database
```

if you use VS Code or any other editor from the .NET CLI you must enter the following command.

```cl
dotnet ef database update
```

The users initially registered to be able to authenticate are the following:

| Email              | Password | Role  |
| ------------------ |:--------:| -----:|
| admin@ravn.com     | 12345678 | admin |
| userDavid@ravn.com | 87654321 | user  |

> Don't forget that you can register a user with role "user" at any time, and register an "admin" user only through an authenticated admin user.

