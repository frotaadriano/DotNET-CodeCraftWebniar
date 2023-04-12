using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;
using CodeCraftMinimal.Model;

namespace CodeCraftMinimal
{
    public static class ApiEndpoints
    {
        public static void MapApiEndpoints(this WebApplication app)
        {

            //TODO: 4 criar rotas
            var inst = Counter.Instance();

            app.MapGet("incremento", () =>
            {
                inst.Increment();
                return inst.GetCount();
            });

            app.MapGet("decremento", () =>
            {
                inst.Decrement();
                return inst.GetCount();
            });


            app.MapGet("api/users", 
                (UserDBContext ctx) 
                => 
                TypedResults.Ok(ctx.Users.ToList()))
                .WithName("UserList")
                .WithOpenApi(o => new(o)
                {
                    Summary = "Retorna todos os usuários do sistema!",
                    Description = "Its a simple GET made in CodeCraft Webinar!"
                });

            app.MapPost("api/users", (CreteUserInput userInput, UserDBContext ctx)
                        =>
            {
                var user = new User() { Name = userInput.name };
                
                ctx.Users.Add(user);
                ctx.SaveChanges();


                // Retorna  HTTP 201 - Created
                // Cria o Header: Location com o Id do User criado.
                // Criar a resposta e redirecionar o cliente para a rota que exibe os detalhes do usuário recém-criado
                return TypedResults.CreatedAtRoute(
                    user,
                    "UserDetails",
                    new { Id = user.Id }
                    );
            }
                        )
                       .WithName("UserCreate");


            app.MapGet("api/users/{id:int}", Results< Ok<User>, NotFound> (int id, UserDBContext ctx)
                        => 
                            ctx.Users.FirstOrDefault(x => x.Id == id) is User user
                            ?
                            TypedResults.Ok(user)
                            :
                            TypedResults.NotFound() 
                      )
                      .WithName("UserDetails");


            app.MapDelete("api/users/{id:int}",
                            Results<NoContent, NotFound>
                            (int id, UserDBContext ctx)
                            =>
                            {
                                var user = ctx.Users.FirstOrDefault(x => x.Id == id);

                                if (user is null) return TypedResults.NotFound();

                                ctx.Remove(user);
                                ctx.SaveChanges();

                                return TypedResults.NoContent();

                            }
                        )
                        .WithName("UserDelete");

            app.MapPut("api/users/{id:int}",
                            Results<Ok<User>, NotFound>
                            (CreteUserInput userInput, int id, UserDBContext ctx)
                            =>
                            {
                                var user = ctx.Users.FirstOrDefault(x => x.Id == id);

                                if (user is null) return TypedResults.NotFound();

                                user.Name = userInput.name;

                                ctx.Users.Update(user);
                                ctx.SaveChanges();

                                return TypedResults.Ok(user);

                            }
                        )
                        .WithName("UserUpdate");
        }
    }
}

 record CreteUserInput(string name = "");