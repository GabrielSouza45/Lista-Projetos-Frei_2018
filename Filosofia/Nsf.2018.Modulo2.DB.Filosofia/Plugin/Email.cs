using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Filosofia.Plugin
{
    public class Email
    {
        public void Enviar(string para, string mensagem)
        {
            Task.Factory.StartNew(() =>
            {
                // Se for usar seu email, habilite ele em: https://myaccount.google.com/lesssecureapps?pli=1
                string remetente = "nsfmailing@gmail.com";
                string senha = "nsf@mailing";


                string assunto = "Nova Mensagem | Filosofia Diária";
                mensagem = CriarMensagemComHtml(mensagem);

                // Configura a mensagem
                MailMessage email = new MailMessage();

                // Configura Remetente, Destinatário
                email.From = new MailAddress(remetente);
                email.To.Add(para);

                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = assunto;
                email.Body = mensagem;
                email.IsBodyHtml = true;

                // Adiciona Imagem no Corpo do Email
                AdicionarImagem(email);

                
                // Configura os parâmetros do objeto SMTP
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;


                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(remetente, senha);

                // Envia a mensagem
                smtp.Send(email);

            });
        }

        public string CriarMensagemComHtml(string mensagem)
        {
            // Lê o html do arquivo email.html
            string html = System.IO.File.ReadAllText("Plugin/email.html");

            // Substitui as quebras de linhas pela tag <br>
            mensagem = mensagem.Replace("\n", "<br>");

            // Coloca a mensagem no template em html
            mensagem = html.Replace("{MENSAGEM}", mensagem);
            
            return mensagem;
        }

        public void AdicionarImagem(MailMessage mail)
        {
            string attachmentPath = "Plugin/emailicon.png";
            Attachment inline = new Attachment(attachmentPath);
            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            inline.ContentId = "icon";
            inline.ContentType.MediaType = "image/png";

            mail.Attachments.Add(inline);

        }
    }
}
