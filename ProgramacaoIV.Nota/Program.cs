
using Microsoft.EntityFrameworkCore;
using ProgramacaoIV.Nota.Context;
using ProgramacaoIV.Nota.Model;

namespace ProgramacaoIV.Nota;

public class Program
{
    private const string _connectionString = "Server=localhost;Port=3306;Database=umfg_todo_list;Uid=root;Pwd=root;";

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<NotaContext>(options => options.UseMySQL(_connectionString));

        var app = builder.Build();

        app.MapGet("/notas", async (NotaContext context) => await context.Notas.ToListAsync());

        app.MapGet("/notas/{id}", async (string id, NotaContext context) =>
            await context.Notas.FindAsync(Guid.Parse(id)) is NotaC nota ? Results.Ok(nota) : Results.NotFound());


        app.MapPost("/notas", async (NotaC nota, NotaContext context) => {
            context.Notas.Add(nota);
            await context.SaveChangesAsync();

            return Results.Created($"/notas/{nota.Id}", nota);
        });

        app.MapPut("/notas/{id}", async (string id, NotaC inputNota, NotaContext context) => {
            var nota = await context.Notas.FindAsync(Guid.Parse(id));
            
            if (nota is null) 
                return Results.NotFound();

            nota.Aluno = inputNota.Aluno;
            nota.Disciplina = inputNota.Disciplina;
            nota.Valor = inputNota.Valor;
            nota.Data = inputNota.Data;

            await context.SaveChangesAsync();

            return Results.NoContent();
        });

        app.MapDelete("/notas/{id}", async (string id, NotaContext context) => {
            var nota = await context.Notas.FindAsync(Guid.Parse(id));

            if (nota is null)
                return Results.NotFound();

            context.Notas.Remove(nota);
            await context.SaveChangesAsync();

            return Results.NoContent();
        });

        app.Run();
    }
}