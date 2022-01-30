using PortfolioMvc.ViewModels;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace PortfolioMvc.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Enviar(ContatoViewModel contato)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nome = _configuration.GetValue<string>("SENDGRID_NOME");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nome);
            var subject = $"O cliente {contato.Email} quer entrar em contato";
            var to = new EmailAddress(email, nome);
            var mensagemTexto = contato.Mensagem;
            var conteudoHtml = @$"De: {contato.Nome} - Email: {contato.Email} Mensagem : {contato.Mensagem}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensagemTexto, conteudoHtml);
            await cliente.SendEmailAsync(singleEmail);
        }
    }
}
