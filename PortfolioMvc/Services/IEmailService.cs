using PortfolioMvc.ViewModels;

namespace PortfolioMvc.Services
{
    public interface IEmailService
    {
        Task Enviar(ContatoViewModel contato);
    }
}
