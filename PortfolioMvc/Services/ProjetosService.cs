using PortfolioMvc.Models;

namespace PortfolioMvc.Services;

public class ProjetosService : IProjetosService
{
    public List<Projeto> GetProjetos()
    {
        return new List<Projeto>() {
                new Projeto
                {
                    Titulo = "Macoratti.net",
                    Descricao = "Blog de artigos criado em ASP.NET Core desde 2002 com mais de 5000 artigos",
                    Link = "https://macoratti.net.br",
                    ImagemURL = "/imagens/macorattinet1.jpg"
                },
                    new Projeto
                {
                    Titulo = "Curso ASP .NET Core MVC - Vendas",
                    Descricao = "Curso para criação de um site de vendas de lanches do zero",
                    Link = "https://www.udemy.com/course/curso-de-asp-net-core-mvc-criando-um-site-do-zero/",
                    ImagemURL = "/imagens/cursomvc1.jpg"
                },
                    new Projeto
                {
                    Titulo = "Curso Web API ASP .NET Core Essencial ",
                    Descricao = "Curso para criar APIs restfull com ASP .NET Core",
                    Link = "https://www.udemy.com/course/curso-web-api-asp-net-core-essencial/",
                    ImagemURL = "/imagens/cursowebapi.jpg"
                },
                    new Projeto
                {
                    Titulo = "Curso Clean Architecture - ASP .NET Core com C#",
                    Descricao = "Criando projetos .NET Core segundo a Clean Architecture ",
                    Link = "https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/",
                    ImagemURL = "/imagens/cursocleanarch1.jpg"
                },
                    new Projeto
                {
                    Titulo = "Curso Blazor Essencial (Atualização .NET 6)",
                    Descricao = "Os principais recursos do Blazor para criar aplicações web usando a linguagem C#",
                    Link = "https://www.udemy.com/course/curso-blazor-essencial/",
                    ImagemURL = "/imagens/cursoblazor1.jpg"
                },
                    new Projeto
                {
                    Titulo = "Docker essencial para a plataforma .NET",
                    Descricao = "Usando o Docker em aplicações ASP .NET Core MVC",
                    Link = "https://www.udemy.com/course/docker-essencial-para-a-plataforma-net/",
                    ImagemURL = "/imagens/cursodocker1.jpg"
                },
            };
    }
}

