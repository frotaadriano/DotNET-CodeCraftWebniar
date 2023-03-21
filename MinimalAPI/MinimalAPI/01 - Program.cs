using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();//adds services for generating OpenAPI and Swagger documents
builder.Services.AddSwaggerGen(); /*
builder.Services.AddSwaggerGen() is a method used to configure Swagger services in an ASP.NET Core application. Swagger is a tool that allows developers to design, build, and document RESTful web services.
By using AddSwaggerGen(), an instance of SwaggerGenOptions is added to the dependency injection container. This instance is then used to configure Swagger-related options. For example, you can specify the title and version of the API, the API's description, the location of the XML documentation file, and much more.
*/

//register services

var app = builder.Build();
//app.UseSwagger();
//app.UseSwaggerUI();
//app.UseHttpsRedirection();
//middlewares

//exemplo 1
var userList = new User[] { new(1, "Joao"), new(2, "Maria") };
userList.Append(new(3, "Pedro"));


#userList[0].Name = "Joao da Silva";
#var u = new User();

app.MapGet("users", () => userList);

app.Run();

record User(int Id, string Name);

/*
  record x class 
  Introduzido no C# 9
  Props nao podem mudar valores  
  Record: Representar um valor imutável
  Class: Representar um valor mutável

 */