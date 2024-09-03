//Minimal APIs em C#
//Testar a API:
// - Rest Client - Extensão VSCode
// - Postman
// - Insomia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoint - Funcionalidade da aplicação
//Requisição - URL e método/verbo HTTP
//app.MapGet("/qualquercoisa", () => "Hello World!");
app.MapGet("/", () => "Hello World em C#!");

app.MapGet("/segundafuncionalidade", () => "Segunda funcionalidade!");


app.Run();

//Exercicios para próxima aula
//Criar um endpoint para receber informação pela URL
//Receber a informação pelo corpo
