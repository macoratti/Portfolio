using PortfolioMvc.Models;
namespace PortfolioMvc.ViewModels;

public class PortfolioViewModel
{
    public IEnumerable<Projeto>? Projetos { get; set; }
}
