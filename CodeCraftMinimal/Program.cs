using CodeCraftMinimal;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<UserService>();
builder.Services.AddDbContext<UserDBContext>(
    options => options.UseInMemoryDatabase("Users"));
 

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

#region Aprendendo sobre as rotas e afins 
//app.MapGet("/teste", () => "hello MinimalAPI");

//app.MapGet("/users/path/{nome}", (string nome) => new { Saudacoes = $"Bem vindo {nome}" });
//app.MapGet("/users/query/nome", (string nome) => new { Saudacoes = $"Bem vindo {nome}" });

////https://localhost:7042/users?nome=Frota
//app.MapGet("/users", async (HttpRequest req, HttpResponse res) =>
//{
//    var nome = req.Query["nome"];
//    await res.WriteAsync($"Bem vindo {nome}");
//});

//var userList = new User[] { new(1, "Joao"), new(2, "Maria") };
//app.MapGet("/users", () => userList);

//app.MapGet("/users/{departamento}",
//    (string departamento, string user)
//    =>
//    new { Saudacoes = $"Bem vindo {user} do departamento {departamento}" });

//app.MapGet("/users2/{departamento}",
//    (
//       [FromRoute] string departamento,
//       [FromQuery] string user
//       )
//    =>
//    new { Saudacoes = $"Bem vindo {user} do departamento {departamento}" });


//app.MapGet("/users3/{departamento}",
//    (
//       [FromRoute] string departamento,
//       [FromHeader] string user)
//    =>
//    new { Saudacoes = $"Bem vindo {user} do departamento {departamento}" });



//var action = () => new User[] { new(1, "Joao"), new(2, "Maria") };
//app.MapGet("/users/action", action);

//app.MapGet("/users/static", UserEndpointStatic.Get);

//var userEndpoint = new UserEndpointInstance();
//app.MapGet("/users/instance", userEndpoint.Get);



//app.MapGet("/users/{departamento}",
//    (
//       string departamento,
//       string user,
//       UserService userService
//       )
//    =>
//    new { Saudacoes = userService.Hello(user) });

//app.UseHttpsRedirection();
//app.Run(); 

//public record User(int Id, string Name);

//public static class UserEndpointStatic
//{
//    public static User[] Get() => new User[] { new(1, "Joao"), new(2, "Maria") };
//}

//public class UserEndpointInstance
//{
//    public User[] Get() => new User[] { new(1, "Frota"), new(2, "Maria") };
//}

#endregion
 

app.UseHttpsRedirection();
app.MapApiEndpoints();
app.Run();


public class UserService
{
    public string Hello(string name) => $"Hi, {name}";
}
